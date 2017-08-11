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


namespace WindowsFormsApplication1
{
    public partial class Lecturer_Login : Form
    {
        public static String passtext;
        public Lecturer_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_Form welForm = new Welcome_Form();
            welForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conn =  "datasource=localhost;port=3306;username=root;password='' ";
            String query = "select userName from school_management.lecturer_table where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            MySqlConnection mscon = new MySqlConnection(conn);
            MySqlDataAdapter da = new MySqlDataAdapter(query, mscon);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                this.Hide();
                Attendance_Form af = new Attendance_Form(dt.Rows[0][0].ToString());
                af.Show();
               
                //((Form)this.MdiParent).Controls["label7"].Text = dt.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("worng Entry");
            }
        }
    }
}
