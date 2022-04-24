create procedure SpAddEmployeeDetails
(
@EmployeeName varchar(255),
@Phonenumber varchar(255),
@Address varchar(255),
@Department varchar(255),
@Gender char,
@BasicPay float,
@Deductions float,
@TaxablePay float,
@Tax float,
@NetPay float,
@StartDate DateTime,
@City varchar(255),
@Country varchar(255)
)

as
begin
insert into Employee_Payroll values (@EmployeeName,@Phonenumber,@Address,@Department,@Gender,@BasicPay,@Deductions,@TaxablePay,@Tax,@NetPay,@StartDate,@City,@Country)
end