using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace library_check_in.Access
{
    class Access
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un acceso                             */
        /*  Date        | 21-03-2018                                    */
        /*  Parameters  | string carrerName, string carrerKey           */
        /****************************************************************/
        public DataTable save(string student_number, string not_student_number)
        {
            string command = "access_new @student_number = @student_number, @not_student_number	= @not_student_number";
            paramName[0] = "@student_number";
            paramName[1] = "@not_student_number";
            param[0] = student_number;
            param[1] = not_student_number;
            return con.loadData(command, paramName, param);
        }
    }
}
