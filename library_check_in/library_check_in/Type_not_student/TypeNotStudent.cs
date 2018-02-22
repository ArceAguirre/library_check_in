using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*****************************************************/
/*  Author      |   Arcelia Aguirre                  */
/*  Date        |   19-02-2018                       */
/*  Description |   Clase para operaciones de        */
/*                  Tipos de no estudiantes          */
/*****************************************************/
namespace library_check_in.Type_not_student
{
    class TypeNotStudent
    {
        string TABLE = "type_not_student";
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un tipo de no estudiante              */
        /*  Date        | 19-02-2018                                    */
        /*  Parameters  | string typeNotStudentName                     */
        /****************************************************************/
        public void save(string typeNotStudentName)
        {
            string command = "type_not_student_new @description =  @typeNotStudentName";
            paramName[0] = "@typeNotStudentName";
            param[0] = typeNotStudentName;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Modificar un tipo de no estudiante            */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /****************************************************************/
        public void update()
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Eliminar un tipo de no estudiante             */
        /*  Date        |                                               */
        /*  Parameters  | int id                                        */
        /****************************************************************/
        public void delete(int id)
        {

        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Consultar un tipo de no estudiante            */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public object consult(string type_consult)
        {
            switch (type_consult)
            {
                case "L1":
                    string command = "select * from type_not_student";
                    paramName[0] = "";
                    param[0] = "";
                    return con.loadData(command, TABLE, paramName, param);
                default:
                    return null;
            }
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el combobox de reporte                 */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, ComboBox cmbbx_typeUser           */
        /****************************************************************/
        public void load_cmbbxReport(DataSet ds, ComboBox cmbbx_report)
        {
            ds = (DataSet)this.consult("L1");
            cmbbx_report.DataSource = ds.Tables[TABLE];
            cmbbx_report.DisplayMember = "description";
            cmbbx_report.ValueMember = "id";
        }
    }
}