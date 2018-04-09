using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
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

        /*************************************************************/
        /*  Author      |   Arcelia Aguirre                          */
        /*  Date        |   02-02-2018                               */
        /*  Description |   Ejecutar un comando                      */
        /*  Parameters  |   string command Query                     */
        /*                  string[] paramName, nombre del parámetro */
        /*                  object[] param valor del parámetro       */
        /*  Return      |   DataTable dt                             */
        /*************************************************************/
        public DataTable loadData(string command, string[] paramName, object[] param)
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
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            conn.Open();
            //cmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }
        /*************************************************************/
        /*  Author      |   Arcelia Aguirre                          */
        /*  Date        |   02-02-2018                               */
        /*  Description |   Ejecutar un comando                      */
        /*  Parameters  |   string command Query                     */
        /*                  string table Tabla que ejecuta           */
        /*                  string[] paramName, nombre del parámetro */
        /*                  object[] param valor del parámetro       */
        /*  Return      |   DataSet dt                               */
        /*************************************************************/
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
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(ds, table);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
    }
}
