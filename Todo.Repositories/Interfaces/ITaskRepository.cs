using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Todo.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        List<TaskEntity> GetAll();
        List<TaskEntity> Add(string title);
        List<TaskEntity> Done();
        List<TaskEntity> Delete(int taskId);
    }
}
