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
        private List<User> teamMembers;
        public Form3(TaskItem task, List<User> teamMembers)
        {
            InitializeComponent();
            this.task = task;
            this.teamMembers = teamMembers;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            txtDueDate.Text = task.DueDate?.ToShortDateString() ?? "Brak terminu";
            txtPriority.Text = task.Priority.ToString();
            txtStatus.Text = task.Status.ToString();

            clbUsers.Items.Clear();
            foreach (var user in teamMembers)
            {
                int index = clbUsers.Items.Add(user.Name);
                if (task.AssignedUsers.Any(u => u.Id == user.Id))
                    clbUsers.SetItemChecked(index, true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedNames = clbUsers.CheckedItems.Cast<string>().ToList();
            task.AssignedUsers = teamMembers.Where(u => selectedNames.Contains(u.Name)).ToList();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
