select *, UnvanEki + ' ' + Adi + ' ' + Soyadi from dbo.Personeller

create function fn_PesonelTamIsim
(
	@unvanEki varchar(50),
	@adi varchar(50),
	@soyadi varchar(50)
)
returns varchar(152)
as
begin
	declare @sonuc varchar(152)
	set @sonuc = @unvanEki + ' ' + @adi + ' ' + @soyadi	
	return @sonuc
end

select dbo.fn_PesonelTamIsim('aa','isim','soyisim')
select *, dbo.fn_PesonelTamIsim(UnvanEki, Adi, SoyAdi) as [Tam Ad] from dbo.Personeller
