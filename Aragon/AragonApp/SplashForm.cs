using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AragonApp
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            timerSplashForm.Enabled = true;
            timerSplashForm.Interval = 4000;
        }

        private void timerSplashForm_Tick(object sender, EventArgs e)
        {
            timerSplashForm.Stop();
            new AragonApp().Show();
            this.Hide();
        }
    }
}
