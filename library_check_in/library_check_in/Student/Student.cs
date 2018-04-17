using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
/**
 *  Author      | Arcelia Aguirre
 *  Date        | 19-02-2018
 *  Description | Clase para operaciones de Estudiante                       
 */
namespace library_check_in.Student
{
    class Student
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Agregar un Estudiante
         *  Date        | 01-03-2018
         *  Parameters  | int number, string student_name,
         *              | string student_father_last_name,
         *              | string student_mother_last_name,
         *              | string semester, string id_carrer
         */
        public void save(string number, string student_name, string student_father_last_name, string student_mother_last_name, string semester, int id_carrer)
        {
            string command = "student_new @number = @number, @student_name = @student_name,	@student_father_last_name = @student_father_last_name,	@student_mother_last_name = @student_mother_last_name, @semester = @semester, @id_career = @id_career";
            paramName[0] = "@number";
            paramName[1] = "@student_name";
            paramName[2] = "@student_father_last_name";
            paramName[3] = "@student_mother_last_name";
            paramName[4] = "@semester";
            paramName[5] = "@id_career";
            param[0] = number;
            param[1] = student_name;
            param[2] = student_father_last_name;
            param[3] = student_mother_last_name;
            param[4] = semester;
            param[5] = id_carrer;
            DataTable dt = con.loadData(command, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Modificar un Estudiante
         *  Date        | 01-03-2018
         *  Parameters  | int id, string number, string student_name,
         *                string student_father_last_name,
         *                string student_mother_last_name, string semester,
         *                int id_carrer
         */
        public void update(int id, string number, string student_name, string student_father_last_name, string student_mother_last_name, string semester, int id_carrer)
        {
            string command = "student_update @id = @id, @number = @number, @student_name = @student_name,	@student_father_last_name = @student_father_last_name,	@student_mother_last_name = @student_mother_last_name, @semester = @semester, @id_career = @id_career";
            paramName[0] = "@id";
            paramName[1] = "@number";
            paramName[2] = "@student_name";
            paramName[3] = "@student_father_last_name";
            paramName[4] = "@student_mother_last_name";
            paramName[5] = "@semester";
            paramName[6] = "@id_career";
            param[0] = id;
            param[1] = number;
            param[2] = student_name;
            param[3] = student_father_last_name;
            param[4] = student_mother_last_name;
            param[5] = semester;
            param[6] = id_carrer;
            DataTable dt = con.loadData(command, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre                                              
         *  Description | Eliminar un Estudiante                        
         *  Date        | 12-03-2018                                              
         *  Parameters  | int id                                        
         */
        public void delete(int id)
        {
            string command = "student_delete @id = @id";
            paramName[0] = "@id";
            param[0] = id;
            DataTable dt = con.loadData(command, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Consultar un Estudiante
         *  Date        | 12-03-2018
         *  Parameters  | int id, string number, string student_name, string type_consult
         *  Retrun      | DataSet resutlado de la consulta
         */
        public DataSet consult(int id, string number, string student_name, string type_consult)
        {
            string command = "student_consult @id = @id, @number = @number,	@student_name =  @student_name, @type_consult =  @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@number";
            paramName[2] = "@student_name";
            paramName[3] = "@type_consult";
            param[0] = id;
            param[1] = number;
            param[2] = student_name;
            param[3] = type_consult;
            return con.loadData(command, PROPS.TABLE_STUDENT, paramName, param);
        }
        /**
         *  Author      | Arcelia Aguirre                               
         *  Description | Cargar gird de Estudiante                     
         *  Date        | 12-03-2018                                    
         *  Parameters  | DataSet ds, DataGridView dtgd_student         
         */
        public void load_dtgdStudent(DataSet ds, DataGridView dtgd_student)
        {
            try
            {
                ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.EMPTY, PROPS.CONSULT_L1);
                dtgd_student.DataSource = ds.Tables[PROPS.TABLE_STUDENT];
            }
            catch
            {
                PROPS.messageError("");
            }
            
        }
    }
}