CREATE TRIGGER dbo.StokMiktariniDusur 
   ON [dbo].[Satis Detaylari]
   AFTER INSERT
AS 
BEGIN
	
	declare @urunId int, @miktar smallint
	select @urunId = UrunID, @miktar = Miktar from inserted

	update dbo.Urunler set HedefStokDuzeyi = HedefStokDuzeyi - @miktar where UrunID=@urunId

END
GO
