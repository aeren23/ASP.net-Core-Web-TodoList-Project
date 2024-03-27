using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAccessLayer.Abstract;
using ToDoList.DataAccessLayer.Concrete;

namespace ToDoList.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }
        //public void CheckDatabaseConnection()
        //{
        //    var dbConnection = _context.Database.GetDbConnection();

        //    if (dbConnection.State != System.Data.ConnectionState.Open)
        //    {
        //        Console.WriteLine("Bağlantı Yok");
        //    }
        //}

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
