using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_BUU7FQ.Models;

namespace ZH2_BUU7FQ
{
    public partial class UserControl3 : UserControl
    {
        StudentContext context = new StudentContext();
        public UserControl3()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructors.ToList();
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            newInstructorForm newInstructor = new newInstructorForm();
            if (newInstructor.ShowDialog() != DialogResult.OK) return;

            int status;
            int.TryParse(newInstructor.textBoxStatus.Text, out status);
            Instructor instructor = new Instructor()
            {
                Salutation = newInstructor.textBox1.Text,
                Name = newInstructor.textBoxName.Text,
                EmployementFk = newInstructor.textBoxEmployment.Text,
                StatusFk = (byte?)status
            };

            context.Instructors.Add(instructor);

            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Nem sikerült a mentés a következő hiba miatt: {err.InnerException.Message}");
            }

            instructorBindingSource.DataSource = context.Instructors.ToList();
        }

        private void buttonRemoveInstructor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos törölni szeretnéd?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.No) { }
            else
            {
                dynamic actual = dataGridView1.CurrentRow.DataBoundItem;
                int aktId = actual.InstructorSk;
                var törlendő = (from x in context.Instructors
                                where x.InstructorSk == aktId
                                select x).FirstOrDefault();
                context.Instructors.Remove(törlendő);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Nem sikerült a mentés a következő hiba miatt: {err.InnerException.Message}");
                }
                instructorBindingSource.DataSource = context.Instructors.ToList();
            }
        }
    }
}
