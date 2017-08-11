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
    public partial class View_Student_Form : Form
    {
        public View_Student_Form()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void searchData(string valueToSearch)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from school_management.student  where concat(matric_num,firstName,lastName,age,dob,phone_num,email,dept,state,course,address_on_camp,address,level) like '%" + valueToSearch + "%' ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void load_table()
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num,firstName,lastName,age,dob,phone_num,email,dept,state,course,address,level,address_on_camp from school_management.student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTxtBox.Text.ToString();
            searchData(valueToSearch);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num,firstName,lastName,age,dob,phone_num,email,dept,state,course,address,level,address_on_camp from school_management.student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                dataGridView1.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("delete from school_management.student where matric_num='" + this.searchTxtBox.Text + "'", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "update school_management.student set  email='" + this.emailTxtbox.Text + "', phone_num='" + this.phoneTxtBox.Text + "', address_on_camp='" + this.hostelTxtBox.Text + "', where matric_num='" + this.idCardTxtBox.Text + "';";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Student Record Updated!!");
                while (Reader.Read())
                {

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            load_table();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_Welcome_Formcs awf = new Admin_Welcome_Formcs();
            awf.Show();
        }
    }
}
