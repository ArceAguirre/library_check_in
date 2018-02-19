﻿using System;
using System.Collections.Generic;
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
        public static string SERVER = "BIBLIOTECAISLA\\SQLEXPRESS";
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


        public System.Data.DataTable loadData(string command, string[] paramName, string[] param)
        {
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);

            for(int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.AddWithValue(paramName[i], param[i]);
            }
            
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);

            return dt;
        }
    }
}
