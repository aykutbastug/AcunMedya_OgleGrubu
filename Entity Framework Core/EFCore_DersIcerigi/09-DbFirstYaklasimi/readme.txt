Scaffold-DbContext "server=AYKUTBASTUG-ZEN;database=Northwind;Trusted_Connection=true;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models


Scaffold-DbContext Parametreleri

"Connection_String"				= databse için ilgili sql server connection stringi buraya yazılır
-outputdir Models				= classların oluşmasını istediğiniz bir klasör varsa buraya yazılabilir
-Context NorthwindDbContext		= Context classının ismini bu parametre ile belirleyebilirsiniz
-DataAnnotations				= Kolonlara ait veri koşullarının da koda eklenmesini sağlar
-Force							= Bu komut varsa, var olan classlar silinerek yerine yenileri oluşturulur
-Project ProjeAdi				= Hangi projenin içerisine oluşturmak istediğimizi belirtebiliyoruz
