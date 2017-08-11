namespace WindowsFormsApplication1
{
    partial class View_Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Student_Form));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idCardTxtBox = new System.Windows.Forms.TextBox();
            this.hostelTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.updateBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.idCardTxtBox);
            this.groupBox2.Controls.Add(this.hostelTxtBox);
            this.groupBox2.Controls.Add(this.phoneTxtBox);
            this.groupBox2.Controls.Add(this.emailTxtbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(392, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 192);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Records";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.available_updates;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(31, 156);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(419, 25);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update Record";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hostel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matriculation Number :";
            // 
            // idCardTxtBox
            // 
            this.idCardTxtBox.Location = new System.Drawing.Point(165, 19);
            this.idCardTxtBox.Multiline = true;
            this.idCardTxtBox.Name = "idCardTxtBox";
            this.idCardTxtBox.Size = new System.Drawing.Size(285, 26);
            this.idCardTxtBox.TabIndex = 0;
            // 
            // hostelTxtBox
            // 
            this.hostelTxtBox.Location = new System.Drawing.Point(165, 124);
            this.hostelTxtBox.Multiline = true;
            this.hostelTxtBox.Name = "hostelTxtBox";
            this.hostelTxtBox.Size = new System.Drawing.Size(285, 26);
            this.hostelTxtBox.TabIndex = 0;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(165, 92);
            this.phoneTxtBox.Multiline = true;
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(285, 26);
            this.phoneTxtBox.TabIndex = 0;
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Location = new System.Drawing.Point(165, 55);
            this.emailTxtbox.Multiline = true;
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(285, 26);
            this.emailTxtbox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 311);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.ViewBtn);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchTxtBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(21, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Information";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Image = global::WindowsFormsApplication1.Properties.Resources.elegant_grey_illumination_background_presentations_powerpointbackgrounds;
            this.linkLabel1.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.Location = new System.Drawing.Point(17, 168);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Admin Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.xs;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(20, 137);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(310, 25);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete Student";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search;
            this.ViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewBtn.Location = new System.Drawing.Point(20, 92);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(310, 25);
            this.ViewBtn.TabIndex = 2;
            this.ViewBtn.Text = "View Student";
            this.ViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchBtn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Apps_Search_icon;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(276, 28);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(54, 26);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(20, 29);
            this.searchTxtBox.Multiline = true;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(269, 26);
            this.searchTxtBox.TabIndex = 0;
            // 
            // View_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.elegant_grey_illumination_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(879, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Student_Form";
            this.Text = "View_Student_Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCardTxtBox;
        private System.Windows.Forms.TextBox hostelTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
    }
}