using System;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
                lblStatus.Text = $"Task added at {DateTime.Now:T}";
            }
            else
            {
                MessageBox.Show("Please enter a task first.", "No Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblStatus.Text = "No task entered.";
            }
        }
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                lblStatus.Text = "No task selected to remove.";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this task?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    lblStatus.Text = "Delete canceled.";
                    return;
                }
            }

            lstTasks.Items.Remove(lstTasks.SelectedItem);
            lblStatus.Text = "Task removed.";
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lstTasks.Items.Count > 0)
            {
                lstTasks.Items.Clear();
                lblStatus.Text = "All tasks cleared.";
            }
            else
            {
                lblStatus.Text = "Task list is already empty.";
            }
        }
        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            btnAddTask.Enabled = !string.IsNullOrWhiteSpace(txtTask.Text);
        }
        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lblStatus.Text = $"Selected task: {lstTasks.SelectedItem}";
            }
        }
    }
}
