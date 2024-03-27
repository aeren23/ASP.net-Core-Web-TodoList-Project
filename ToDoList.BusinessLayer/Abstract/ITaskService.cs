using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BusinessLayer.Abstract
{
    public interface ITaskService:IGenericService<EntityLayer.Concrete.Task>
    {
    }
}
