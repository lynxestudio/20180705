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
    public partial class FrmUpdate : Form
    {
        Employee employee;
        EmployeeManager manager;

        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void BtnUpdateClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                MessageBox.Show("Id empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (string.IsNullOrEmpty(LastName.Text))
                    MessageBox.Show("Last Name Empty", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if (string.IsNullOrEmpty(Email.Text))
                        MessageBox.Show("Email", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (string.IsNullOrEmpty(HireDate.Text))
                            MessageBox.Show("Hire Date", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            if (string.IsNullOrEmpty(JobId.Text))
                                MessageBox.Show("Job Id", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            { 
                                try
                                {
                                    int id = 0;
                                    Int32.TryParse(txtId.Text, out id);
                                    manager = new EmployeeManager();
                                    employee = new Employee();
                                    employee.EmployeeId = id;
                                    employee.FirstName = FirstName.Text;
                                    employee.LastName = LastName.Text;
                                    employee.Email = Email.Text;
                                    employee.PhoneNumber = PhoneNumber.Text;
                                    employee.HireDate = HireDate.Text;
                                    employee.JobId = JobId.Text;
                                    employee.Salary = Salary.Text;
                                    employee.Commission = CommissionPct.Text;
                                    employee.ManagerId = ManagerId.Text;
                                    employee.DepartmentId = DepartmentId.Text;
                                    bool b = manager.Update(employee);
                                    if (b)
                                        MessageBox.Show("(1) record updated");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
        }

        private void BtnQueryClick(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                Int32.TryParse(txtId.Text, out id);
                manager = new EmployeeManager();
                employee = manager.Retrieve(id);
                FirstName.Text = employee.FirstName;
                LastName.Text = employee.LastName;
                Email.Text = employee.Email;
                PhoneNumber.Text = employee.PhoneNumber;
                DateTime dt = DateTime.Now;
                DateTime.TryParse(employee.HireDate,out dt);
                HireDate.Text = dt.ToString("dd-MMM-yy");
                JobId.Text = employee.JobId;
                Salary.Text = employee.Salary;
                CommissionPct.Text = employee.Commission;
                ManagerId.Text = employee.ManagerId;
                DepartmentId.Text = employee.DepartmentId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
