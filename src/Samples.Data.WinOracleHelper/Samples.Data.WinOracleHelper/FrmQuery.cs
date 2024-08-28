using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Samples.Data.WinOracleHelper.Helper;

namespace Samples.Data.WinOracleHelper
{
    public partial class FrmQuery : Form
    {
        public FrmQuery()
        {
            InitializeComponent();
        }

        private void BtnQueryClick(object sender, EventArgs e)
        {
            txtOutput.Clear();
            if (string.IsNullOrEmpty(txtId.Text))
                MessageBox.Show("Id required", "Error", MessageBoxButtons.OK);
            else
            {
                try
                {
                    int id = 0;
                    Int32.TryParse(txtId.Text, out id);
                    EmployeeManager manager = new EmployeeManager();
                    Employee employee = manager.Retrieve(id);
                    if (employee != null)
                    {
                        txtOutput.Text = "Id              [ " + employee.EmployeeId + " ]" + Environment.NewLine;
                        txtOutput.Text += "First name     [ " + employee.FirstName + " ]" + Environment.NewLine;
                        txtOutput.Text += "Last name      [ " + employee.LastName + " ]" + Environment.NewLine;
                        txtOutput.Text += "Email          [ " + employee.Email + " ]" + Environment.NewLine;
                        txtOutput.Text += "Phone number   [ " + employee.PhoneNumber + " ]" + Environment.NewLine;
                        txtOutput.Text += "Hire date      [ " + employee.HireDate + " ]" + Environment.NewLine;
                        txtOutput.Text += "Job Id         [ " + employee.JobId + " ]" + Environment.NewLine;
                        txtOutput.Text += "Salary         [ " + employee.Salary + " ]" + Environment.NewLine;
                        txtOutput.Text += "Commission PCT [ " + employee.Commission + " ]" + Environment.NewLine;
                        txtOutput.Text += "Manager Id     [ " + employee.ManagerId + " ]" + Environment.NewLine;
                        txtOutput.Text += "Department Id  [ " + employee.DepartmentId + " ]" + Environment.NewLine;
                        txtOutput.Text += "Manager Id [ " + employee.Salary + " ]" + Environment.NewLine;
                    }
                    else
                        MessageBox.Show("Employee not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }
    }
}
