namespace ZH2_BUU7FQ
{
    partial class newInstructorForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBoxName = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxStatus = new TextBox();
            textBoxEmployment = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Salutation";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Employment";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(15, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(15, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 6;
            textBoxName.Validating += textBoxName_Validating;
            textBoxName.Validated += textBoxName_Validated;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxStatus.Location = new Point(15, 145);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(100, 23);
            textBoxStatus.TabIndex = 8;
            textBoxStatus.Validating += textBoxStatus_Validating;
            textBoxStatus.Validated += textBoxStatus_Validated;
            // 
            // textBoxEmployment
            // 
            textBoxEmployment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmployment.Location = new Point(15, 200);
            textBoxEmployment.Name = "textBoxEmployment";
            textBoxEmployment.Size = new Size(100, 23);
            textBoxEmployment.TabIndex = 9;
            textBoxEmployment.Validating += textBoxEmployment_Validating;
            textBoxEmployment.Validated += textBoxEmployment_Validated;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = SystemColors.ButtonHighlight;
            buttonOk.Location = new Point(28, 276);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(59, 39);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.BackColor = SystemColors.ButtonHighlight;
            buttonCancel.CausesValidation = false;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(141, 276);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(59, 39);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "&Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // newInstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(243, 327);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxEmployment);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxName);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "newInstructorForm";
            Text = "newInstructorForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        public TextBox textBox1;
        public TextBox textBoxName;
        public TextBox textBoxStatus;
        public TextBox textBoxEmployment;
        private Button buttonOk;
        private Button buttonCancel;
        private ErrorProvider errorProvider1;
    }
}