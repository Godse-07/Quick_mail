using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Web.Services.Description;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Vs-Project\GMAIL-CLONE\GMAIL-CLONE\App_Data\Database2.mdf;Integrated Security=True");
    public static bool save(string str)
    {
        try
        {
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();

            return true;
        }
        catch (Exception e)
        {

            return false;
       }
        finally
       {
            con.Close();
        }
        
    }
    public static DataSet fetch(string str)
    {
       try
       {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch (Exception e)
        {
            return null;
        }
        finally
        {
           con.Close();
        }
    }
}