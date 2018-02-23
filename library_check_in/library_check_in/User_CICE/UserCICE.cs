using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace library_check_in.User_CICE
{
    class UserCICE
    {
        string TABLE = "user_CICE";
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /**************************************************************************************/
        /*  Author      | Arcelia Aguirre                                                     */
        /*  Description | Agregar un usuario                                                  */
        /*  Date        | 19-02-2018                                                          */
        /*  Parameters  | string nameUser, string passwordUser,                               */
        /*              | string fatherLastnameUser, string motherLastnameUser, int typeUser  */
        /**************************************************************************************/
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
        /*  Description | Modificar usuario                             */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /****************************************************************/
        public void update()
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Eliminar un usuario                           */
        /*  Date        |                                               */
        /*  Parameters  | int id                                        */
        /****************************************************************/
        public void delete(int id)
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Consultar usuario                             */
        /*  Date        |                                               */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public object consult(string type_consult)
        {
            switch (type_consult)
            {
                case "L1":
                    string command = "select * from user_CICE";
                    paramName[0] = "";
                    param[0] = "";
                    return con.loadData(command, TABLE, paramName, param);
                default:
                    return null;
            }
        }
        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | login                                         */
        /*  Date        |                                               */
        /*  Parameters  | string user, string password                  */
        /****************************************************************/
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


        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el grid de usuarios de cice            */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, DataGridView dtgd_user            */
        /****************************************************************/
        public void load_dtgdUser(DataSet ds, DataGridView dtgd_user)
        {
            ds = (DataSet)this.consult("L1");
            dtgd_user.DataSource = ds.Tables[0];
        }
    }
}
