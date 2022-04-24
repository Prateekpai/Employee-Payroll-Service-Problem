using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement;

namespace EmployeeManagement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetails()
        
        {
            Salary salary = new Salary();
            SalaryUpdateModel salaryupdatemodel = new SalaryUpdateModel()

            {
                SalaryId = 1,
                Month = "Jan",
                EmployeeId = 1,
                EmployeeSalary = 18000

            };
            int EmpSalary = salary.UpdateEmployeeSalary(salaryupdatemodel);

            Assert.AreEqual(salaryupdatemodel.EmployeeSalary, EmpSalary);

        }
    }
}  
