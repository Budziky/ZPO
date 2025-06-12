namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public partial class Form1 : Form
    {
        private AppData appData = new AppData();

        public Form1()
        {
            InitializeComponent();
            lstProjects.DoubleClick += lstProjects_DoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RefreshProjects()
        {
            lstProjects.DataSource = null;
            lstProjects.DataSource = appData.Projects;
            lstProjects.DisplayMember = "Name";
        }

        private void RefreshUsers()
        {
            lstUsers.DataSource = null;
            lstUsers.DataSource = appData.Users;
            lstUsers.DisplayMember = "Name";
        }

        private void SaveData()
        {
            DataManager.SaveData(appData);
            MessageBox.Show("Dane zostały zapisane do pliku data.json.");
        }

        private void LoadData()
        {
            appData = DataManager.LoadData();
            RefreshProjects();
            RefreshUsers();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę projektu:");
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Pole Nazwa projektu jest wymagane.");
                return;
            }

            string description = Microsoft.VisualBasic.Interaction.InputBox("Podaj opis projektu:");
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Pole Opis projektu jest wymagane.");
                return;
            }

            string priorityInput = Microsoft.VisualBasic.Interaction.InputBox("Podaj priorytet projektu (Niski, Średni, Wysoki):");
            if (!Enum.TryParse(priorityInput, true, out PriorityLevel priority))
            {
                MessageBox.Show("Nieprawidłowy priorytet. Wybierz: Niski, Średni lub Wysoki.");
                return;
            }

            var project = new Project
            {
                Name = name,
                Description = description,
                Tasks = new List<TaskItem>(),
                TeamMemberIds = new List<Guid>()
            };

            appData.Projects.Add(project);
            RefreshProjects();
            MessageBox.Show("Projekt został dodany.");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Podaj imię i nazwisko:");
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Pole Imię i nazwisko jest wymagane.");
                return;
            }

            string email = Microsoft.VisualBasic.Interaction.InputBox("Podaj email:");
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Pole Email jest wymagane.");
                return;
            }

            string phone = Microsoft.VisualBasic.Interaction.InputBox("Podaj telefon:");
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Pole Telefon jest wymagane.");
                return;
            }

            var user = new User
            {
                Name = name,
                Email = email,
                PhoneNumber = phone
            };

            appData.Users.Add(user);
            RefreshUsers();
            MessageBox.Show("Użytkownik został dodany.");
        }

        private void lstProjects_DoubleClick(object sender, EventArgs e)
        {
            if (lstProjects.SelectedItem is Project selectedProject)
            {
                var form2 = new Form2(selectedProject, appData.Users);
                form2.SaveCallback = SaveData;
                form2.ShowDialog();
                RefreshProjects();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
