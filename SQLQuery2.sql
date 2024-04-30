create database ADO_207
use ADO_207
create table Employees(
Id int primary key identity,
Name nvarchar(50) not null,
Surname nvarchar(50) not null,
Salary decimal (18,2)
)
select * from Employees