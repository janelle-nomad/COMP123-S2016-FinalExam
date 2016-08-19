using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load()
        {
            timer1.Enabled = true;
        }
        private void timer_tick(object sender, EventArgs e)
        {
            //3 methods left to intialize form

            if (progressBar1.Value == progressBar1.Maximum)
            {

                GenerateNameForm generateNameForm = new GenerateNameForm();
                generateNameForm.SplashForm = this;
                this.Hide();
                generateNameForm.Show();
                timer1.Enabled = false;
            }
        }
    }
}
