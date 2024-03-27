using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.EntityLayer.Concrete
{
    public class CompletedTask
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime DateCompleted { get; set; }
    }
}
