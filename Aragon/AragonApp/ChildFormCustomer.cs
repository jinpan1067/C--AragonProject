using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AragonApp
{
    public partial class ChildFormCustomer : Form
    {
        public ChildFormCustomer(string title)
        {
            InitializeComponent();
            Text = title;
        }

        private AragonClassLibrary.AragonPharmarcyEntities dbContext = null;

        private void loadOriginalData() {
            if (dbContext != null) 
            {
                dbContext.Dispose();
            }

            dbContext = new AragonClassLibrary.AragonPharmarcyEntities();
            dbContext.tblCustomers.Load();

            tblCustomerBindingSource.DataSource = dbContext.tblCustomers.Local;
            tblCustomerBindingSource.MoveFirst();
        }

        private void ChildFormCustomer_Load(object sender, EventArgs e)
        {
            loadOriginalData();
            
        }

        private void bindingNavigatorSavebtn_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }
    }
}
