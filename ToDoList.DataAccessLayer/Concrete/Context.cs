using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.EntityLayer.Concrete;

namespace ToDoList.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=AliErenPC;initial catalog=ToDoListDatabase;TrustServerCertificate=true;integrated security=true");
        }
        //Configurations ()
        public DbSet<EntityLayer.Concrete.Task> Tasks { get; set; }
        public DbSet<CompletedTask> CompletedTasks { get; set; }
    }
}
