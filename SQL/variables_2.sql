declare @kategoriAdi varchar(50)
declare @sayi int

set @kategoriAdi = 'Condiments'
select @sayi=5

select top 1 @sayi=OrderID from dbo.Orders

--print @kategoriAdi
--print @sayi

--select @kategoriAdi as [Kategori Ad�], @sayi as [Sipari� No]

select * from dbo.Categories where CategoryName=@kategoriAdi



