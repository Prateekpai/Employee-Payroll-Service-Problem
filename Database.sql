create database EmployeePayRollService

create table Employee_Payroll
(
EmployeeID int Identity,
EmployeeName varchar(255),
PhoneNumber varchar(255),
Address varchar(255),
Department varchar(255),
Gender char,
BasicPay float,
Deductions float,
TaxablePay float,
Tax float,
NetPay float,
StartDate DateTime,
City varchar(255),
Country varchar(255)
)

select * from Employee_Payroll 

create table Salary
(
EmployeeId int,
EmployeeName varchar(255),
JobDescription varchar(255),
EmployeeSalary int,
Month varchar(255),
SalaryId int,
)

select * from Salary 

INSERT into Salary Values ( 'Prateek', 'TA', 18000, 'Jan', 1);