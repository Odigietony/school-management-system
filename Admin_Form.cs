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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String connection = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "select username from school_management.admin_table where username = '" + userNameTxtBox.Text + "' and password='" + passTextBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlDataAdapter msda = new MySqlDataAdapter(Query, conn);
            DataTable dt = new System.Data.DataTable();
            msda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                this.Hide();
                Admin_Welcome_Formcs awf = new Admin_Welcome_Formcs();
                awf.Show();

            }
            else
            {
                MessageBox.Show("worng Entry");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Welcome_Form wf = new Welcome_Form();
            wf.Show();
        }
    }
}
