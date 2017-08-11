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
    public partial class ViewStndtData : Form
    {
    
        public ViewStndtData()
        {
            InitializeComponent();
             
        }

      


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox7.Text.ToString();
            searchData(valueToSearch);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            
        }

        void searchData(string valueToSearch)
        {
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from 100_level.com_grade where concat( student_id, CMP101,CMP101GR,CMP103,CMP103GR,CMP104,CMP104GR,CMP106,CMP106GR,CMP108,CMP108GR) like '%" + valueToSearch + "%' ", conDataBase);
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

        private void ViewStndtData_Load(object sender, EventArgs e)
        {
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
            }
        }


    }
}
