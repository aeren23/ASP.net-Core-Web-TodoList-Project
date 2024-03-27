using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BusinessLayer.Abstract;
using ToDoList.DataAccessLayer.Abstract;

namespace ToDoList.BusinessLayer.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskDal _taskDal;
        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public void TDelete(EntityLayer.Concrete.Task t)
        {
            _taskDal.Delete(t);
        }

        public EntityLayer.Concrete.Task TGetByID(int id)
        {
            return _taskDal.GetByID(id);
        }

        public List<EntityLayer.Concrete.Task> TGetList()
        {
            return _taskDal.GetList();
        }

        public void TInsert(EntityLayer.Concrete.Task t)
        {
            _taskDal.Insert(t);
        }

        public void TUpdate(EntityLayer.Concrete.Task t)
        {
            _taskDal.Update(t);
        }
    }
}
