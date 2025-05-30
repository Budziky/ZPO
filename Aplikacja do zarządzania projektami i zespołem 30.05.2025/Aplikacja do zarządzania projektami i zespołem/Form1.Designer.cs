namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstProjects = new ListBox();
            btnAddProject = new Button();
            btnAddUser = new Button();
            btnSave = new Button();
            lblProjectName = new Label();
            label2 = new Label();
            lstUsers = new ListBox();
            lblUserList = new Label();
            SuspendLayout();
            // 
            // lstProjects
            // 
            lstProjects.FormattingEnabled = true;
            lstProjects.ItemHeight = 15;
            lstProjects.Location = new Point(12, 70);
            lstProjects.Name = "lstProjects";
            lstProjects.Size = new Size(366, 289);
            lstProjects.TabIndex = 0;
            lstProjects.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAddProject
            // 
            btnAddProject.Location = new Point(12, 395);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(180, 37);
            btnAddProject.TabIndex = 5;
            btnAddProject.Text = "Dodaj projekt";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(198, 395);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(180, 37);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Dodaj użytkownika";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(599, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 37);
            btnSave.TabIndex = 7;
            btnSave.Text = "Zapisz dane do pliku JSON";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(308, 9);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(211, 15);
            lblProjectName.TabIndex = 8;
            lblProjectName.Text = "Zarządzanie projektami oraz zadaniami";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "Projekty:";
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(422, 70);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(366, 289);
            lstUsers.TabIndex = 10;
            // 
            // lblUserList
            // 
            lblUserList.AutoSize = true;
            lblUserList.Location = new Point(422, 52);
            lblUserList.Name = "lblUserList";
            lblUserList.Size = new Size(74, 15);
            lblUserList.TabIndex = 11;
            lblUserList.Text = "Użytkownicy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUserList);
            Controls.Add(lstUsers);
            Controls.Add(label2);
            Controls.Add(lblProjectName);
            Controls.Add(btnSave);
            Controls.Add(btnAddUser);
            Controls.Add(btnAddProject);
            Controls.Add(lstProjects);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProjects;
        private Button btnAddProject;
        private Button btnAddUser;
        private Button btnSave;
        private Label lblProjectName;
        private Label label2;
        private ListBox lstUsers;
        private Label lblUserList;
    }
}
