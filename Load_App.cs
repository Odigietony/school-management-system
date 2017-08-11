using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Load_App : Form
    {
        public Load_App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 200;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            timer1.Start();
            this.progressBar1.Visible = true;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            progressBar1.PerformStep(); // or progressBar1.Value++;
            if (progressBar1.Value == 200)  // check with the value
            {
                new Welcome_Form().Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
