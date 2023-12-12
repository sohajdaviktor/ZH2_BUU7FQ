namespace ZH2_BUU7FQ
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            instructorSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salutationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            statusBindingSource = new BindingSource(components);
            employementFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employementFkNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusFkNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instructorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instructorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { instructorSkDataGridViewTextBoxColumn, salutationDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, statusFkDataGridViewTextBoxColumn, employementFkDataGridViewTextBoxColumn, employementFkNavigationDataGridViewTextBoxColumn, lessonsDataGridViewTextBoxColumn, statusFkNavigationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = instructorBindingSource;
            dataGridView1.Location = new Point(20, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(559, 367);
            dataGridView1.TabIndex = 0;
            // 
            // instructorSkDataGridViewTextBoxColumn
            // 
            instructorSkDataGridViewTextBoxColumn.DataPropertyName = "InstructorSk";
            instructorSkDataGridViewTextBoxColumn.HeaderText = "InstructorSk";
            instructorSkDataGridViewTextBoxColumn.Name = "instructorSkDataGridViewTextBoxColumn";
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // statusFkDataGridViewTextBoxColumn
            // 
            statusFkDataGridViewTextBoxColumn.DataPropertyName = "StatusFk";
            statusFkDataGridViewTextBoxColumn.DataSource = statusBindingSource;
            statusFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            statusFkDataGridViewTextBoxColumn.HeaderText = "StatusFk";
            statusFkDataGridViewTextBoxColumn.Name = "statusFkDataGridViewTextBoxColumn";
            statusFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            statusFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            statusFkDataGridViewTextBoxColumn.ValueMember = "StatusId";
            // 
            // statusBindingSource
            // 
            statusBindingSource.DataSource = typeof(Models.Status);
            // 
            // employementFkDataGridViewTextBoxColumn
            // 
            employementFkDataGridViewTextBoxColumn.DataPropertyName = "EmployementFk";
            employementFkDataGridViewTextBoxColumn.HeaderText = "EmployementFk";
            employementFkDataGridViewTextBoxColumn.Name = "employementFkDataGridViewTextBoxColumn";
            // 
            // employementFkNavigationDataGridViewTextBoxColumn
            // 
            employementFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "EmployementFkNavigation";
            employementFkNavigationDataGridViewTextBoxColumn.HeaderText = "EmployementFkNavigation";
            employementFkNavigationDataGridViewTextBoxColumn.Name = "employementFkNavigationDataGridViewTextBoxColumn";
            employementFkNavigationDataGridViewTextBoxColumn.Visible = false;
            // 
            // lessonsDataGridViewTextBoxColumn
            // 
            lessonsDataGridViewTextBoxColumn.DataPropertyName = "Lessons";
            lessonsDataGridViewTextBoxColumn.HeaderText = "Lessons";
            lessonsDataGridViewTextBoxColumn.Name = "lessonsDataGridViewTextBoxColumn";
            lessonsDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusFkNavigationDataGridViewTextBoxColumn
            // 
            statusFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "StatusFkNavigation";
            statusFkNavigationDataGridViewTextBoxColumn.HeaderText = "StatusFkNavigation";
            statusFkNavigationDataGridViewTextBoxColumn.Name = "statusFkNavigationDataGridViewTextBoxColumn";
            statusFkNavigationDataGridViewTextBoxColumn.Visible = false;
            // 
            // instructorBindingSource
            // 
            instructorBindingSource.DataSource = typeof(Models.Instructor);
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(609, 422);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)instructorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn instructorSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn statusFkDataGridViewTextBoxColumn;
        private BindingSource statusBindingSource;
        private DataGridViewTextBoxColumn employementFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkNavigationDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
    }
}
