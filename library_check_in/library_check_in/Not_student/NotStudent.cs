using System.Data;
using System.Windows.Forms;
/**
 *  Author      | Arcelia Aguirre
 *  Date        | 19-02-2018
 *  Description | Clase para operaciones de No Estudiantes
 */
namespace library_check_in.Not_student
{
    class NotStudent
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Agregar un No Estudiante
         *  Date        | 12-03-2018
         *  Parameters  | string number, string name, string father_last_name, string mother_last_name, int id_type_not_student 
         */
        public void save(string number, string name, string father_last_name, string mother_last_name, int id_type_not_student)
        {
            string command = "not_student_new @number = @number, @name = @name,	@father_last_name = @father_last_name,	@mother_last_name = @mother_last_name, @id_type_not_student = @id_type_not_student";
            paramName[0] = "@number";
            paramName[1] = "@name";
            paramName[2] = "@father_last_name";
            paramName[3] = "@mother_last_name";
            paramName[4] = "@id_type_not_student";
            param[0] = number;
            param[1] = name;
            param[2] = father_last_name;
            param[3] = mother_last_name;
            param[4] = id_type_not_student;
            if (con.loadData(command, paramName, param) == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_SAVE);
            }
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Modificar un No Estudiante
         *  Date        | 12-03-2018
         *  Parameters  | int id, string number, string name, string father_last_name, string mother_last_name, int id_type_not_student
         */
        public void update(int id, string number, string name, string father_last_name, string mother_last_name, int id_type_not_student)
        {
            string command = "not_student_update @id = @id, @number = @number, @name = @name, @father_last_name = @father_last_name, @mother_last_name = @mother_last_name, @id_type_not_student = @id_type_not_student";
            paramName[0] = "@id";
            paramName[1] = "@number";
            paramName[2] = "@name";
            paramName[3] = "@father_last_name";
            paramName[4] = "@mother_last_name";
            paramName[5] = "@id_type_not_student";
            param[0] = id;
            param[1] = number;
            param[2] = name;
            param[3] = father_last_name;
            param[4] = mother_last_name;
            param[5] = id_type_not_student;
            if (con.loadData(command, paramName, param) == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_UPDATE);
            }
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Eliminar un No Estudiante
         *  Date        | 12-03-2018
         *  Parameters  | int id
         */
        public void delete(int id)
        {
            string command = "student_delete @id = @id";
            paramName[0] = "@id";
            param[0] = id;
            if (con.loadData(command, paramName, param) == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_DELETE);
            }
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Consultar un No Estudiante
         *  Date        | 12-03-2018
         *  Parameters  | int id, string number, string not_student_name, object type_not_student, string type_consult
         *  Retrun      | DataSet resutlado de la consulta
         */
        public object consult(int id, string number, string not_student_name, object type_not_student, string type_consult)
        {
            string command = "not_student_consult @id = @id, @number = @number, @not_student_name = @not_student_name, @type_not_student = @type_not_student, @type_consult = @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@number";
            paramName[2] = "@not_student_name";
            paramName[3] = "@type_not_student";
            paramName[4] = "@type_consult";
            param[0] = id;
            param[1] = number;
            param[2] = not_student_name;
            param[3] = type_not_student;
            param[4] = type_consult;
            return con.loadData(command, PROPS.TABLE_NOT_STUDENT, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Cargar el grid de licenciatura
         *  Date        | 22-02-2018
         *  Parameters  | DataSet ds, DataGridView dtgd_student, ComboBox cmbbx_typeRegister
         */
        public void load_dtgdStudent(DataSet ds, DataGridView dtgd_student, ComboBox cmbbx_typeRegister)
        {
            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.EMPTY, cmbbx_typeRegister.SelectedValue, PROPS.CONSULT_L3);
            if(ds == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_LOAD_CONSOLE);
                return;
            }
            dtgd_student.DataSource = ds.Tables[PROPS.TABLE_NOT_STUDENT];
        }
    }
}