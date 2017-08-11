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
    public partial class View_Staff_Form : Form
    {
        public View_Staff_Form()
        {
            InitializeComponent();
        }

        void searchData(string valueToSearch)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from school_management.lecturer_table where concat(id_number,firstName,lastName,age,dob,phone_number,email,dept,title,course,Address) like '%" + valueToSearch + "%' ", conDataBase);
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
            MySqlCommand cmdDatabase = new MySqlCommand("select id_number,firstName,lastName,age,dob,phone_number,email,dept,title,course,Address from school_management.lecturer_table; ", conDataBase);
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
            MySqlCommand cmdDatabase = new MySqlCommand("select id_number,firstName,lastName,age,dob,phone_number,email,dept,title,course,Address from school_management.lecturer_table; ", conDataBase);
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
            MySqlCommand cmdDatabase = new MySqlCommand("delete from school_management.lecturer_table where id_number='"+this.searchTxtBox.Text+"'", conDataBase);
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
            String Query = "update school_management.lecturer_table set  email='"+this.emailTxtbox.Text+"', phone_number='"+this.phoneTxtBox.Text+"', Address='"+addressTxtBox.Text+"', where id_number='" + this.idCardTxtBox.Text + "';";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Grade Updated!!");
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
