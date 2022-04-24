using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace EmployeeManagement
{
    public class Salary
    {
        private static SqlConnection ConnectionSetup()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeePayRollService;Integrated Security=True");
        }

        public int UpdateEmployeeSalary(SalaryUpdateModel model)
        {
            SqlConnection salaryconnection = ConnectionSetup();
            int salary = 0;
            try
            {
                using (salaryconnection)
                {
                    SalaryDetailModel displaymodel = new SalaryDetailModel();

                    SqlCommand command = new SqlCommand("spUpdateEmployeeSalary", salaryconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", model.SalaryId);
                    command.Parameters.AddWithValue("@month", model.Month);
                    command.Parameters.AddWithValue("@salary", model.EmployeeSalary);
                    command.Parameters.AddWithValue("@empid", model.EmployeeId);

                    salaryconnection.Open();

                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            displaymodel.EmployeeId = dr.GetInt32(0);
                            displaymodel.EmployeeName = dr.GetString(1);
                            displaymodel.EmployeeSalary = dr.GetInt32(2);
                            displaymodel.Month = dr.GetString(3);

                            Console.WriteLine(displaymodel.EmployeeId);
                            Console.WriteLine(displaymodel.EmployeeName);
                            Console.WriteLine(displaymodel.EmployeeSalary);
                            Console.WriteLine(displaymodel.Month);

                            salary = displaymodel.EmployeeSalary;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data Found");
                    }
                }
                return salary;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
