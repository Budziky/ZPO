namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public partial class Form1 : Form
    {
        private List<Project> projects = new List<Project>();
        private Project? selectedProject = null;

        private void PopulateProjectsList()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (selectedProject == null)
                return;

            var selectedStatus = (TaskStatus)cmbStatus.SelectedItem;
            var filtered = selectedProject.Tasks
                .Where(t => t.Status == selectedStatus)
                .Select(t => new
                {
                    t.Title,
                    t.Description,
                    Status = t.Status.ToString(),
                    Priority = t.Priority.ToString(),
                    Created = t.CreatedAt.ToShortDateString(),
                    DueDate = t.DueDate?.ToShortDateString() ?? "Brak terminu.",
                    AssignedTo = t.AssignedUser?.Name ?? "Nieprzypisane"
                }).ToList();

            dgvTasks.DataSource = filtered;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(selectedProject == null)
            {
                MessageBox.Show("Wybierz projekt, do którego chcesz dodać zadanie.");
                return;
            }
            
            string title = Microsoft.VisualBasic.Interaction.InputBox("Podaj tytuł zadania: ");
            string description = Microsoft.VisualBasic.Interaction.InputBox("Podaj opis zadania: ");
            DateTime? dueDate = null;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę projektu: ");
            string description = Microsoft.VisualBasic.Interaction.InputBox("Podaj opis projektu: ");

            var newProject = new Project
            {
                Name = name,
                Description = description,
                CreatedAt = DateTime.Now
            };

            projects.Add(newProject);
            PopulateProjectsList();
            MessageBox.Show("Projekt dodany.");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(selectedProject == null)
            {
                MessageBox.Show("Wybierz projekt, do którego chcesz dodać użytkownika.");
                return;
            }

            string name = Microsoft.VisualBasic.Interaction.InputBox("Podaj imię i nazwisko użytkownika: ");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Podaj email użytkownika: ");
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Podaj numer telefonu użytkownika: ");

            var newUser = new User
            {
                Name = name,
                Email = email,
                PhoneNumber = phone
            };

            selectedProject.TeamMembers.Add(newUser);
            MessageBox.Show("Użytkownik dodany do projektu.");
        }
    }
}
