--CompanyName, Country, City, OrderCount(), OrderTotalPrice()

create function fn_ToplamSiparisSayisi
(
	@musteriId nchar(5)
)
returns int
as
begin

declare @siparisSayisi int
select @siparisSayisi = COUNT(*) from Satislar where MusteriID=@musteriId

return @siparisSayisi
end
-------------------------------------------------

alter function fn_SiparisToplamTutari
(
	@musteriId nchar(5)
)
returns numeric(18,2) 
as
begin
declare @toplamTutar numeric(18,2) 
select @toplamTutar = SUM(d.BirimFiyati * d.Miktar) from 
dbo.Satislar as s 
inner join [dbo].[Satis Detaylari] as d on d.SatisID=s.SatisID
where MusteriID=@musteriId

return @toplamTutar
end

-------------------------------------------------

select MusteriID, SirketAdi, Ulke, Sehir, dbo.fn_ToplamSiparisSayisi(MusteriID), dbo.fn_SiparisToplamTutari(MusteriID) as [Sipariþ Sayýsý] from dbo.Musteriler where MusteriID='BERGS'


select SUM(d.BirimFiyati * d.Miktar) from 
dbo.Satislar as s 
inner join [dbo].[Satis Detaylari] as d on d.SatisID=s.SatisID
 where MusteriID='BERGS'