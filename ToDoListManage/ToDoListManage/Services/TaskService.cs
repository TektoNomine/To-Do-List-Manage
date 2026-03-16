using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListManage.Models;

namespace ToDoListManage.Services
{
    public class TaskService
    {
        public List<TaskItem> Tasks { get; private set; } = new List<TaskItem>();

        public void AddTask(TaskItem task)
        {
            Tasks.Add(task);
        }
        public void RemoveTask(TaskItem task)
        {
            Tasks.Remove(task);
        }
        public TaskItem GetTask(int index)
        {
            return Tasks[index];
        }

    }
}
