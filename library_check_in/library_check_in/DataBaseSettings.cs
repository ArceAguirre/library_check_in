using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/**
 *  Author      | Arcelia Aguirre
 *  Description | Clase para configuración de la base de datos
 *  Date        | 01-03-2018
 */
namespace library_check_in
{
    class DataBaseSettings
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Validar si existe la base de datos
         *  Date        | 01-03-2018
         *  Parameters  | object sender, EventArgs e
         */
        public DataTable ifExist()
        {
            string command = "select name from master.sys.databases where name = N'" + Connection.DATA_BASE + "2'";
            DataTable dt = con.loadData(command, paramName, param);
            return dt;
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Crear la Base de datos con sus tablas
         *  Date        | 01-03-2018
         *  Parameters  | object sender, EventArgs e
         */
        public void createDataBase()
        {
            string command = "create database " + Connection.DATA_BASE + "2;";
            DataTable dt = con.loadData(command, paramName, param);

            FileInfo file = new FileInfo(Directory.GetCurrentDirectory() + "\\..\\..\\DataBase\\database.sql");
            string script = file.OpenText().ReadToEnd();
            dt = con.loadData(script, paramName, param);
        }

        /**
         *  Author      | Arcelia Aguirre
         *  Description | Borrar la Base de Datos
         *  Date        | 01-03-2018
         *  Parameters  | object sender, EventArgs e
         */
        public void deleteDataBase()
        {
            string command = "drop database " + Connection.DATA_BASE + "2;";
            DataTable dt = con.loadData(command, paramName, param);
        }
    }
}