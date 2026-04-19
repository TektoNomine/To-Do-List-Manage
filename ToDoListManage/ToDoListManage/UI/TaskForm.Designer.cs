namespace ToDoListManage.UI
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtCategory = new TextBox();
            dtpDeadline = new DateTimePicker();
            dtpReminder = new DateTimePicker();
            chkCompleted = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(451, 47);
            txtTitle.Margin = new Padding(6, 7, 6, 7);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(212, 39);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(451, 158);
            txtDescription.Margin = new Padding(6, 7, 6, 7);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(212, 39);
            txtDescription.TabIndex = 1;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(451, 263);
            txtCategory.Margin = new Padding(6, 7, 6, 7);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(212, 39);
            txtCategory.TabIndex = 2;
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(451, 473);
            dtpDeadline.Margin = new Padding(6, 7, 6, 7);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(429, 39);
            dtpDeadline.TabIndex = 3;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(451, 657);
            dtpReminder.Margin = new Padding(6, 7, 6, 7);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(429, 39);
            dtpReminder.TabIndex = 4;
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.Location = new Point(451, 800);
            chkCompleted.Margin = new Padding(6, 7, 6, 7);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(164, 36);
            chkCompleted.TabIndex = 5;
            chkCompleted.Text = "Completed";
            chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(451, 945);
            btnSave.Margin = new Padding(6, 7, 6, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 57);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(919, 945);
            btnCancel.Margin = new Padding(6, 7, 6, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(162, 57);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 64);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 175);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 271);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 490);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 11;
            label4.Text = "Deadline";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 674);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 12;
            label5.Text = "Reminder";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1108);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkCompleted);
            Controls.Add(dtpReminder);
            Controls.Add(dtpDeadline);
            Controls.Add(txtCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Margin = new Padding(6, 7, 6, 7);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}