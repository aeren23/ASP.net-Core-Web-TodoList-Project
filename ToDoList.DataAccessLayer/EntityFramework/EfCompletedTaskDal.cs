using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAccessLayer.Abstract;
using ToDoList.DataAccessLayer.Concrete;
using ToDoList.DataAccessLayer.Repositories;
using ToDoList.EntityLayer.Concrete;

namespace ToDoList.DataAccessLayer.EntityFramework
{
    public class EfCompletedTaskDal:GenericRepository<CompletedTask>,ICompletedTaskDal
    {
        public EfCompletedTaskDal(Context context) : base(context) { }
    }
}
