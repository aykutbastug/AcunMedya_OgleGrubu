alter TRIGGER dbo.DeletedRecord
   ON dbo.Customers
   AFTER DELETE
AS 
BEGIN

	 insert into [dbo].[Log_Customers] 
	 select 'deleted', GETDATE(), * from deleted

	 --insert edilen kaydın tüm kolonlarını ve verilerini geriye döner
	 --select * from inserted

	 --silinen kaydın tüm kolonlarını ve verilerini geriye döner
	 --select * from deleted

END


select * from dbo.Customers where CustomerID='bbb  '
select * from [dbo].[Log_Customers]

delete from dbo.Customers where CustomerID='bbb  '