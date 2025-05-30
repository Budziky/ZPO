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
            lblAssigned = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtDueDate = new TextBox();
            txtPriority = new TextBox();
            txtStatus = new TextBox();
            clbUsers = new CheckedListBox();
            btnSavedUsers = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(29, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tytuł";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(84, 23);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(31, 15);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Opis";
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Location = new Point(137, 23);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(43, 15);
            lblDue.TabIndex = 2;
            lblDue.Text = "Termin";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(203, 23);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(39, 15);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Status";
            // 
            // lblAssigned
            // 
            lblAssigned.AutoSize = true;
            lblAssigned.Location = new Point(272, 23);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new Size(63, 15);
            lblAssigned.TabIndex = 4;
            lblAssigned.Text = "Przypisany";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 68);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 68);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(272, 68);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(100, 23);
            txtDueDate.TabIndex = 7;
            // 
            // txtPriority
            // 
            txtPriority.Location = new Point(396, 68);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(100, 23);
            txtPriority.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(528, 68);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 9;
            // 
            // clbUsers
            // 
            clbUsers.FormattingEnabled = true;
            clbUsers.Location = new Point(12, 154);
            clbUsers.Name = "clbUsers";
            clbUsers.Size = new Size(120, 94);
            clbUsers.TabIndex = 10;
            // 
            // btnSavedUsers
            // 
            btnSavedUsers.Location = new Point(203, 154);
            btnSavedUsers.Name = "btnSavedUsers";
            btnSavedUsers.Size = new Size(195, 23);
            btnSavedUsers.TabIndex = 11;
            btnSavedUsers.Text = "Zapisz użytkowników";
            btnSavedUsers.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSavedUsers);
            Controls.Add(clbUsers);
            Controls.Add(txtStatus);
            Controls.Add(txtPriority);
            Controls.Add(txtDueDate);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblAssigned);
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
        private Label lblAssigned;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtDueDate;
        private TextBox txtPriority;
        private TextBox txtStatus;
        private CheckedListBox clbUsers;
        private Button btnSavedUsers;
    }
}