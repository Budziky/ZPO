namespace Aplikacja_do_zarządzania_projektami_i_zespołem
{
    partial class Form3
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
            lblTitle = new Label();
            lblDesc = new Label();
            lblDue = new Label();
            lblPriority = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtDueDate = new TextBox();
            btnSavedUsers = new Button();
            lbAvailableUsers = new ListBox();
            lbAssignedUsers = new ListBox();
            btnAddUserToTask = new Button();
            btnRemoveUserFromTask = new Button();
            cmbStatus = new ComboBox();
            cmbPriority = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(73, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tytuł";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(228, 40);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(31, 15);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Opis";
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Location = new Point(368, 40);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(43, 15);
            lblDue.TabIndex = 2;
            lblDue.Text = "Termin";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(537, 40);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(39, 15);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Status";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(25, 58);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(133, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(182, 58);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(133, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(331, 58);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(133, 23);
            txtDueDate.TabIndex = 7;
            // 
            // btnSavedUsers
            // 
            btnSavedUsers.Location = new Point(311, 415);
            btnSavedUsers.Name = "btnSavedUsers";
            btnSavedUsers.Size = new Size(195, 23);
            btnSavedUsers.TabIndex = 11;
            btnSavedUsers.Text = "Zapisz";
            btnSavedUsers.UseVisualStyleBackColor = true;
            btnSavedUsers.Click += btnSavedUsers_Click;
            // 
            // lbAvailableUsers
            // 
            lbAvailableUsers.FormattingEnabled = true;
            lbAvailableUsers.ItemHeight = 15;
            lbAvailableUsers.Location = new Point(25, 101);
            lbAvailableUsers.Name = "lbAvailableUsers";
            lbAvailableUsers.Size = new Size(321, 109);
            lbAvailableUsers.TabIndex = 12;
            lbAvailableUsers.SelectedIndexChanged += lblAvaiableUsers_SelectedIndexChanged;
            // 
            // lbAssignedUsers
            // 
            lbAssignedUsers.FormattingEnabled = true;
            lbAssignedUsers.ItemHeight = 15;
            lbAssignedUsers.Location = new Point(449, 101);
            lbAssignedUsers.Name = "lbAssignedUsers";
            lbAssignedUsers.Size = new Size(321, 109);
            lbAssignedUsers.TabIndex = 13;
            lbAssignedUsers.SelectedIndexChanged += lblAssignedUsers_SelectedIndexChanged;
            // 
            // btnAddUserToTask
            // 
            btnAddUserToTask.Location = new Point(82, 216);
            btnAddUserToTask.Name = "btnAddUserToTask";
            btnAddUserToTask.Size = new Size(205, 23);
            btnAddUserToTask.TabIndex = 14;
            btnAddUserToTask.Text = "Dodaj użytkownika do zadania";
            btnAddUserToTask.UseVisualStyleBackColor = true;
            btnAddUserToTask.Click += btnAddUserToTask_Click;
            // 
            // btnRemoveUserFromTask
            // 
            btnRemoveUserFromTask.Location = new Point(528, 216);
            btnRemoveUserFromTask.Name = "btnRemoveUserFromTask";
            btnRemoveUserFromTask.Size = new Size(172, 23);
            btnRemoveUserFromTask.TabIndex = 15;
            btnRemoveUserFromTask.Text = "Usuń użytkownika z zadania";
            btnRemoveUserFromTask.UseVisualStyleBackColor = true;
            btnRemoveUserFromTask.Click += btnRemoveUserFromTask_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(485, 58);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(133, 23);
            cmbStatus.TabIndex = 16;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(637, 58);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(133, 23);
            cmbPriority.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(680, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 18;
            label1.Text = "Priorytet";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbPriority);
            Controls.Add(cmbStatus);
            Controls.Add(btnRemoveUserFromTask);
            Controls.Add(btnAddUserToTask);
            Controls.Add(lbAssignedUsers);
            Controls.Add(lbAvailableUsers);
            Controls.Add(btnSavedUsers);
            Controls.Add(txtDueDate);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblPriority);
            Controls.Add(lblDue);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDesc;
        private Label lblDue;
        private Label lblPriority;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtDueDate;
        private CheckedListBox clbUsers;
        private Button btnSavedUsers;
        private ListBox lbAvailableUsers;
        private ListBox lbAssignedUsers;
        private Button btnAddUserToTask;
        private Button btnRemoveUserFromTask;
        private ComboBox cmbStatus;
        private ComboBox cmbPriority;
        private Label label1;
    }
}