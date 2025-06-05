using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public partial class Form3 : Form
    {
        private TaskItem task;
        private List<User> allUsers;
        public Form3(TaskItem task, List<User> allUsers)
        {
            InitializeComponent();
            this.task = task;
            this.allUsers = allUsers;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            txtDueDate.Text = task.DueDate?.ToShortDateString() ?? "Brak terminu";

            cmbPriority.DataSource = Enum.GetValues(typeof(PriorityLevel));
            cmbPriority.SelectedItem = task.Priority;

            cmbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
            cmbStatus.SelectedItem = task.Status;

            RefreshUserLists();
        }

        private void RefreshUserLists()
        {
            lbAssignedUsers.Items.Clear();
            lbAvailableUsers.Items.Clear();

            lbAssignedUsers.DisplayMember = "Name";
            lbAvailableUsers.DisplayMember = "Name";

            var assignedIds = task.AssignedUserIds.ToHashSet();

            foreach (var user in allUsers)
            {
                if (assignedIds.Contains(user.Id))
                    lbAssignedUsers.Items.Add(user);
                else
                    lbAvailableUsers.Items.Add(user);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblAvaiableUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAssignedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUserToTask_Click(object sender, EventArgs e)
        {
            if (lbAvailableUsers.SelectedItem is User selectedUser)
            {
                if (!task.AssignedUserIds.Contains(selectedUser.Id))
                    task.AssignedUserIds.Add(selectedUser.Id);
                RefreshUserLists();
            }
        }

        private void btnRemoveUserFromTask_Click(object sender, EventArgs e)
        {
            if (lbAssignedUsers.SelectedItem is User selectedUser)
            {
                task.AssignedUserIds.Remove(selectedUser.Id);
                RefreshUserLists();
            }
            else
            {
                MessageBox.Show("Proszę wybrać użytkownika do usunięcia.");
            }
        }

        private void btnSavedUsers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Tytuł zadania jest wymagany.");
                return;
            }

            task.Title = txtTitle.Text;
            task.Description = txtDescription.Text;

            if (DateTime.TryParse(txtDueDate.Text, out DateTime dueDate))
                task.DueDate = dueDate;
            else
                task.DueDate = null;

            if (cmbPriority.SelectedItem is PriorityLevel priority)
                task.Priority = priority;

            if (cmbStatus.SelectedItem is TaskStatus status)
                task.Status = status;

            task.AssignedUserIds = lbAssignedUsers.Items.Cast<User>().Select(u => u.Id).ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
