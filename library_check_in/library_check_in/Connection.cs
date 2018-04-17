using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/**
*  Author      | Arcelia Aguirre                 
*  Date        | 02-02-2018                      
*  Description | Clase para conexión a la base de datos                        
*/
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
        /**
         *  Author      |   Arcelia Aguirre
         *  Date        |   02-02-2018
         *  Description |   Ejecutar un comando
         *  Parameters  |   string command, string[] paramName, object[] param valor del parámetro
         *  Return      |   DataTable dt
         */
        public DataTable loadData(string command, string[] paramName, object[] param)
        {
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);
            DataTable dt = new DataTable();
            for (int i = 0; i < paramName.Length; i++)
            {
                if (paramName[i] != null && param[i] != null)
                {
                    cmd.Parameters.AddWithValue(paramName[i].ToString(), param[i]);
                }
                else
                    break;
            }
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            try
            {
                adapt.Fill(dt);
                conn.Open();
                conn.Close();
                return dt;
            }
            catch
            {
                PROPS.messageError("");
                return null;
            }
        }
        /**
         *  Author      |   Arcelia Aguirre
         *  Date        |   02-02-2018
         *  Description |   Ejecutar un comando
         *  Parameters  |   string command, string table, string[] paramName, object[] param valor del parámetro
         *  Return      |   DataSet dt
         */
        public DataSet loadData(string command, string table, string[] paramName, object[] param)
        {
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            for (int i = 0; i < paramName.Length; i++)
            {
                if (paramName[i] != null && param[i] != null)
                {
                    cmd.Parameters.AddWithValue(paramName[i].ToString(), param[i]);
                }
                else { break; }
            }
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt = new SqlDataAdapter(cmd);
            try
            {
                adapt.Fill(ds, table);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return ds;
            }
            catch
            {
                PROPS.messageError("");
                return null;
            }
        }
    }
}