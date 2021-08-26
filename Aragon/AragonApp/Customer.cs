using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AragonApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private AragonClassLibrary.AragonPharmarcyEntities dbContext = null;

        private void loadFullData()
        {
            tblCustomerBindingNavigatorSaveItem.Enabled = true;

            if (dbContext != null) 
            {
                dbContext.Dispose();
            }

            dbContext = new AragonClassLibrary.AragonPharmarcyEntities();

            dbContext.tblCustomers.Load();

            tblCustomerBindingSource.DataSource = dbContext.tblCustomers.Local;
            tblCustomerBindingSource.MoveFirst();

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadFullData();
            cbxSearch.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbxSearch.SelectedIndex)
                {
                    case 0:
                        tblCustomerBindingSource.DataSource =
                            dbContext.tblCustomers.Local.Where(cust => cust.CustFirst.Equals(txtSearchInput.Text));
                        break;
                    case 1:
                        tblCustomerBindingSource.DataSource =
                            dbContext.tblCustomers.Local.Where(cust => cust.CustLast.Equals(txtSearchInput.Text));
                        break;
                    case 2:
                        tblCustomerBindingSource.DataSource =
                            dbContext.tblCustomers.Local.Where(cust => cust.DOB.Equals(txtSearchInput.Text));
                        break;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Validatioin Exception");
            }
            tblCustomerBindingSource.MoveFirst();
        }
    }
}
