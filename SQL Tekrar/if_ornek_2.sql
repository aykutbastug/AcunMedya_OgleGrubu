declare @customerId nchar(5)
set @customerId ='AROUT'

if (@customerId is null)
begin
	select * from dbo.Customers
end
else
begin
	select * from dbo.Customers where CustomerID=@customerId
end


