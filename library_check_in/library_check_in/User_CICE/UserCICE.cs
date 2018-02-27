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
            paramName[1] = "@passwordUser";
            paramName[2] = "@fatherLastnameUser";
            paramName[3] = "@motherLastnameUser";
            paramName[4] = "@typeUser";
            param[0] = nameUser;
            param[1] = passwordUser;
            param[2] = fatherLastnameUser;
            param[3] = motherLastnameUser;
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
        public object consult(int id, string user_name, string type_consult)
        {
            string command = "user_CICE_consult @id = @id, @user_name = @user_name, @type_consult = @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@user_name";
            paramName[2] = "@type_consult";
            param[0] = id;
            param[1] = user_name;
            param[2] = type_consult;
            return con.loadData(command, PROPS.TABLE_USER_CICE, paramName, param);
                
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
            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.CONSULT_L1);
            dtgd_user.DataSource = ds.Tables[PROPS.TABLE_USER_CICE];
        }
    }
}
