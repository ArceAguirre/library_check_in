using System.Data;
/**
 *  Author      | Arcelia Aguirre
 *  Date        | 21-03-2018 
 *  Description | Clase para Acceso a la Biblioteca
 */
namespace library_check_in.Access
{
    class Access
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Agregar un acceso
         *  Date        | 21-03-2018
         *  Parameters  | string student_number, string not_student_number
         */
        public DataTable save(string student_number, string not_student_number)
        {

            DataTable dataTable;
            string command = "access_new @student_number = @student_number, @not_student_number	= @not_student_number";
            paramName[0] = "@student_number";
            paramName[1] = "@not_student_number";
            param[0] = student_number;
            param[1] = not_student_number;
            dataTable = con.loadData(command, paramName, param);
            if (dataTable == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_SAVE);
                return null;
            }
            return dataTable;
        }
    }
}