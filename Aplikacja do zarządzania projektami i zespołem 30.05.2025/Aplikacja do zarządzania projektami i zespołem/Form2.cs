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

        public Form2(Project selectedProject, List<User> globalUsers)
        {
            InitializeComponent();
            this.project = selectedProject;
            this.globalUsers = globalUsers;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Tu np. wyświetlenie danych o projekcie w kontrolkach
            Text = $"Zadania projektu: {project.Name}";
            PopulateTasks();
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
                    AssignedTo = t.AssignedUsers.Count > 0 ? string.Join(", ", t.AssignedUsers.Select(u => u.Name)) : "Nieprzypisane"
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
                var formDetails = new Form3(task, project.TeamMembers);
                if (formDetails.ShowDialog() == DialogResult.OK)
                {
                    PopulateTasks();
                }
            }

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = Microsoft.VisualBasic.Interaction.InputBox("Podaj tytuł zadania:");
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Tytuł jest wymagany.");
                return;
            }

            string description = Microsoft.VisualBasic.Interaction.InputBox("Podaj opis zadania:");
            string dateInput = Microsoft.VisualBasic.Interaction.InputBox("Podaj datę wykonania (rrrr-mm-dd):");

            DateTime? dueDate = null;
            if (DateTime.TryParse(dateInput, out DateTime parsedDate))
                dueDate = parsedDate;

            string priorityInput = Microsoft.VisualBasic.Interaction.InputBox("Podaj priorytet (Low, Medium, High):");
            if (!Enum.TryParse(priorityInput, true, out PriorityLevel priority))
            {
                MessageBox.Show("Nieprawidłowy priorytet.");
                return;
            }

            if (project.TeamMembers.Count == 0)
            {
                MessageBox.Show("Brak członków zespołu w tym projekcie.");
                return;
            }

            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwiska przypisanych użytkowników (oddzielone przecinkami):");
            var selectedNames = userInput.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();

            var assignedUsers = project.TeamMembers
                .Where(u => selectedNames.Contains(u.Name))
                .ToList();

            var newTask = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                Priority = priority,
                AssignedUsers = assignedUsers
            };

            project.Tasks.Add(newTask);
            PopulateTasks();
            MessageBox.Show("Zadanie dodane.");
        }
    }
}
