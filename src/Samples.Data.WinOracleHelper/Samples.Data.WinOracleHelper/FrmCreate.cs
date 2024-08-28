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
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void BtnAddClick(object sender, EventArgs e)
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
                                    Employee employee = new Employee();
                                    EmployeeManager manager = new EmployeeManager();
                                    int id = 0;
                                    int.TryParse(txtId.Text, out id);
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
                                    bool resp = manager.Create(employee);
                                    if (resp)
                                        MessageBox.Show("(1) Record affected");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
        }

    }
}
