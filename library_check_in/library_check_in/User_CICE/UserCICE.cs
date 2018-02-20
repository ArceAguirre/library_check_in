using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_check_in.User_CICE
{
    class UserCICE
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar una carrera                           */
        /*  Date        |  19-02-2018                                   */
        /*  Parameters  | string carrerName, string carrerKey           */
        /****************************************************************/
        public void save(string nameUser, string passwordUser, string fatherLastnameUser, string motherLastnameUser, int typeUser)
        {
            string command = "user_CICE_new @user_name = @nameUser, @user_password = @passwordUser, @father_last_name = @fatherLastnameUser, @mother_last_name = @motherLastnameUser, @id_type_user = @typeUser ";
            paramName[0] = "@nameUser";
            param[0] = nameUser;
            paramName[1] = "@passwordUser";
            param[1] = passwordUser;
            paramName[2] = "@fatherLastnameUser";
            param[2] = fatherLastnameUser;
            paramName[3] = "@motherLastnameUser";
            param[3] = motherLastnameUser;
            paramName[4] = "@typeUser";
            param[4] = typeUser;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Modificar una carrera                         */
        /*  Date        |                                               */
        /*  Parameters  | int id, string carrerName, string carrerKey   */
        /****************************************************************/
        public void update(int id, string carrerName, string carrerKey)
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Eliminar una carrera                          */
        /*  Date        |                                               */
        /*  Parameters  | int id                                        */
        /****************************************************************/
        public void delete(int id)
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Consultar carreras                            */
        /*  Date        |                                               */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public void consult(string type_consult)
        {

        }

        public System.Data.DataTable login(string user, string password)
        {
            string command = "select id_type_user from user_CICE where user_name = @user and user_password = @password";
            paramName[0] = "@user";
            param[0] = user;
            paramName[1] = "@password";
            param[1] = password;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
            return dt;
        }
    }
}
