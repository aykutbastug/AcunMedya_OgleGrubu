create function fn_PersonelListesi
(
	@ulke varchar(50)
)
returns table
as
return(
	select * from Personeller where Ulke=@ulke
)

select * from dbo.fn_PersonelListesi('USA')
select PersonelID, Adi, SoyAdi,Ulke from dbo.fn_PersonelListesi('USA')
select PersonelID, Adi, SoyAdi,Ulke from dbo.fn_PersonelListesi('USA') where Adi like '%a%'

--create = olu�turmak i�in
--alter = g�ncellmek i�in
--drop = silmek i�in kullal�r

--drop function fn_PersonelListesi