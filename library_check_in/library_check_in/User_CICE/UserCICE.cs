using System.Data;
using System.Windows.Forms;
/**
 *  Author      | Arcelia Aguirre
 *  Date        | 19-02-2018
 *  Description | Clase para operaciones de Usuarios de CICE
 */
namespace library_check_in.User_CICE
{
    class UserCICE
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Agregar un usuario
         *  Date        | 19-02-2018
         *  Parameters  | string nameUser, string passwordUser, string fatherLastnameUser, string motherLastnameUser, int typeUser
         */
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
            if (con.loadData(command, paramName, param) == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_SAVE);
            }
        }
        /**
         *  Author      | Arcelia Aguirre   
         *  Description | Modificar usuario
         *  Date        | 28-02-2018
         *  Parameters  | int id,string user_name,string user_password,string user_password_old,
         *                string father_last_name, string mother_last_name, int id_type_user
         */
        public void update(int id, string user_name, string user_password, string user_password_old, string father_last_name, string mother_last_name, int id_type_user)
        {
            string command = "user_CICE_update @id = @id, @user_name = @user_name,	@user_password = @user_password, @user_password_old = @user_password_old, @father_last_name = @father_last_name, @mother_last_name = @mother_last_name, @id_type_user =  @id_type_user";
            paramName[0] = "@id";
            paramName[1] = "@user_name";
            paramName[2] = "@user_password";
            paramName[3] = "@user_password_old";
            paramName[4] = "@father_last_name";
            paramName[5] = "@mother_last_name";
            paramName[6] = "@id_type_user";
            param[0] = id;
            param[1] = user_name;
            param[2] = user_password;
            param[3] = user_password_old;
            param[4] = father_last_name;
            param[5] = mother_last_name;
            param[6] = id_type_user;
            if (con.loadData(command, paramName, param) == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_UPDATE);
            }
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Eliminar un usuario
         *  Date        | 28-02-2018
         *  Parameters  | int id
         */
        public void delete(int id)
        {
            string command = "user_CICE_delete @id = @id";
            paramName[0] = "@id";
            param[0] = id;
            if (con.loadData(command, paramName, param) == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_DELETE);
            }
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Consultar usuario
         *  Date        | 28-02-2018
         *  Parameters  | int id, string user_name, string type_consult
         */
        public object consult(int id, string user_name, string type_consult)
        {
            DataSet dataSet;
            string command = "user_CICE_consult @id = @id, @user_name = @user_name, @type_consult = @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@user_name";
            paramName[2] = "@type_consult";
            param[0] = id;
            param[1] = user_name;
            param[2] = type_consult;
            dataSet = con.loadData(command, PROPS.TABLE_USER_CICE, paramName, param);
            if (dataSet == null)
            {
                PROPS.messageError((int)PROPS.MESSAGE_ERROR.NOT_LOAD_CONSOLE);
                return null;
            }
            return dataSet;
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | login
         *  Date        | 28-02-2018
         *  Parameters  | string user, string password
         */
        public DataTable login(string user, string password)
        {
            string command = "select id_type_user from user_CICE where user_name = @user and user_password = @password";
            paramName[0] = "@user";
            param[0] = user;
            paramName[1] = "@password";
            param[1] = password;
            DataTable dt = con.loadData(command, paramName, param);
            return dt;
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Cargar el grid de usuarios de cice
         *  Date        | 22-02-2018
         *  Parameters  | DataSet ds, DataGridView dtgd_user
         */
        public void load_dtgdUser(DataSet ds, DataGridView dtgd_user)
        {

            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.CONSULT_L1);
            dtgd_user.DataSource = ds.Tables[PROPS.TABLE_USER_CICE];
        }
    }
}