declare @customerId varchar(50)
set @customerId='ANATR'

if (@customerId is null)
begin
	select * from dbo.Customers
end
else 
begin
	select * from dbo.Customers where CustomerID=@customerId
end


-----------------------------------------------------------
-----------------------------------------------------------

declare @stokMiktari int
select @stokMiktari=UnitsInStock from dbo.Products where ProductID=5

if @stokMiktari >= 20
begin
	select 'Stok miktarý yeterli seviyede. Stok Miktarý=' + CONVERT(varchar(50), @stokMiktari)
end
else if @stokMiktari < 20 and @stokMiktari > 0
begin
	select 'Stok kritik seviyede. Stok Miktarý=' + CONVERT(varchar(50), @stokMiktari)
end
else
begin
	select 'Stokta yok. Stok Miktarý=' + CONVERT(varchar(50), @stokMiktari)
end



select ProductName, 
case 
when Discontinued=0 then 'Ýndirimli Deðil' 
when Discontinued=1 then 'Ýndirimli Ürün'
else ''
end as [Ýndirimli Mi ?]
from dbo.Products


select ProductName, 
case 
when Discontinued=1 then 'Ýndirimli Ürün' 
else 'Ýndirimli Deðil'
end as [Ýndirimli Mi ?]
from dbo.Products



select CompanyName, Country,
case when Country='UK' then 'England'
when Country='USA' then 'America' else Country end as Ulke
from [dbo].[Suppliers]