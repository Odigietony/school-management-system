using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin_Welcome_Formcs : Form
    {
        public Admin_Welcome_Formcs()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_Form wf = new Welcome_Form();
            wf.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Registration_Form srf = new Staff_Registration_Form();
            srf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Staff_Form vsf = new View_Staff_Form();
            vsf.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Attendance_Log val = new View_Attendance_Log();
            val.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Registration_Form srf = new Student_Registration_Form();
            srf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Student_Form vsf = new View_Student_Form();
            vsf.Show();
        }
    }
}
