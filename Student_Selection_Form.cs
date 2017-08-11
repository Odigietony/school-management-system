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
    public partial class Student_Selection_Form : Form
    {
        public Student_Selection_Form(String firstName)
        {
            InitializeComponent();
            nameLabel.Text = firstName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Personal_Information spi = new Student_Personal_Information();
            String conn = "datasource=localhost;port=3306;username=root;password='' ";
            String query = "select firstName,lastName,age,sex,matric_num,level,email,phone_num,dept,course,image from school_management.student where matric_num='" + nameLabel.Text + "'";
            MySqlConnection mscon = new MySqlConnection(conn);
            using (MySqlCommand cmd = mscon.CreateCommand())
            {
                mscon.Open();
                cmd.CommandText = query;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        spi.label7.Text = reader.GetString(reader.GetOrdinal("firstName"));
                        spi.label8.Text = reader.GetString(reader.GetOrdinal("lastName"));
                        spi.label10.Text = reader.GetString(reader.GetOrdinal("matric_num"));
                        spi.label11.Text = reader.GetString(reader.GetOrdinal("level"));
                        spi.label12.Text = reader.GetString(reader.GetOrdinal("sex"));
                        spi.label13.Text = reader.GetString(reader.GetOrdinal("age"));
                        spi.label2.Text = reader.GetString(reader.GetOrdinal("email"));
                        spi.label3.Text = reader.GetString(reader.GetOrdinal("dept"));
                        spi.label14.Text = reader.GetString(reader.GetOrdinal("phone_num"));
                        spi.label5.Text = reader.GetString(reader.GetOrdinal("course"));

                        byte[] imgg = (byte[])(reader["image"]);
                        if (imgg == null)
                            spi.pictureBox1.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(imgg);
                            spi.pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
            }

            spi.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Result_Form rf = new Result_Form();
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String query = "select student_id, CMP101,CMP101GR,CMP103,CMP103GR,CMP104,CMP104GR,CMP106,CMP106GR,CMP108,CMP108GR,image from 100_level.com_grade where student_id= '" + nameLabel.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(ConString);
           // MySqlCommand cmdDatabase = new MySqlCommand();
            using (MySqlCommand cmd = conDataBase.CreateCommand())
                {
                    conDataBase.Open();
                    cmd.CommandText = query;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rf.label7.Text = reader.GetString(reader.GetOrdinal("CMP101GR"));
                            rf.label10.Text = reader.GetString(reader.GetOrdinal("CMP103GR"));
                            rf.label11.Text = reader.GetString(reader.GetOrdinal("CMP104GR"));
                            rf.label12.Text = reader.GetString(reader.GetOrdinal("CMP106GR"));
                            rf.label13.Text = reader.GetString(reader.GetOrdinal("CMP108GR"));

                            byte[] imgg = (byte[])(reader["image"]);
                            if (imgg == null)
                                rf.Box.Image = null;
                            else
                            {
                                MemoryStream MemoStream = new MemoryStream(imgg);
                                rf.Box.Image = System.Drawing.Image.FromStream(MemoStream);
                            }
                            
                        }
                    }
                }
                rf.Show();
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Welcome_Form welForm = new Welcome_Form();
            welForm.Show();
        }
    }
}
