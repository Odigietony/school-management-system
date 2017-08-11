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
    public partial class Student_Registration_Form : Form
    {
        public Student_Registration_Form()
        {
            InitializeComponent();
        }

        String Gender;
        private void addBtn_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fs = new FileStream(this.txtBoxImagePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageBt = br.ReadBytes((int)fs.Length);
            String ConString = "datasource=localhost;port=3306;username=root;password='' ";
            String Query = "insert into school_management.student(matric_num, firstName,lastName,age,sex,level,state,address_on_camp,dob,phone_num,email,dept,course,Address,username,password,image) values('" + this.idCardTxt.Text + "','" + this.nameTxtBox.Text + "', '" + this.surNameTxt.Text + "','" + this.ageTxtBox.Text + "', '" + Gender + "',  '" + this.levelCombobox.Text + "',  '" + this.stateTxtBox.Text + "',  '" + this.addressOnCampTxt.Text + "',  '" + this.dateTimePicker1.Text + "', '" + this.phoneTxt.Text + "', '" + this.emailTxt.Text + "', '" + this.deptComboBox.Text + "',' " + this.courseCombobox.Text + "', '" + this.addressTxt.Text + "', '" + this.userNameTxt.Text + "', '" + this.passwordTxt.Text + "',@IMG);";
            MySqlConnection mscon = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, mscon);
            
            MySqlDataReader Reader;
            try
            {
                mscon.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Student Added!!");
                idCardTxt.Text = "";
                nameTxtBox.Text = "";
                surNameTxt.Text = "";
                ageTxtBox.Text = "";
                Gender = "";
            
                stateTxtBox.Text = "";
                addressTxt.Text= "";
                addressOnCampTxt.Text = "";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Welcome_Formcs af = new Admin_Welcome_Formcs();
            af.Show();
        }

        private void levelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deptComboBox.SelectedItem == "Humanities")
            {
                courseCombobox.Items.Add("Accounting");
                courseCombobox.Items.Add("Business Admin");
                courseCombobox.Items.Add("Economics");
                courseCombobox.Items.Add("Sociology");
            }


            if (deptComboBox.SelectedItem == "Medicine")
            {
                courseCombobox.Items.Add("Anatomy");
                courseCombobox.Items.Add("BioChemistry");
                courseCombobox.Items.Add("Physiology");
                courseCombobox.Items.Add("MBBS");

            }


            if (deptComboBox.SelectedItem == "Science And Tech")
            {
                courseCombobox.Items.Add("Computer Science");
                courseCombobox.Items.Add("Biology");
                courseCombobox.Items.Add("Chemistry");
                courseCombobox.Items.Add("Physics");
                courseCombobox.Items.Add("Industrial Chemistry");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png file(*.png)|*.png| jpg files (*.jpg)|*.jpg| All files(*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String imgLocation = dialog.FileName.ToString();
                txtBoxImagePath.Text = imgLocation;
                addPicBox.ImageLocation = imgLocation;
            }
        }
    }
}
