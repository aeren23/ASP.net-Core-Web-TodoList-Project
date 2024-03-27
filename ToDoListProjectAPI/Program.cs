using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ToDoList.BusinessLayer.Abstract;
using ToDoList.BusinessLayer.Concrete;
using ToDoList.DataAccessLayer.Abstract;
using ToDoList.DataAccessLayer.Concrete;
using ToDoList.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configurations
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<ITaskDal, EfTaskDal>();
builder.Services.AddScoped<ITaskService, TaskManager>();

builder.Services.AddScoped<ICompletedTaskDal, EfCompletedTaskDal>();
builder.Services.AddScoped<ICompletedTaskService, CompletedTaskManager>();
//-------------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});
//-------------------------
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
