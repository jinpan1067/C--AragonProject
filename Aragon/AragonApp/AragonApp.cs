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
    public partial class AragonApp : Form
    {
        public AragonApp()
        {
            InitializeComponent();
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            var childCustomer = new Customer();
            childCustomer.MdiParent = this;
            childCustomer.Show();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsVerticle_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            
        }

        private void tsUpdatePrep_Click(object sender, EventArgs e)
        {
            Prescription childPrep = new Prescription();
            childPrep.MdiParent = this;
            childPrep.Show();
        }

        private void tsTrainning_Click(object sender, EventArgs e)
        {
            Trainning childTrainning = new Trainning();
            childTrainning.MdiParent = this;
            childTrainning.Show();
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            Report childReport = new Report();
            childReport.MdiParent = this;
            childReport.Show();
        }
    }
}
