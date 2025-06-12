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
    public partial class Form2 : Form
    {
        private Project project;
        private List<User> globalUsers;
        public Action SaveCallback { get; set; }
        private bool isLoading = false;

        public Form2(Project selectedProject, List<User> globalUsers)
        {
            InitializeComponent();
            this.project = selectedProject;
            this.globalUsers = globalUsers;
            this.cmbAddTeamMember.SelectedIndexChanged += new System.EventHandler(this.cmbAddTeamMember_SelectedIndexChanged);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblProjectName.Text = $"{project.Name}";

            PopulateTasks();
            dgvTasks.DoubleClick += dgvTasks_DoubleClick;
            cmbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
            RefreshComboBoxTeamMembers();
        }

        private void PopulateTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = project.Tasks
                .Select(t => new
                {
                    t.Title,
                    t.Description,
                    Status = t.Status.ToString(),
                    Priority = t.Priority.ToString(),
                    DueDate = t.DueDate?.ToShortDateString() ?? "Brak terminu.",
                    AssignedTo = string.Join(", ", globalUsers
                        .Where(u => t.AssignedUserIds.Contains(u.Id))
                        .Select(u => u.Name))
                })
                .ToList();
        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
                return;

            string title = dgvTasks.CurrentRow.Cells["Title"].Value.ToString();
            var task = project.Tasks.FirstOrDefault(t => t.Title == title);

            if (task != null)
            {
                var formDetails = new Form3(task, globalUsers.Where(u => project.TeamMemberIds.Contains(u.Id)).ToList());
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    PopulateTasks();
                }
            }

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (project.TeamMemberIds.Count == 0)
            {
                MessageBox.Show("Brak członków zespołu w tym projekcie.");
                return;
            }

            var newTask = new TaskItem();

            var form = new Form3(newTask, globalUsers
                .Where(u => project.TeamMemberIds.Contains(u.Id)).ToList());

            if (form.ShowDialog() == DialogResult.OK)
            {
                project.Tasks.Add(newTask);
                PopulateTasks();
            }
        }

        private void cmbAddTeamMember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshComboBoxTeamMembers()
        {
            isLoading = true;

            var availableUsers = globalUsers
                .Where(u => !project.TeamMemberIds.Contains(u.Id))
                .ToList();

            cmbAddTeamMember.DataSource = null;
            cmbAddTeamMember.DataSource = availableUsers;
            cmbAddTeamMember.DisplayMember = "Name";
            cmbAddTeamMember.ValueMember = "Id";

            isLoading = false;
        }

        private void btnAddUserToProject_Click(object sender, EventArgs e)
        {
            if (cmbAddTeamMember.SelectedItem is User selectedUser)
            {
                if (!project.TeamMemberIds.Contains(selectedUser.Id))
                {
                    project.TeamMemberIds.Add(selectedUser.Id);
                    MessageBox.Show($"Dodano użytkownika {selectedUser.Name} do projektu.");
                    RefreshComboBoxTeamMembers();
                }
                else
                {
                    MessageBox.Show("Ten użytkownik jest już członkiem projektu.");
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać użytkownika z listy.");
            }
        }

        private void btnExitProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem is TaskStatus selectedStatus)
            {
                dgvTasks.DataSource = null;
                dgvTasks.DataSource = project.Tasks
                    .Where(t => t.Status == selectedStatus)
                    .Select(t => new
                    {
                        t.Title,
                        t.Description,
                        Status = t.Status.ToString(),
                        Priority = t.Priority.ToString(),
                        DueDate = t.DueDate?.ToShortDateString() ?? "Brak terminu.",
                        AssignedTo = string.Join(", ", globalUsers
                            .Where(u => t.AssignedUserIds.Contains(u.Id))
                            .Select(u => u.Name))
                    })
                    .ToList();
            }
            else
            {
                MessageBox.Show("Proszę wybrać status z listy.");
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            PopulateTasks();
        }
    }
}
