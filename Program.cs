using System;

namespace EmployeePayRollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee PayRoll");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Sita";
            employee.Phonenumber = "8762265775";
            employee.Address = "67ohkm;";
            employee.Department = "Hr";
            employee.Gender = 'F';
            employee.BasicPay = 2500.00;
            employee.Deductions = 1800.00;
            employee.TaxablePay = 300.00;
            employee.Tax = 2800.00;
            employee.NetPay = 300.00;
            employee.City = "Banglore";
            employee.Country = "India";

            repo.AddEmployee(employee);


        }
    }
}
