create procedure spUpdateEmployeeSalary
@id int,
@month varchar(255),
@salary int,
@empid int
as
begin

update Salary
set EmployeeSalary=@salary
where SalaryId=@id and Month=@month and EmployeeId=@empid;

select e.EmployeeID,e.EmployeeName,s.EmployeeSalary,s.Month
from employee_payroll e inner join  Salary s
on e.EmployeeID=s.EmployeeId where s.SalaryId=@id

end