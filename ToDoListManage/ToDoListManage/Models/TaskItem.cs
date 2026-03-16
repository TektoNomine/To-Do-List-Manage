using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListManage.Models
{
    public class TaskItem
    {
        public string Tittle { get; private set; }
        public string Description { get; private set; }
        public DateTime DeadLine { get; private set; }
        public bool IsCompleted { get; private set; }

        public TaskItem() { }

        public TaskItem(string tittle, string description, DateTime deadLine)
        {
            Tittle = tittle;
            Description = description;
            DeadLine = deadLine;
            IsCompleted = false;
        }
        //setters
        public void SetTittle(string tittle)
        {
            Tittle = tittle;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public void SetDeadLine(DateTime deadLine)
        {
            DeadLine = deadLine;
        }
        public void SetIsCompleted(bool isCompleted)
        {
            IsCompleted = isCompleted;
        }

        //methods
        public void UpdateTask(string tittle, string description, DateTime deadLine)
        {
            Tittle = tittle;
            Description = description;
            DeadLine = deadLine;

        }

        public void Complete()
        {
            IsCompleted = true;
        }

    }
}
