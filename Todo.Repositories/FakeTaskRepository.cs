using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;
using Todo.Repositories.Interfaces;

namespace Todo.Repositories
{
    public class FakeTaskRepository : ITaskRepository
    {
        public static List<TaskEntity> task = new List<TaskEntity>
                                                {
                                                new TaskEntity(1, "first", false),
                                                new TaskEntity(2, "second", true),
                                                new TaskEntity(3, "third", false),
                                                new TaskEntity(4, "forth", false)
                                                };

        public List<TaskEntity> GetAll()
        {
            //TaskEntity[] task = new TaskEntity[] { new TaskEntity(1, "first", false),
            //                                       new TaskEntity(2, "second", true),
            //                                       new TaskEntity(3, "third", false),
            //                                       new TaskEntity(4, "forth", false)};
            return task;
        }
        public List<TaskEntity> Add(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
               // throw new ArgumentException("empty");
            }
            //TaskEntity newTask = new TaskEntity(1, title, false);
            //task[2] = newTask;
            return GetAll();
        }
        public List<TaskEntity> Done()
        {
            return GetAll();
        }
        public List<TaskEntity> Delete(int taskId)
        {
            task.RemoveAt(taskId);
            return GetAll();
        }
    }
}
