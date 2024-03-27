using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.EntityLayer.Concrete;

namespace ToDoList.DataAccessLayer.Abstract
{
    public interface ITaskDal:IGenericDal<EntityLayer.Concrete.Task>
    {
    }
}
