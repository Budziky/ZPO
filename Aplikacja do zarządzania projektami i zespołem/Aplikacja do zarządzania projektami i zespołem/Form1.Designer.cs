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
            dgvTasks = new DataGridView();
            cmbStatus = new ComboBox();
            btnFilter = new Button();
            btnAddTask = new Button();
            btnAddProject = new Button();
            btnAddUser = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
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
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(431, 70);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(357, 204);
            dgvTasks.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(479, 289);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(139, 23);
            cmbStatus.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(644, 289);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(72, 24);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filtruj";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(431, 334);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(149, 25);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Dodaj zadanie";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 8;
            label1.Text = "Zarządzanie projektami oraz zadaniami";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 52);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Zadania:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 292);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 292);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnAddUser);
            Controls.Add(btnAddProject);
            Controls.Add(btnAddTask);
            Controls.Add(btnFilter);
            Controls.Add(cmbStatus);
            Controls.Add(dgvTasks);
            Controls.Add(lstProjects);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProjects;
        private DataGridView dgvTasks;
        private ComboBox cmbStatus;
        private Button btnFilter;
        private Button btnAddTask;
        private Button btnAddProject;
        private Button btnAddUser;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
