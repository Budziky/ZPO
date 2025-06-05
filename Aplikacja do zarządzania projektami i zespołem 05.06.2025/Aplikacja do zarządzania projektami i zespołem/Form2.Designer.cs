namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTasks = new DataGridView();
            btnAddTask = new Button();
            cmbStatus = new ComboBox();
            btnFilter = new Button();
            lblProjectName = new Label();
            lblFilter = new Label();
            cmbAddTeamMember = new ComboBox();
            btnAddUserToProject = new Button();
            btnExitProject = new Button();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(12, 39);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(776, 252);
            dgvTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(12, 415);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(176, 23);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Dodaj zadanie";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(12, 316);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(176, 23);
            cmbStatus.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(203, 316);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(95, 25);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filtruj";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(350, 10);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(38, 15);
            lblProjectName.TabIndex = 4;
            lblProjectName.Text = "label1";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(12, 298);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(37, 15);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filtruj";
            // 
            // cmbAddTeamMember
            // 
            cmbAddTeamMember.FormattingEnabled = true;
            cmbAddTeamMember.Location = new Point(12, 359);
            cmbAddTeamMember.Name = "cmbAddTeamMember";
            cmbAddTeamMember.Size = new Size(176, 23);
            cmbAddTeamMember.TabIndex = 7;
            cmbAddTeamMember.SelectedIndexChanged += cmbAddTeamMember_SelectedIndexChanged;
            // 
            // btnAddUserToProject
            // 
            btnAddUserToProject.Location = new Point(203, 359);
            btnAddUserToProject.Name = "btnAddUserToProject";
            btnAddUserToProject.Size = new Size(206, 23);
            btnAddUserToProject.TabIndex = 8;
            btnAddUserToProject.Text = "Dodaj użytkownika do projektu";
            btnAddUserToProject.UseVisualStyleBackColor = true;
            btnAddUserToProject.Click += btnAddUserToProject_Click;
            // 
            // btnExitProject
            // 
            btnExitProject.Location = new Point(625, 415);
            btnExitProject.Name = "btnExitProject";
            btnExitProject.Size = new Size(163, 23);
            btnExitProject.TabIndex = 9;
            btnExitProject.Text = "Wyjdź z projektu";
            btnExitProject.UseVisualStyleBackColor = true;
            btnExitProject.Click += btnExitProject_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(314, 316);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(95, 25);
            btnResetFilter.TabIndex = 10;
            btnResetFilter.Text = "Resetuj Filtr";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResetFilter);
            Controls.Add(btnExitProject);
            Controls.Add(btnAddUserToProject);
            Controls.Add(cmbAddTeamMember);
            Controls.Add(lblFilter);
            Controls.Add(lblProjectName);
            Controls.Add(btnFilter);
            Controls.Add(cmbStatus);
            Controls.Add(btnAddTask);
            Controls.Add(dgvTasks);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTasks;
        private Button btnAddTask;
        private ComboBox cmbStatus;
        private Button btnFilter;
        private Label lblProjectName;
        private Label lblFilter;
        private ComboBox cmbAddTeamMember;
        private Button btnAddUserToProject;
        private Button btnExitProject;
        private Button btnResetFilter;
    }
}