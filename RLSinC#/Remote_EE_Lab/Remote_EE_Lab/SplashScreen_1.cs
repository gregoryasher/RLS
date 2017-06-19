using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_EE_Lab
{
    public partial class SplashScreen_1 : Form
    {
        public SplashScreen_1()
        {
            InitializeComponent();
            
        }

        private void ApplicationTitle_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (timer1.Equals(100))
            {
                timer1.Stop();
            }
        }

        private void Version_Click(object sender, EventArgs e)
        {

        }
    }
}
