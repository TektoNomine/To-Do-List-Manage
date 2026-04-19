using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoListManage.Models;
using System.Linq;

namespace ToDoListManage.UI
{
    public partial class MainForm : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public MainForm()
        {
            InitializeComponent();
            SetupTaskGrid();

            //set up data
            tasks.Add(new TaskItem("Read book", "Read 30 pages", "Study", new DateTime(2026, 4, 23), new DateTime(2026, 4, 22), true));
            tasks.Add(new TaskItem("Clean room", "Vacuum and desk", "Home", new DateTime(2026, 4, 18), new DateTime(2026, 4, 17), false));
            tasks.Add(new TaskItem("Math homework", "Do exercises 5 and 6", "Study", new DateTime(2026, 4, 25), new DateTime(2026, 4, 24), false));
            tasks.Add(new TaskItem("Call teacher", "Ask about project", "Work", new DateTime(2026, 4, 22), new DateTime(2026, 4, 21), false));
            tasks.Add(new TaskItem("Buy food", "Milk and bread", "Personal", new DateTime(2026, 4, 20), new DateTime(2026, 4, 19), true));
            RefreshTaskList();

        }

        private void SetupTaskGrid()
        {
            dgvTasks.Columns.Clear();

            dgvTasks.ColumnCount = 6;
            dgvTasks.Columns[0].Name = "Title";
            dgvTasks.Columns[1].Name = "Description";
            dgvTasks.Columns[2].Name = "Category";
            dgvTasks.Columns[3].Name = "Deadline";
            dgvTasks.Columns[4].Name = "Reminder";
            dgvTasks.Columns[5].Name = "Completed";

            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.MultiSelect = false;
            dgvTasks.ReadOnly = true;
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.RowHeadersVisible = false;
        }

        private void RefreshTaskList()
        {
            dgvTasks.Rows.Clear();

            foreach (TaskItem task in tasks)
            {
                dgvTasks.Rows.Add(
                    task.Title,
                    task.Description,
                    task.Category,
                    task.Deadline.ToShortDateString(),
                    task.Reminder.ToShortDateString(),
                    task.IsCompleted ? "Yes" : "No"
                );
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();

            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(taskForm.TaskData);
                RefreshTaskList();
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            int index = dgvTasks.SelectedRows[0].Index;
            TaskItem selectedTask = tasks[index];

            TaskForm taskForm = new TaskForm(selectedTask);

            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                selectedTask.Title = taskForm.TaskData.Title;
                selectedTask.Description = taskForm.TaskData.Description;
                selectedTask.Category = taskForm.TaskData.Category;
                selectedTask.Deadline = taskForm.TaskData.Deadline;
                selectedTask.Reminder = taskForm.TaskData.Reminder;
                selectedTask.IsCompleted = taskForm.TaskData.IsCompleted;//add for dima

                RefreshTaskList();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dgvTasks.Rows.Clear();

            if (rdoTitle.Checked)
            {
                tasks = tasks.OrderBy(t => t.Title).ToList();
            }
            else if (rdoDeadline.Checked)
            {
                tasks = tasks.OrderBy(t => t.Deadline).ToList();
            }
            else if (rdoCategory.Checked)
            {
                tasks = tasks.OrderBy(t => t.Category).ToList();
            }

            foreach (TaskItem task in tasks)
            {
                dgvTasks.Rows.Add(
                    task.Title,
                    task.Description,
                    task.Category,
                    task.Deadline.ToShortDateString(),
                    task.Reminder.ToShortDateString(),
                    task.IsCompleted ? "Yes" : "No"
                );
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task");
                return;
            }
            int index = dgvTasks.SelectedRows[0].Index;
            tasks.RemoveAt(index);

            RefreshTaskList();
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select task");
                return;
            }

            int index = dgvTasks.SelectedRows[0].Index;
            tasks[index].IsCompleted = true;

            RefreshTaskList();
        }
    }
}