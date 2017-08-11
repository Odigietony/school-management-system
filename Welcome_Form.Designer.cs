namespace WindowsFormsApplication1
{
    partial class Welcome_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cool_vintage_backgrounds;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(29, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 296);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStaff
            // 
            this.btnStaff.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Smalladmin_user_icon;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnStaff.FlatAppearance.BorderSize = 8;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaff.Font = new System.Drawing.Font("Estrangelo Edessa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Wheat;
            this.btnStaff.Location = new System.Drawing.Point(351, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(173, 135);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff/Lecturer";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Adminman;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdmin.FlatAppearance.BorderSize = 8;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Estrangelo Edessa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Wheat;
            this.btnAdmin.Location = new System.Drawing.Point(17, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(167, 135);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Black;
            this.btnStudent.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.community_student_icon;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnStudent.FlatAppearance.BorderSize = 8;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudent.Font = new System.Drawing.Font("Estrangelo Edessa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.Wheat;
            this.btnStudent.Location = new System.Drawing.Point(197, 144);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(174, 137);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign In As...";
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.thumb_COLOURBOX6483570;
            this.ClientSize = new System.Drawing.Size(589, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;

    }
}

