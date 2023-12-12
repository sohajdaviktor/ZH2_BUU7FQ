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
    public partial class UserControl2 : UserControl
    {
        StudentContext context = new StudentContext();
        public UserControl2()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructors.ToList();
            statusBindingSource.DataSource = context.Statuses.ToList();
        }
    }
}
