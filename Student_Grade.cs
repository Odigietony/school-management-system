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
    public partial class Student_Grade : Form
    {
        public Student_Grade()
        {
            InitializeComponent();
            load_table();
        }


        private void Student_Grade_Shown(object sender, EventArgs e)
        {
             
        }

        private void Student_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Enter Matric Number ";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            string s = (sender as TextBox).Text;
            int i;
            int.TryParse(s, out i);  

            if (i > 100)
            {
                MessageBox.Show("Number greater than 100");
                (sender as TextBox).Focus();

            }

            if (i <= 45)
            {
                label6.Text = "F";
            }

            if (i > 45 && i <= 50)
            {
                label6.Text = "E";
            }

            if (i > 50 && i <= 55)
            {
                label6.Text = "D";
            }

            if (i > 55 && i <= 60)
            {
                label6.Text = "C";
            }

            if (i > 60 && i <= 75)
            {
                label6.Text = "B";
            }

            if (i > 75 && i <= 100)
            {
                label6.Text = "A";
            }

            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string s = (sender as TextBox).Text;
            int i;
            int.TryParse(s, out i); 

            if (i > 100)
            {
                MessageBox.Show("Number greater than 100");
                (sender as TextBox).Focus();

            }

            if (i <= 45)
            {
                label7.Text = "F";
            }

            if (i > 45 && i <= 50)
            {
                label7.Text = "E";
            }

            if (i > 50 && i <= 55)
            {
                label7.Text = "D";
            }

            if (i > 55 && i <= 60)
            {
                label7.Text = "C";
            }

            if (i > 60 && i <= 75)
            {
                label7.Text = "B";
            }

            if (i > 75 && i <= 100)
            {
                label7.Text = "A";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string s = (sender as TextBox).Text;
            int i;
            int.TryParse(s, out i); 

            if (i > 100)
            {
                MessageBox.Show("Number greater than 100");
                (sender as TextBox).Focus();

            }

            if (i <= 45)
            {
                label8.Text = "F";
            }

            if (i > 45 && i <= 50)
            {
                label8.Text = "E";
            }

            if (i > 50 && i <= 55)
            {
                label8.Text = "D";
            }

            if (i > 55 && i <= 60)
            {
                label8.Text = "C";
            }

            if (i > 60 && i <= 75)
            {
                label8.Text = "B";
            }

            if (i > 75 && i <= 100)
            {
                label8.Text = "A";
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string s = (sender as TextBox).Text;
            int i;
            int.TryParse(s, out i); 

            if (i > 100)
            {
                MessageBox.Show("Number greater than 100");
                (sender as TextBox).Focus();

            }

            if (i <= 45)
            {
                label9.Text = "F";
            }

            if (i > 45 && i <= 50)
            {
                label9.Text = "E";
            }

            if (i > 50 && i <= 55)
            {
                label9.Text = "D";
            }

            if (i > 55 && i <= 60)
            {
                label9.Text = "C";
            }

            if (i > 60 && i <= 75)
            {
                label9.Text = "B";
            }

            if (i > 75 && i <= 100)
            {
                label9.Text = "A";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string s = (sender as TextBox).Text;
            int i;
            int.TryParse(s, out i); 

            if (i > 100)
            {
                MessageBox.Show("Number greater than 100");
                (sender as TextBox).Focus();

            }

            if (i <= 45)
            {
                label10.Text = "F";
            }

            if (i > 45 && i <= 50)
            {
                label10.Text = "E";
            }

            if (i > 50 && i <= 55)
            {
                label10.Text = "D";
            }

            if (i > 55 && i <= 60)
            {
                label10.Text = "C";
            }

            if (i > 60 && i <= 75)
            {
                label10.Text = "B";
            }

            if (i > 75 && i <= 100)
            {
                label10.Text = "A";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "insert into 100_level.com_grade(student_id, CMP101,CMP101GR,CMP103,CMP103GR,CMP104,CMP104GR,CMP106,CMP106GR,CMP108,CMP108GR) values('" + this.textBox6.Text + "','" + this.textBox1.Text + "', '" + this.label6.Text + "', ' " +this.textBox2.Text+"', '" +this.label7.Text+"', '"+this.textBox3.Text+"', '"+this.label8.Text+"', '"+this.textBox5.Text+"', '"+this.label9.Text+"', '"+this.textBox4.Text+"', '"+this.label10.Text+"');";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Grade Saved!!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "update 100_level.com_grade set student_id = '" + this.textBox6.Text + "', CMP101 = '" + this.textBox1.Text + "',CMP101GR = '" + this.label6.Text + "',CMP103 = ' " + this.textBox2.Text + "',CMP103GR = '" + this.label7.Text + "',CMP104 = '" + this.textBox3.Text + "',CMP104GR =  '" + this.label8.Text + "',CMP106 =  '" + this.textBox5.Text + "',CMP106GR = '" + this.label9.Text + "',CMP108 =  '" + this.textBox4.Text + "',CMP108GR =   '" + this.label10.Text + "' where student_id = '" + this.textBox6.Text + "';";
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


        void load_table()
        {
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
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void searchData(string valueToSearch)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from 100_level.com_grade where concat( student_id, CMP101,CMP101GR,CMP103,CMP103GR,CMP104,CMP104GR,CMP106,CMP106GR,CMP108,CMP108GR) like '%"+valueToSearch+"%' ", conDataBase);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox7.Text.ToString();
            searchData(valueToSearch);
        }

        private void Student_Grade_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Enter a number from 0 to 100!");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Enter Matric Number ")
            {
                textBox6.Text = " ";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Enter Matric Number")
            {
                textBox6.Text = " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

      
         
    }
}
