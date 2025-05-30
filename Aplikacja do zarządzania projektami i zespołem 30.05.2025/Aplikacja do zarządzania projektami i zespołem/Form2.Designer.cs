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
            btnFilter.Location = new Point(216, 316);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filtruj";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(393, 8);
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
            lblFilter.Size = new Size(38, 15);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "label2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}