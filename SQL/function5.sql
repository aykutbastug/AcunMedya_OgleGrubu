alter function dbo.PersonelListesi(@ulke nvarchar(15))
returns table
as
return	
(
	select EmployeeID, FirstName + ' ' + LastName as FullName, Country from dbo.Employees where Country=@ulke	
)


select * from dbo.PersonelListesi('USA') where FullName like '%le%'