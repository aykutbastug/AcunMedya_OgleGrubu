using System.Configuration;
using System.Data.SqlClient;

public static class UygulamaAyarlari
{
    public static SqlConnection MyConnection {
        
        get 
        { 
            return new SqlConnection(ConfigurationManager.ConnectionStrings["myConnecitonString"].ToString());
        }
    }


    public static Personel GirisYapanPersonel { get; set; }
}