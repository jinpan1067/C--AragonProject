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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            var dbcontext = new AragonClassLibrary.AragonPharmarcyEntities();

            var customerAndPrescription =
                from customer in dbcontext.tblCustomers
                join prescription in dbcontext.tblRxes on customer.CustID equals prescription.CustID
                join drug in dbcontext.tblDrugs on prescription.DIN equals drug.DIN
                where prescription.Date.Contains("2020")
                orderby customer.CustLast, customer.CustFirst
                select new
                {

                    drug.Name,
                    prescription.PrescriptionID,
                    prescription.Quantity,
                    prescription.Unit,
                    prescription.Instructions,
                    prescription.Date

                };
            
         
            lbxReport.Items.Add("Drug Name\t\tQuantity\t\tUnit\t\tDate\t\t\tInstructions\n");


            foreach (var element in customerAndPrescription)
            {
                lbxReport.Items.Add($"{element.Name,-30}\t{element.Quantity}\t\t{element.Unit}\t\t{element.Date}\t\t{element.Instructions}\n");

            }
        }
    }
}
