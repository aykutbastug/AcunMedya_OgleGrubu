-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER TRIGGER dbo.UlkeYoksaGuncelle
   ON dbo.Personeller
   AFTER INSERT
AS 
BEGIN
	
	declare @ulke varchar(15), @personelId int
	select @ulke = Ulke, @personelId = PersonelId from inserted

	if (@ulke is null)
	begin
		update dbo.Personeller set Ulke='T�rkiye' where PersonelID=@personelId
	end
	--select * from inserted
	--select * from deleted
END


--insert into dbo.Personeller (SoyAdi, Adi) values ('BA�TU�','Aykut')
--delete from dbo.Personeller where PersonelID=9999999
