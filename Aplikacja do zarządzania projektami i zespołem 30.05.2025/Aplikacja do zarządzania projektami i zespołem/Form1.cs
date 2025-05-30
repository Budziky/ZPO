namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    public partial class Form1 : Form
    {
        private List<Project> projects = new List<Project>();
        private List<User> globalUsers = new List<User>();

        public Form1()
        {
            InitializeComponent();
            lstProjects.DoubleClick += lstProjects_DoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshProjects()
        {
            lstProjects.DataSource = null;
            lstProjects.DataSource = projects;
            lstProjects.DisplayMember = "Name";
        }   

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedProject = lstProjects.SelectedItem as Project;
            //PopulateTasksGrid();
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

            var project = new Project { Name = name, Description = description };
            projects.Add(project);
            RefreshProjects();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Podaj imię i nazwisko:");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Podaj email:");
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Podaj telefon:");

            globalUsers.Add(new User { Name = name, Email = email, PhoneNumber = phone });
            MessageBox.Show("Dodano użytkownika globalnego.");
        }

        private void lstProjects_DoubleClick(object sender, EventArgs e)
        {
            if (lstProjects.SelectedItem is Project selectedProject)
            {
                var form2 = new Form2(selectedProject, globalUsers);
                form2.ShowDialog();
            }
        }
    }
}
