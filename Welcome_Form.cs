using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace WindowsFormsApplication1
{
   
    public partial class Welcome_Form : Form
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;port=3306;Initial Catalog=school_management;User Id=root;password=''");
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            studntLoginForm fm2 = new studntLoginForm();
            fm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer_Login Lec = new Lecturer_Login();
            Lec.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Form adf = new Admin_Form();
            adf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
