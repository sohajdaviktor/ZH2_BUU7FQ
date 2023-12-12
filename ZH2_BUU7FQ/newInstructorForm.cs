using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_BUU7FQ
{
    public partial class newInstructorForm : Form
    {
        public newInstructorForm()
        {
            InitializeComponent();
        }

        private bool CheckName(string name)
        {
            return string.IsNullOrEmpty(name);
        }


        private bool CheckStatus(string status)
        {

            Regex r = new Regex("^[1-6]$");
            return r.IsMatch(status);
        }

        private bool CheckEmployment(string employment)
        {

            Regex r = new Regex("^[CFH]$");
            return r.IsMatch(employment);
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, "");
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (CheckName(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "A név nem lehet üres");
            }
        }

        private void textBoxStatus_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxStatus, "");
        }

        private void textBoxStatus_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckStatus(textBoxStatus.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxStatus, "A státusz 1-6 között lehet!");
            }
        }

        private void textBoxEmployment_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmployment, "");
        }

        private void textBoxEmployment_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmployment(textBoxEmployment.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmployment, "Az employment C, F vagy H!");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
