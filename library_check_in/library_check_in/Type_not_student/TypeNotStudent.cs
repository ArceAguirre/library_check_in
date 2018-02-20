using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /*  Author      |                                               */
        /*  Description | Consultar un tipo de no estudiante            */
        /*  Date        |                                               */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public void consult(string type_consult)
        {

        }
    }
}