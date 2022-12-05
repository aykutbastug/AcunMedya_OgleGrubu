select * from [dbo].[Customers] --tablodaki tüm verileri getirir

select CustomerID, CompanyName from dbo.Customers --custoemrs tablosundaki iki kolona ait tüm verileri getirir

select CustomerID, CompanyName from Northwind.dbo.Customers --custoemrs tablosundaki iki kolona ait tüm verileri getirir

select CustomerID as [Müşteri No], CompanyName as [Müşteri Adı] from dbo.Customers --custoemrs tablosundaki iki kolona ait tüm verileri getirir

select top 17 * from [dbo].[Customers] --customers tabosundaki ilk 17 kaydı getirir

select top 17 CustomerID as [Müşteri No], CompanyName as [Müşteri Adı] from [dbo].[Customers] --kolon isimlerinde alias kullanarak kolonlara farklı isimler vererek sonuç alabiliriz

select c.CustomerID, c.ContactName from dbo.Customers as c -- alias tanımlayarak topla isimlerini manüpüle edebiliriz

select * from  dbo.Customers where CustomerID='AAAA ' --customerId değeri AAAA olan kayıtları listeleri
select * from  dbo.Customers where CustomerID<>'AAAA ' --customerId değeri AAAA olmayan kayıtları listeleri

select * from dbo.Customers where CustomerID='AAAA ' and CustomerID='ANTON' --veya komutu ile customerId değeri AAAA  ve ANTON olan kayıtları listeler
select * from dbo.Customers where CustomerID='AAAA ' or CustomerID='ANTON' --veya komutu ile customerId değeri AAAA  veya ANTON olan kayıtları listeler

select CategoryName as [Kategori Adı], [Description] as [Açıklama] from dbo.Categories where CategoryID=4

select * from dbo.Employees where ReportsTo=2
select * from dbo.Employees where ReportsTo>2
select * from dbo.Employees where ReportsTo>=2
select * from dbo.Employees where ReportsTo<=2
select * from dbo.Employees where ReportsTo<2

select * from dbo.Employees where BirthDate is null
select * from dbo.Employees where BirthDate is not null

select * from Employees where Title like 'Vice%'
select * from Employees where Title like '%Sales%'
select * from Employees where Title like '%Sales'

select * from dbo.Employees where ReportsTo=2 or ReportsTo=5
select * from Employees where ReportsTo in (2,5)
select * from Employees where ReportsTo not in (2,5)


select * from OrderDetails where Quantity between 5 and 10

select *, Quantity * UnitPrice as [TotalPrice] from OrderDetails
select *, (Quantity * UnitPrice) / Quantity as [TotalPrice] from OrderDetails

select EmployeeID, FirstName + ' ' + LastName as [Adı Soyadı] from Employees


select * from Customers order by CompanyName asc
select * from Customers order by CompanyName desc

select * from Products order by CategoryID, ProductName desc


select * from Products 
where CategoryID in (2,5) 
order by CategoryID, ProductName desc

select COUNT(*) from OrderDetails --satır sayısını verir
select SUM(Quantity) from OrderDetails --tüm satırların miktar alanındaki değerlerin toplamını verir

select SUM(Quantity * UnitPrice) from OrderDetails where Discount>0-- discount sıfırdan büyük olan kayıtların toplam tutarını verir

select AVG(Quantity) from OrderDetails --quantity ortalamasını verir
select SUM(Quantity) / COUNT(*) from OrderDetails --quantity ortalamasını verir

select MIN(UnitPrice) from OrderDetails --en küçük UnitePrice değerinin verir 
select MAX(UnitPrice) from OrderDetails --en büyük UnitePrice değerinin verir


select * from Categories


insert into dbo.Categories (CategoryName, [Description])
values ('Bilgisayar', 'Açıklama')

insert into dbo.Categories values ('Telefon', 'teelfon kategorisi açıklaması',NULL)

update dbo.Categories set [Description]='Telefon kategorisinin', Picture=NULL
where CategoryID=52

update dbo.Categories set [Description]='Telefon kategorisinin', Picture=NULL
where CategoryName like 'Tel%'

--delete from dbo.Categories where CategoryID=52

--truncate table dbo.Categories


--select * from MyUsers
--insert into MyUsers values ('yyyy')
--delete from MyUsers
--truncate table MyUsers

--OrderDetails tabosunda ProductId si 24 olan kayıtların toplam indirim miktarını verir
select * from OrderDetails


--OrderDetails Sadece indirim uygulanan siparişlarin, indirim miktarı düşülerek genel toplam tutarını veren select cümlesi 