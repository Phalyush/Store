using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


/// <summary>
/// Summary description for Helper
/// </summary>
public class SqlHelp
{
    string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;


    public DataTable ExecuteQuery(string query, IDictionary<string, string> parameters = null)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            
                if (parameters != null)
                {
                    foreach (string parameterName in parameters.Keys)
                        cmd.Parameters.AddWithValue(parameterName, parameters[parameterName]);
                }
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            
        }

    }
}