using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtTask;
        private Button btnAddTask;
        private Button btnRemoveSelected;
        private Button btnClearAll;
        private ListBox lstTasks;
        private Label lblStatus;
        private CheckBox chkConfirmDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            btnRemoveSelected = new Button();
            btnClearAll = new Button();
            lstTasks = new ListBox();
            lblStatus = new Label();
            chkConfirmDelete = new CheckBox();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(40, 20);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(260, 23);
            txtTask.TabIndex = 0;
            txtTask.TextChanged += txtTask_TextChanged;
            // 
            // btnAddTask
            // 
            btnAddTask.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(310, 18);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(90, 27);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveSelected.Location = new Point(40, 60);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(160, 30);
            btnRemoveSelected.TabIndex = 2;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearAll.Location = new Point(220, 60);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(160, 30);
            btnClearAll.TabIndex = 3;
            btnClearAll.Text = "Clear All";
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lstTasks
            // 
            lstTasks.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTasks.ItemHeight = 18;
            lstTasks.Location = new Point(40, 110);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(360, 184);
            lstTasks.TabIndex = 4;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(40, 350);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Font = new Font("Georgia", 12, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkConfirmDelete.Location = new Point(40, 320);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(140, 20);
            chkConfirmDelete.TabIndex = 5;
            chkConfirmDelete.Text = "Confirm Delete";
            // 
            // Form1
            // 
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(450, 420);
            Controls.Add(txtTask);
            Controls.Add(btnAddTask);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnClearAll);
            Controls.Add(lstTasks);
            Controls.Add(chkConfirmDelete);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
