using System;
using System.Windows.Forms;
using ToDoListManage.Models;

namespace ToDoListManage.UI
{
    public partial class TaskForm : Form
    {
        public TaskItem TaskData { get; private set; }

        public TaskForm()
        {
            InitializeComponent();
            TaskData = new TaskItem();
            this.Text = "Add Task";
        }

        public TaskForm(TaskItem existingTask)
        {
            InitializeComponent();

            this.Text = "Edit Task";

            TaskData = new TaskItem();
            TaskData.Title = existingTask.Title;
            TaskData.Description = existingTask.Description;
            TaskData.Category = existingTask.Category;
            TaskData.Deadline = existingTask.Deadline;
            TaskData.Reminder = existingTask.Reminder;
            TaskData.IsCompleted = existingTask.IsCompleted;

            txtTitle.Text = existingTask.Title;
            txtDescription.Text = existingTask.Description;
            txtCategory.Text = existingTask.Category;
            dtpDeadline.Value = existingTask.Deadline;
            dtpReminder.Value = existingTask.Reminder;
            chkCompleted.Checked = existingTask.IsCompleted;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            TaskData.Title = txtTitle.Text;
            TaskData.Description = txtDescription.Text;
            TaskData.Category = txtCategory.Text;
            TaskData.Deadline = dtpDeadline.Value;
            TaskData.Reminder = dtpReminder.Value;
            TaskData.IsCompleted = chkCompleted.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}