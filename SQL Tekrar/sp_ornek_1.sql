-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--Procedure olu�turma �rne�i
CREATE PROCEDURE dbo.sp_Ornek1 
	@ulke varchar(50)
AS
BEGIN
	select * from dbo.Customers where Country=@ulke
END


--olu�turalan procedur� �al��t�rma �rne�i
exec dbo.sp_Ornek1 'Germany'


--Procedure g�ncelleme �rne�i
ALTER PROCEDURE dbo.sp_Ornek1 
	@ulke varchar(50)
AS
BEGIN
	select * from dbo.Customers where Country=@ulke
END