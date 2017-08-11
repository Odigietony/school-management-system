namespace WindowsFormsApplication1
{
    partial class Student_Registration_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Registration_Form));
            this.levelCombobox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.courseCombobox = new System.Windows.Forms.ComboBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addressOnCampTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxImagePath = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.addPicBox = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.stateTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.idCardTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.surNameTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // levelCombobox
            // 
            this.levelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelCombobox.FormattingEnabled = true;
            this.levelCombobox.Items.AddRange(new object[] {
            "100 Level",
            "200 Level",
            "300 Level",
            "400 Level"});
            this.levelCombobox.Location = new System.Drawing.Point(150, 39);
            this.levelCombobox.Name = "levelCombobox";
            this.levelCombobox.Size = new System.Drawing.Size(240, 24);
            this.levelCombobox.TabIndex = 2;
            this.levelCombobox.SelectedIndexChanged += new System.EventHandler(this.levelCombobox_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = global::WindowsFormsApplication1.Properties.Resources.Tatice_Cristal_Intense_Erreur;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(481, 467);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(450, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::WindowsFormsApplication1.Properties.Resources.Tatice_Cristal_Intense_Ok;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(12, 467);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(450, 28);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.courseCombobox);
            this.groupBox3.Controls.Add(this.deptComboBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(481, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work Information";
            // 
            // courseCombobox
            // 
            this.courseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCombobox.FormattingEnabled = true;
            this.courseCombobox.Location = new System.Drawing.Point(150, 102);
            this.courseCombobox.Name = "courseCombobox";
            this.courseCombobox.Size = new System.Drawing.Size(240, 24);
            this.courseCombobox.TabIndex = 3;
            // 
            // deptComboBox
            // 
            this.deptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Items.AddRange(new object[] {
            "Humanities",
            "Medicine",
            "Science And Tech"});
            this.deptComboBox.Location = new System.Drawing.Point(150, 29);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(246, 24);
            this.deptComboBox.TabIndex = 3;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(36, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Course :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(36, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Department :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.levelCombobox);
            this.groupBox2.Controls.Add(this.passwordTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.addressOnCampTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.userNameTxt);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(481, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 263);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "School Information";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(150, 156);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(240, 25);
            this.passwordTxt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(36, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Level  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(36, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Username :";
            // 
            // addressOnCampTxt
            // 
            this.addressOnCampTxt.Location = new System.Drawing.Point(150, 208);
            this.addressOnCampTxt.Multiline = true;
            this.addressOnCampTxt.Name = "addressOnCampTxt";
            this.addressOnCampTxt.Size = new System.Drawing.Size(240, 25);
            this.addressOnCampTxt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(36, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Password :";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(150, 100);
            this.userNameTxt.Multiline = true;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(240, 25);
            this.userNameTxt.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(36, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Hostel :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtBoxImagePath);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.addPicBox);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.emailTxt);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.stateTxtBox);
            this.groupBox1.Controls.Add(this.nameTxtBox);
            this.groupBox1.Controls.Add(this.ageTxtBox);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.idCardTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.surNameTxt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 439);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtBoxImagePath
            // 
            this.txtBoxImagePath.Location = new System.Drawing.Point(293, 201);
            this.txtBoxImagePath.Multiline = true;
            this.txtBoxImagePath.Name = "txtBoxImagePath";
            this.txtBoxImagePath.Size = new System.Drawing.Size(143, 25);
            this.txtBoxImagePath.TabIndex = 7;
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.Color.Black;
            this.browseBtn.Location = new System.Drawing.Point(293, 232);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(143, 23);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // addPicBox
            // 
            this.addPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addPicBox.Location = new System.Drawing.Point(293, 33);
            this.addPicBox.Name = "addPicBox";
            this.addPicBox.Size = new System.Drawing.Size(143, 153);
            this.addPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPicBox.TabIndex = 5;
            this.addPicBox.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.elegant_grey_illumination_background;
            this.radioButton2.ForeColor = System.Drawing.Color.Silver;
            this.radioButton2.Location = new System.Drawing.Point(215, 372);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.elegant_grey_illumination_background;
            this.radioButton1.ForeColor = System.Drawing.Color.Silver;
            this.radioButton1.Location = new System.Drawing.Point(122, 372);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(122, 284);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(165, 25);
            this.emailTxt.TabIndex = 1;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(122, 201);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(165, 25);
            this.addressTxt.TabIndex = 1;
            // 
            // stateTxtBox
            // 
            this.stateTxtBox.Location = new System.Drawing.Point(122, 409);
            this.stateTxtBox.Multiline = true;
            this.stateTxtBox.Name = "stateTxtBox";
            this.stateTxtBox.Size = new System.Drawing.Size(165, 25);
            this.stateTxtBox.TabIndex = 1;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(122, 33);
            this.nameTxtBox.Multiline = true;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(165, 25);
            this.nameTxtBox.TabIndex = 1;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(122, 325);
            this.ageTxtBox.Multiline = true;
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(165, 25);
            this.ageTxtBox.TabIndex = 1;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(122, 242);
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(165, 25);
            this.phoneTxt.TabIndex = 1;
            // 
            // idCardTxt
            // 
            this.idCardTxt.Location = new System.Drawing.Point(122, 157);
            this.idCardTxt.Multiline = true;
            this.idCardTxt.Name = "idCardTxt";
            this.idCardTxt.Size = new System.Drawing.Size(165, 25);
            this.idCardTxt.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(12, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "State :";
            // 
            // surNameTxt
            // 
            this.surNameTxt.Location = new System.Drawing.Point(122, 74);
            this.surNameTxt.Multiline = true;
            this.surNameTxt.Name = "surNameTxt";
            this.surNameTxt.Size = new System.Drawing.Size(165, 25);
            this.surNameTxt.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(12, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(12, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Age :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registration No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Of Birth :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // Student_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(943, 500);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Registration_Form";
            this.Text = "Student_Registration_Form";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox levelCombobox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox courseCombobox;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox idCardTxt;
        private System.Windows.Forms.TextBox surNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox stateTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addressOnCampTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox addPicBox;
        private System.Windows.Forms.TextBox txtBoxImagePath;
    }
}