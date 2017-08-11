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
    public partial class studntLoginForm : Form
    {
        public static String passtext;
        public studntLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_Form welForm = new Welcome_Form();
            welForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String conn = "datasource=localhost;port=3306;username=root;password='' ";
            String query = "select matric_num from school_management.student where matric_num='" + matricTextBox.Text + "' and password='" + passTextBox.Text + "'";
            MySqlConnection mscon = new MySqlConnection(conn);
            MySqlDataAdapter da = new MySqlDataAdapter(query, mscon);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                this.Hide();
                Student_Selection_Form ssf = new Student_Selection_Form(dt.Rows[0][0].ToString());
                ssf.Show();

                //((Form)this.MdiParent).Controls["label7"].Text = dt.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("worng Entry");
            }
        }

        private void matricTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
