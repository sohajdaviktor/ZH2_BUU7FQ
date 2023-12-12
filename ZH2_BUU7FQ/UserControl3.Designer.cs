namespace ZH2_BUU7FQ
{
    partial class UserControl3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            instructorSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salutationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employementFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employementFkNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusFkNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instructorBindingSource = new BindingSource(components);
            buttonAddInstructor = new Button();
            buttonRemoveInstructor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instructorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Instructors";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { instructorSkDataGridViewTextBoxColumn, salutationDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, statusFkDataGridViewTextBoxColumn, employementFkDataGridViewTextBoxColumn, employementFkNavigationDataGridViewTextBoxColumn, lessonsDataGridViewTextBoxColumn, statusFkNavigationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = instructorBindingSource;
            dataGridView1.Location = new Point(17, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 323);
            dataGridView1.TabIndex = 1;
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
            statusFkDataGridViewTextBoxColumn.HeaderText = "StatusFk";
            statusFkDataGridViewTextBoxColumn.Name = "statusFkDataGridViewTextBoxColumn";
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
            // buttonAddInstructor
            // 
            buttonAddInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddInstructor.BackColor = SystemColors.ButtonHighlight;
            buttonAddInstructor.Location = new Point(588, 102);
            buttonAddInstructor.Name = "buttonAddInstructor";
            buttonAddInstructor.Size = new Size(94, 60);
            buttonAddInstructor.TabIndex = 2;
            buttonAddInstructor.Text = "Add Instructor";
            buttonAddInstructor.UseVisualStyleBackColor = false;
            buttonAddInstructor.Click += buttonAddInstructor_Click;
            // 
            // buttonRemoveInstructor
            // 
            buttonRemoveInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemoveInstructor.BackColor = SystemColors.ButtonHighlight;
            buttonRemoveInstructor.Location = new Point(588, 218);
            buttonRemoveInstructor.Name = "buttonRemoveInstructor";
            buttonRemoveInstructor.Size = new Size(94, 60);
            buttonRemoveInstructor.TabIndex = 3;
            buttonRemoveInstructor.Text = "Remove Instructor";
            buttonRemoveInstructor.UseVisualStyleBackColor = false;
            buttonRemoveInstructor.Click += buttonRemoveInstructor_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(buttonRemoveInstructor);
            Controls.Add(buttonAddInstructor);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserControl3";
            Size = new Size(695, 412);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)instructorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource instructorBindingSource;
        private DataGridViewTextBoxColumn instructorSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkNavigationDataGridViewTextBoxColumn;
        private Button buttonAddInstructor;
        private Button buttonRemoveInstructor;
    }
}
