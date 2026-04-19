namespace ToDoListManage.UI
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddTask = new Button();
            btnEditTask = new Button();
            lblTitle = new Label();
            dgvTasks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(42, 340);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(120, 40);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(168, 340);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(120, 40);
            btnEditTask.TabIndex = 2;
            btnEditTask.Text = "Edit Task";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 44);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "To-Do List App";
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(42, 87);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 82;
            dgvTasks.Size = new Size(842, 231);
            dgvTasks.TabIndex = 4;
            // 
            // MainForm
            // 
            ClientSize = new Size(896, 410);
            Controls.Add(dgvTasks);
            Controls.Add(lblTitle);
            Controls.Add(btnEditTask);
            Controls.Add(btnAddTask);
            Name = "MainForm";
            Text = "To-Do List Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvTasks;
    }
}