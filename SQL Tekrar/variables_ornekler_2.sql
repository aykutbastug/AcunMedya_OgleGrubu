--deðiþken oluþturma
declare @isim varchar(50)
declare @yas int

--deðiþkene deðer atama iþleme yapmak için 1.yöntem
set @isim = 'aykut'
set @yas = 12
declare @yas2 int = 5

--print @isim
--select @isim, @yas

--deðiþkene deðer atama iþleme yapmak için 2.yöntem
select top 1 @isim = ContactName from dbo.Customers

select @isim

