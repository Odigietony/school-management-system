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
    public partial class Attendance_Form : Form
    {
       
        public Attendance_Form()
        {
            InitializeComponent();
            load_table();
            timer1.Start();
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void load_table() { 
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.label3.Text = dt.ToString("hh:mm:ss");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.SetBounds(3,15,3,15);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label6.Text = time.ToString("dd-mm-yyyy");
        }
    }
}
