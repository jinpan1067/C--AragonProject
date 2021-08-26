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
    public partial class Prescription : Form
    {
        decimal total;
        public Prescription()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtCustID.Text);
            var dbContext = new AragonClassLibrary.AragonPharmarcyEntities();

            var findCustQuery = from cust in dbContext.tblCustomers
                                from house in dbContext.tblHouseholds
                                where cust.CustID == input
                                select new
                                {
                                    cust.CustFirst,
                                    cust.CustLast,
                                    cust.Phone,
                                    house.Address
                                };

            tblCustomerBindingSource.DataSource = findCustQuery.ToList();

            var custPrepQuery = from prep in dbContext.tblRxes
                                join cust in dbContext.tblCustomers on prep.CustID equals cust.CustID
                                join drug in dbContext.tblDrugs on prep.DIN equals drug.DIN
                                where cust.CustID == input
                                select new
                                {
                                    prep.Date,
                                    drug.Cost,
                                    drug.Description,
                                    prep.Quantity
                                };

            lbxPrep.Items.Add("OrderDate        DrugDescription    Cost    Quantity");

            foreach (var element in custPrepQuery) 
            {
                lbxPrep.Items.Add($"{element.Date} {element.Description,15} {element.Cost,15:C} {element.Quantity,10}");
                total += element.Cost * element.Quantity;
            }

           
     
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txtTotal.Text = total.ToString("C");
        }
    }
}