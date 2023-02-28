-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--Procedure oluþturma örneði
CREATE PROCEDURE dbo.sp_Ornek1 
	@ulke varchar(50)
AS
BEGIN
	select * from dbo.Customers where Country=@ulke
END


--oluþturalan procedurü çalýþtýrma örneði
exec dbo.sp_Ornek1 'Germany'


--Procedure güncelleme örneði
ALTER PROCEDURE dbo.sp_Ornek1 
	@ulke varchar(50)
AS
BEGIN
	select * from dbo.Customers where Country=@ulke
END