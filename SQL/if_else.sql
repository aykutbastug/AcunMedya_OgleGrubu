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
	select 'Stok miktar� yeterli seviyede. Stok Miktar�=' + CONVERT(varchar(50), @stokMiktari)
end
else if @stokMiktari < 20 and @stokMiktari > 0
begin
	select 'Stok kritik seviyede. Stok Miktar�=' + CONVERT(varchar(50), @stokMiktari)
end
else
begin
	select 'Stokta yok. Stok Miktar�=' + CONVERT(varchar(50), @stokMiktari)
end



select ProductName, 
case 
when Discontinued=0 then '�ndirimli De�il' 
when Discontinued=1 then '�ndirimli �r�n'
else ''
end as [�ndirimli Mi ?]
from dbo.Products


select ProductName, 
case 
when Discontinued=1 then '�ndirimli �r�n' 
else '�ndirimli De�il'
end as [�ndirimli Mi ?]
from dbo.Products



select CompanyName, Country,
case when Country='UK' then 'England'
when Country='USA' then 'America' else Country end as Ulke
from [dbo].[Suppliers]