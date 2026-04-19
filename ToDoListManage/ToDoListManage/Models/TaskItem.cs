using System;

namespace ToDoListManage.Models
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime Reminder { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return Title + " | " + Category + " | " + Deadline.ToShortDateString();
        }
    }
}