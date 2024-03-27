using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BusinessLayer.Abstract;
using ToDoList.DataAccessLayer.Abstract;
using ToDoList.EntityLayer.Concrete;

namespace ToDoList.BusinessLayer.Concrete
{
    public class CompletedTaskManager : ICompletedTaskService
    {
        private readonly ICompletedTaskDal _completedTaskDal;
        public CompletedTaskManager(ICompletedTaskDal completedTaskDal)
        {
            _completedTaskDal = completedTaskDal;
        }
        public void TDelete(CompletedTask t)
        {
            _completedTaskDal.Delete(t);
        }

        public CompletedTask TGetByID(int id)
        {
            return _completedTaskDal.GetByID(id);
        }

        public List<CompletedTask> TGetList()
        {
            return _completedTaskDal.GetList();
        }

        public void TInsert(CompletedTask t)
        {
            _completedTaskDal.Insert(t);
        }

        public void TUpdate(CompletedTask t)
        {
            _completedTaskDal.Update(t);
        }
    }
}
