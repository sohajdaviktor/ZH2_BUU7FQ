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
    public partial class UserControl1 : UserControl
    {
        private uc1 instructor;
        StudentContext context = new StudentContext();
        public UserControl1()
        {
            InitializeComponent();
            GetInstructors();
        }

        private void GetInstructors()
        {
            var instructors = from x in context.Instructors
                              select new uc1
                              {
                                  instructorName = x.Name,
                                  instructorSk = x.InstructorSk
                              };
            listBox1.DisplayMember = "instructorName";
            listBox1.ValueMember = "instructorSk";
            listBox1.DataSource = instructors.ToList();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            var szures = textBoxName.Text;
            var szurt = from x in context.Instructors
                        where x.Name.Contains(szures)
                        select new uc1
                        {
                            instructorName = x.Name,
                            instructorSk = x.InstructorSk
                        };
            listBox1.DataSource = szurt.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            instructor = listBox1.SelectedItem as uc1;
            var instructorID = instructor.instructorSk;
            var lessons = from x in context.Lessons
                          where x.InstructorFk == instructorID
                          select x.CourseFkNavigation.Name;
            listBox2.DataSource = lessons.ToList();
        }

        private void textBoxLesson_TextChanged(object sender, EventArgs e)
        {
            var szures = textBoxLesson.Text;
            var szurt = from x in context.Lessons
                        where x.CourseFkNavigation.Name.Contains(szures) && x.InstructorFk == instructor.instructorSk
                        select x.CourseFkNavigation.Name;
            listBox2.DataSource = szurt.ToList();
        }
    }
}
