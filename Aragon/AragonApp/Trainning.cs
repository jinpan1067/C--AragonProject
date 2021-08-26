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
    public partial class Trainning : Form
    {
        bool choice = true;
        int input;

        public Trainning()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (choice)
            {
                input = int.Parse(txtInput.Text);
                var dbContext = new AragonClassLibrary.AragonPharmarcyEntities();

                var empQuery = from emp in dbContext.tblEmployees
                               join job in dbContext.tblJobtitles on emp.JobID equals job.JobID
                               join trainning in dbContext.tblEmployeeTrainings on emp.EmpID equals trainning.EmpID
                               //join trainning in dbContext.tblEmployeeTrainings on emp.EmpID equals trainning.EmpID
                               //join course in dbContext.tblClasses on trainning.ClassID equals course.ClassID

                               where emp.EmpID == input
                               select new
                               {
                                   emp.EmpFirst,
                                   emp.EmpID,
                                   emp.EmpLast,
                                   job.Title
                               };

                tblEmployeeBindingSource.DataSource = empQuery.ToList();
                tblEmployeeBindingSource.MoveFirst();


                var classQuery = from emp in dbContext.tblEmployees
                                 join trainning in dbContext.tblEmployeeTrainings on emp.EmpID equals trainning.EmpID
                                 join course in dbContext.tblClasses on trainning.ClassID equals course.ClassID
                                 where emp.EmpID == input
                                 select new
                                 {
                                     course.ClassID,
                                     course.Description,
                                     course.Cost,
                                     trainning.Date
                                 };


                lbxClass.Items.Add("ClassID\t\tClassDescription\t\tGraduateDate\t ClassCost");
                foreach (var element in classQuery)
                {
                    lbxClass.Items.Add($"{element.ClassID,5}\t\t{element.Description}\t{element.Date,-10}\t{element.Cost:C}\n");
                }
            }
            else {


                input = int.Parse(txtInput.Text);
                var dbContext = new AragonClassLibrary.AragonPharmarcyEntities();

                var courseQuery = from course in dbContext.tblClasses
                                  join trainning in dbContext.tblEmployeeTrainings on course.ClassID equals trainning.ClassID
                                  join emp in dbContext.tblEmployees on trainning.EmpID equals emp.EmpID
                                  where course.ClassID == (short)input
                                  select new
                                  {
                                      course.ClassID,
                                      course.Description,
                                      course.Provider,
                                      course.Required
                                  };
                tblEmployeeTrainingBindingSource.DataSource = courseQuery.ToList();
                tblEmployeeTrainingBindingSource.MoveFirst();

                var employeeQuery = from course in dbContext.tblClasses
                                  join trainning in dbContext.tblEmployeeTrainings on course.ClassID equals trainning.ClassID
                                  join emp in dbContext.tblEmployees on trainning.EmpID equals emp.EmpID
                                  
                                  where course.ClassID == (short)input
                                  select new
                                  {
                                      emp.EmpID,
                                      emp.EmpFirst,
                                      emp.EmpLast,
                                      trainning.Date
                                  };
                lbxEmp.Items.Add("EmployeeID\tFirstName           Lastname             GraduateDate");
                foreach (var element in employeeQuery)
                {
                    lbxEmp.Items.Add($"{element.EmpID}\t\t {element.EmpFirst} \t\t{element.EmpLast}\t \t{element.Date}\n");
                }
            }

        }

        private void rbtnEmp_Click(object sender, EventArgs e)
        {
            txtPrompt.Text = "Enter Employee's ID :";
        }

        private void rbtnClass_Click(object sender, EventArgs e)
        {
            txtPrompt.Text = "Enter Class's ID :";
            choice = false;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lbxClass.Items.Clear();
            lbxEmp.Items.Clear();
        }

        private void rbtnClass_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void rbtnEmp_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Text = "";
           
        }

    
       
    }
}

