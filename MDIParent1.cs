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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Attendance_Form : Form
    {
         

        public Attendance_Form(String username)
        {
            InitializeComponent();
            load_table();
            timer1.Start();
            timer2.Start();
            label7.Text = username;
        }
 

        void load_table()
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from school_management.attendance_table; ", conDataBase);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            DateTime dt = DateTime.Now;
            this.label3.Text = dt.ToString("hh:mm:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label6.Text = time.ToString("dd-MM-yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void biodataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInfo pi = new PersonalInfo();
            String conn = "datasource=localhost;port=3306;username=root;password='' ";
            String query = "select id_number,firstName,lastName,age,dept,title,Address,phone_number,email,image from school_management.lecturer_table where userName='" + label7.Text + "'";
            MySqlConnection mscon = new MySqlConnection(conn);
            DataTable table = new DataTable();
           // MySqlDataAdapter da = new MySqlDataAdapter();
            //da.Fill(table);
            using (MySqlCommand cmd = mscon.CreateCommand())
            {
                mscon.Open();
                cmd.CommandText = query;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pi.label7.Text = reader.GetString(reader.GetOrdinal("firstName"));
                        pi.label8.Text = reader.GetString(reader.GetOrdinal("lastName"));
                        pi.label10.Text = reader.GetString(reader.GetOrdinal("id_number"));
                        pi.label11.Text = reader.GetString(reader.GetOrdinal("title"));
                        pi.label12.Text = reader.GetString(reader.GetOrdinal("Address"));
                        pi.label13.Text = reader.GetString(reader.GetOrdinal("age"));
                        pi.label3.Text = reader.GetString(reader.GetOrdinal("dept"));
                        pi.label14.Text = reader.GetString(reader.GetOrdinal("phone_number"));
                        pi.label2.Text = reader.GetString(reader.GetOrdinal("email"));

                        byte[] imgg = (byte[])(reader["image"]);
                        if (imgg == null)
                            pi.pictureBox1.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(imgg);
                            pi.pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                        }
                      
                    }
                }
            }
           
            pi.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Lecturer_Login Ll = new Lecturer_Login();
            Ll.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 100_level.med_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            vsd.Show();
        }

        private void computerScienceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 100_level.compsc_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void computerScienceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 200_level.compsc_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void computerScienceToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 300_level.compsc_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void computerScienceToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 400_level.compsc_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 200_level.med_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void medicineToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 300_level.med_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void medicineToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ViewStndtData vsd = new ViewStndtData();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select matric_num, firstName, lastName, phone_num, address_on_camp, date_of_birth from 400_level.med_student; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                vsd.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vsd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "insert into school_management.attendance_table(id_number, username, time_in) values('"+ this.textBox1.Text +"','" + this.textBox2.Text +"', '" +this.label3.Text+"');";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Timed in as " + this.textBox2);
                while (Reader.Read()) 
                { 
                    
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            load_table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "update school_management.attendance_table set time_out ='" +this.label3.Text+"', hours_worked =(time_out - time_in) where id_number = '" +this.textBox1.Text+"'; ";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Timed out as " + this.textBox2);
                while (Reader.Read())
                {

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            textBox1.Text = "";
            textBox2.Text = "";
            load_table();


        }

        private void gradeStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void computerScienceToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Student_Grade sg = new Student_Grade();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select student_id, CMP101,CMP101GR,CMP103,CMP103GR,CMP104,CMP104GR,CMP106,CMP106GR,CMP108,CMP108GR from 100_level.com_grade; ", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                sg.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            sg.Show();
        }
    }
}
