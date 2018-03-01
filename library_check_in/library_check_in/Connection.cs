using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

/****************************************************/
/*  Author      |   Felipe Randolfo                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Clase para conexión a la base   */
/*                  de datos                        */
/****************************************************/
namespace library_check_in
{
    class Connection{
        public static string SERVER = "ISLABIBLIO-02\\SQLEXPRESS";
        public static string USER = "sa";
        public static string PASSWORD = "root";
        public static string DATA_BASE = "library_check_in";

        public static string CONNECTION_STRING =
            ";Data Source = " + SERVER +
            ";Initial Catalog =" + DATA_BASE +
            ";User ID=" + USER +
            ";Password=" + PASSWORD +
            ";Network Library=DBMSSOCN";

        public Connection() { }


        public System.Data.DataTable loadData(string command, string[] paramName, object[] param)
        {
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);
            for (int i = 0; i < paramName.Length; i++)
            {
                if (paramName[i] != null && param[i] != null)
                {
                    cmd.Parameters.AddWithValue(paramName[i].ToString(), param[i]);
                }
                else{break;}
            }
            
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            return dt;
        }
        public DataSet loadData(string command, string table, string[] paramName, object[] param)
        {
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);
            DataSet ds = new DataSet();
            for (int i = 0; i < paramName.Length; i++)
            {
                if (paramName[i] != null && param[i] != null)
                {
                    cmd.Parameters.AddWithValue(paramName[i].ToString(), param[i]);
                }
                else { break; }
            }

            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(ds, table);
            return ds;
        }
    }
}
