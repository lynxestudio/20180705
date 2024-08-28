// -----------------------------------------------------------------------
// <copyright file="CommandsText.cs" company="apifiedsignature">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Samples.Data.WinOracleHelper.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class CommandsText
    {
        public const string Insert = "INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,commission_pct,manager_id,department_id)" +
                "VALUES(:prmEmployeeId,:prmFirstName,:prmLastName,:prmEmail,:prmPhoneNumber,:prmHireDate,:prmJobId,:prmSalary,:prmCommission,:prmManagerId,:prmDepartmentId)";

        public const string Update = @"UPDATE employees SET
                                    first_name = :prmFirstName
                                    ,last_name = :prmLastName
                                    ,email = :prmEmail
                                    ,phone_number = :prmPhoneNumber
                                    ,hire_date = :prmHireDate
                                    ,job_id = :prmJobId
                                    ,salary = :prmSalary
                                    ,commission_pct = :prmCommission
                                    WHERE employee_id = :prmEmployeeId";
        public const string SelectAll = "SELECT * FROM employees where employee_id = :id";
    }
}
