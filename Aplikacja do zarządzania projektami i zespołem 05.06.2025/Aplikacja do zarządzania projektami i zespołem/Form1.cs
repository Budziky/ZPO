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
                MessageBox.Show("Nazwa projektu jest wymagana.");
                return;
            }

            string description = Microsoft.VisualBasic.Interaction.InputBox("Podaj opis projektu:");

            string priorityInput = Microsoft.VisualBasic.Interaction.InputBox("Podaj priorytet projektu (Niski, Średni, Wysoki):");
            if (!Enum.TryParse(priorityInput, true, out PriorityLevel priority))
            {
                MessageBox.Show("Nieprawidłowy priorytet. Wybierz: Niski, Średni lub Wysoki.");
                return;
            }

            var project = new Project { Name = name, Description = description, Tasks = new List<TaskItem>(), TeamMemberIds = new List<Guid>() };
            appData.Projects.Add(project);
            RefreshProjects();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Podaj imię i nazwisko:");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Podaj email:");
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Podaj telefon:");

            appData.Users.Add(new User { Name = name, Email = email, PhoneNumber = phone });
            RefreshUsers();
            MessageBox.Show("Dodano użytkownika.");
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
