select * from dbo.Dersler
select * from dbo.Siniflar
select * from dbo.SinifDersleri
select * from dbo.Ogrenciler
select * from dbo.OzlukBilgileri

--insert into dbo.Dersler values ('Matematik')
--insert into dbo.Siniflar values ('7. Sınıf', 'A')

--hangi öğrencinin hangi dersi aldığını veren sql cümlesi
select o.*, d.DersAdi 
from dbo.Ogrenciler as o
inner join dbo.SinifDersleri as sd on sd.SinifId=o.SinifId
inner join dbo.Dersler as d on d.DersId=sd.DersId
order by o.AdiSoyadi

--matematik dersini alan önrencilerin listesi
select o.*, d.DersAdi 
from dbo.Ogrenciler as o
inner join dbo.SinifDersleri as sd on sd.SinifId=o.SinifId
inner join dbo.Dersler as d on d.DersId=sd.DersId
where d.DersAdi='Matematik'
order by o.AdiSoyadi


--1.Sınıftaki öğrencilerin özlük bilgileri
select oz.*, s.SinifAdi
from dbo.OzlukBilgileri as oz
inner join dbo.Ogrenciler as o on o.OgrenciId=oz.OgrenciId
inner join dbo.Siniflar as s on s.SinifId=o.SinifId
where o.SinifId=1