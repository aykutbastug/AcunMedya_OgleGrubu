--de�i�ken olu�turma
declare @isim varchar(50)
declare @yas int

--de�i�kene de�er atama i�leme yapmak i�in 1.y�ntem
set @isim = 'aykut'
set @yas = 12
declare @yas2 int = 5

--print @isim
--select @isim, @yas

--de�i�kene de�er atama i�leme yapmak i�in 2.y�ntem
select top 1 @isim = ContactName from dbo.Customers

select @isim

