using System.Configuration;
using System.Data.SqlClient;

public static class MySqlConnection
{
    public static SqlConnection MyConnection {
        get { 
            return new SqlConnection(ConfigurationManager.ConnectionStrings["myConnecitonString"].ToString());
        }
    }
}