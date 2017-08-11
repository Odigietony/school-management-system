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
    public partial class Staff_Registration_Form : Form
    {
         
                
        public Staff_Registration_Form()
        {
            InitializeComponent();
        }

        private void Staff_Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fs = new FileStream(this.txtBoxImagePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageBt = br.ReadBytes((int)fs.Length);
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "insert into school_management.lecturer_table(id_number, firstNAme,lastName,age,dob,phone_number,email,dept,title,course,Address,username,password,image) values('" + this.idCardTxt.Text + "','" + this.nameTxtBox.Text + "', '" + this.surNameTxt.Text + "','" + this.ageTxtBox.Text + "',  '" + this.dateTimePicker1.Text + "', '" + this.phoneTxt.Text + "', '" + this.emailTxt.Text + "', '" + this.deptComboBox.Text + "', '" + this.TitleCombobox.Text + "', ' " + this.courseCombobox.Text + "', '" + this.addressTxt.Text + "', '" + this.userNameTxt.Text + "', '" + this.passwordTxt.Text + "',@IMG);";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Satff Added!!");
                idCardTxt.Text = "";
                nameTxtBox.Text = "";
                surNameTxt.Text = "";
                ageTxtBox.Text = "";
                addressTxt.Text = "";
                dateTimePicker1.Text = "";
                phoneTxt.Text = "";
                emailTxt.Text = "";
                userNameTxt.Text = "";
                passwordTxt.Text = "";
                while (Reader.Read())
                {

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Welcome_Formcs awf = new Admin_Welcome_Formcs();
            awf.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deptComboBox.SelectedItem == "Humanities")
            {
                courseCombobox.Items.Add("Accounting");
                courseCombobox.Items.Add("Business Admin");
                courseCombobox.Items.Add("Economics");
                courseCombobox.Items.Add("Sociology");
            }else if(deptComboBox.SelectedItem=="Medicine")
            {
                courseCombobox.Items.Add("Anatomy");
                courseCombobox.Items.Add("BioChemistry");
                courseCombobox.Items.Add("Physiology");
                courseCombobox.Items.Add("MBBS");
            
            }else if (deptComboBox.SelectedItem == "Science And Tech")
            {
                courseCombobox.Items.Add("Computer Science");
                courseCombobox.Items.Add("Biology");
                courseCombobox.Items.Add("Chemistry");
                courseCombobox.Items.Add("Physics");
                courseCombobox.Items.Add("Industrial Chemistry");
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
             
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png file(*.png)|*.png| jpg files (*.jpg)|*.jpg| All files(*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               String imgLocation = dialog.FileName.ToString();
               this.txtBoxImagePath.Text = imgLocation;
                addPicBox.ImageLocation = imgLocation;
            }
        }

        private void addPicBox_Click(object sender, EventArgs e)
        {

        }
    }
}
