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
            grpSortTasks = new GroupBox();
            rdoCategory = new RadioButton();
            rdoDeadline = new RadioButton();
            rdoTitle = new RadioButton();
            btnDeleteTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            grpSortTasks.SuspendLayout();
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
            // grpSortTasks
            // 
            grpSortTasks.Controls.Add(rdoCategory);
            grpSortTasks.Controls.Add(rdoDeadline);
            grpSortTasks.Controls.Add(rdoTitle);
            grpSortTasks.Location = new Point(367, 0);
            grpSortTasks.Name = "grpSortTasks";
            grpSortTasks.Size = new Size(517, 81);
            grpSortTasks.TabIndex = 5;
            grpSortTasks.TabStop = false;
            grpSortTasks.Text = "Sort Options";
            // 
            // rdoCategory
            // 
            rdoCategory.AutoSize = true;
            rdoCategory.Location = new Point(326, 37);
            rdoCategory.Name = "rdoCategory";
            rdoCategory.Size = new Size(174, 36);
            rdoCategory.TabIndex = 2;
            rdoCategory.TabStop = true;
            rdoCategory.Text = "By Category";
            rdoCategory.UseVisualStyleBackColor = true;
            rdoCategory.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rdoDeadline
            // 
            rdoDeadline.AutoSize = true;
            rdoDeadline.Location = new Point(147, 37);
            rdoDeadline.Name = "rdoDeadline";
            rdoDeadline.Size = new Size(173, 36);
            rdoDeadline.TabIndex = 1;
            rdoDeadline.TabStop = true;
            rdoDeadline.Text = "By Deadline";
            rdoDeadline.UseVisualStyleBackColor = true;
            rdoDeadline.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // rdoTitle
            // 
            rdoTitle.AutoSize = true;
            rdoTitle.Location = new Point(17, 37);
            rdoTitle.Name = "rdoTitle";
            rdoTitle.Size = new Size(124, 36);
            rdoTitle.TabIndex = 0;
            rdoTitle.TabStop = true;
            rdoTitle.Text = "By Title";
            rdoTitle.UseVisualStyleBackColor = true;
            rdoTitle.CheckedChanged += SortRadioButton_CheckedChanged;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(294, 340);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(160, 40);
            btnDeleteTask.TabIndex = 6;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(896, 410);
            Controls.Add(btnDeleteTask);
            Controls.Add(grpSortTasks);
            Controls.Add(dgvTasks);
            Controls.Add(lblTitle);
            Controls.Add(btnEditTask);
            Controls.Add(btnAddTask);
            Name = "MainForm";
            Text = "To-Do List Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            grpSortTasks.ResumeLayout(false);
            grpSortTasks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvTasks;
        private GroupBox grpSortTasks;
        private RadioButton rdoCategory;
        private RadioButton rdoDeadline;
        private RadioButton rdoTitle;
        private Button btnDeleteTask;
    }
}