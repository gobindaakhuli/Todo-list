using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public TaskEntity(int id, string title, bool isDone)
        {
            Id = id;
            Title = title;
            IsDone = isDone;
        }
    }
}
