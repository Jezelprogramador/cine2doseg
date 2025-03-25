using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

public class DbHelper
{
    private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CineConnection"].ConnectionString;

    public DataSet ExecuteQuery(string query)
    {
        DataSet ds = new DataSet();
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(ds);
        }
        return ds;
    }

    public int ExecuteNonQuery(string query)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
