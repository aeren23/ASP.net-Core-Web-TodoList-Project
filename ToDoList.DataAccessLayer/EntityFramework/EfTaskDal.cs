using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAccessLayer.Abstract;
using ToDoList.DataAccessLayer.Concrete;
using ToDoList.DataAccessLayer.Repositories;

namespace ToDoList.DataAccessLayer.EntityFramework
{
    public class EfTaskDal:GenericRepository<ToDoList.EntityLayer.Concrete.Task>,ITaskDal
    {
        public EfTaskDal(Context context) : base(context) 
        {

        }
    }
}
