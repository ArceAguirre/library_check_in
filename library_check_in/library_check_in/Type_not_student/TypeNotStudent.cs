using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/**
 *  Author      | Arcelia Aguirre
 *  Date        | 19-02-2018
 *  Description | Clase para operaciones de Tipos de no estudiantes
 */
namespace library_check_in.Type_not_student
{
    class TypeNotStudent
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Agregar un tipo de no estudiante
         *  Date        | 19-02-2018
         *  Parameters  | string typeNotStudentName
         */
        public void save(string typeNotStudentName)
        {
            string command = "type_not_student_new @description =  @typeNotStudentName";
            paramName[0] = "@typeNotStudentName";
            param[0] = typeNotStudentName;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Modificar un tipo de no estudiante
         *  Date        | 28-02-2018
         *  Parameters  | int id, string description
         */
        public void update(int id, string description)
        {
            string command = "type_not_student_update @id = @id , @description = @description";
            paramName[0] = "@id";
            paramName[1] = "@description";
            param[0] = id;
            param[1] = description;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Eliminar un tipo de no estudiante
         *  Date        | 28-02-2018
         *  Parameters  | int id
         */
        public void delete(int id)
        {
            string command = "type_not_student_delete @id = @id";
            paramName[0] = "@id";
            param[0] = id;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }
        /**
         *  Author      | Felipe Randolfo
         *  Description | Consultar un tipo de no estudiante
         *  Date        | 22-02-2018
         *  Parameters  | int id, string description, string type_consult
         *  Retrun      | DataSet resutlado de la consulta
         */
        public object consult(int id, string description, string type_consult)
        {
            string command = "type_not_student_consult @id = @id, @description = @description, @type_consult = @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@description";
            paramName[2] = "@type_consult";
            param[0] = id;
            param[1] = description;
            param[2] = type_consult;
            return con.loadData(command, PROPS.TABLE_TYPE_NOT_STUDENT, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Cargar el combobox de reporte
         *  Date        | 22-02-2018
         *  Parameters  | DataSet ds, ComboBox cmbbx_typeUser
         */
        public void load_cmbbxReport(DataSet ds, ComboBox cmbbx_report)
        {
            try
            {
                ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.CONSULT_L1);
                cmbbx_report.DataSource = ds.Tables[PROPS.TABLE_TYPE_NOT_STUDENT];
                cmbbx_report.DisplayMember = "description_typeNotStudent";
                cmbbx_report.ValueMember = "id_typeNotStudent";
            }
            catch
            {
                PROPS.messageError("");
                return;
            }
           
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Cargar el grid de tipos de no estudiantes
         *  Date        | 22-02-2018
         *  Parameters  | DataSet ds, DataGridView dtgd_typeNotStudent
         */
        public void load_dtgdTypeNotStudent(DataSet ds, DataGridView dtgd_typeNotStudent)
        {
            try
            {
                ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.CONSULT_L1);
                dtgd_typeNotStudent.DataSource = ds.Tables[PROPS.TABLE_TYPE_NOT_STUDENT];
            }
            catch
            {
                PROPS.messageError("");
            }
        }
    }
}