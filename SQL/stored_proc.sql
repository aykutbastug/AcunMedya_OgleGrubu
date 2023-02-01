--CREATE PROCEDURE sp_Ornek1 
CREATE PROC sp_Ornek1 
	@country varchar(50)
AS
BEGIN
	
	select * from dbo.Customers where Country=@country

END


--CREATE PROCEDURE sp_Ornek1 
ALTER PROC sp_Ornek1 
	@country varchar(50)
AS
BEGIN
	
	select * from dbo.Customers where Country=@country order by CompanyName desc
END


--drop proc sp_Ornek11

exec sp_Ornek1 'Canada'

