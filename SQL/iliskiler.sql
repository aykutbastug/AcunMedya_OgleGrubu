select * from dbo.Kategoriler
select * from dbo.Kitaplar

--insert into dbo.Kitaplar values ('Başlangıç', 'Dan Brown', 2)
--delete from Kategoriler where KategoriId=1

select k.KitapAdi, c.KategoriAdi 
from dbo.Kitaplar as k
inner join dbo.Kategoriler as c on c.KategoriId=k.KategoriId








--Öğrencinin adı, soyadı, sınıfı, dersleri ve ders notlarını saklayabileceğimiz ilişkisel veritabanı örneği yapınız.


