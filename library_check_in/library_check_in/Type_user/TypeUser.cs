using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*****************************************************/
/*  Author      |   Arcelia Aguirre                  */
/*  Date        |   19-02-2018                       */
/*  Description |   Clase para operaciones de        */
/*                  Tipo de Usuario                  */
/*****************************************************/
namespace library_check_in.Type_user
{
    class TypeUser
    {
        string TABLE = "type_user";
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un Tipo de Usuario                    */
        /*  Date        | 19-02-2018                                    */
        /*  Parameters  | string typeUserNew                            */
        /****************************************************************/
        public void save(string typeUserNew)
        {
            string command = "type_user_new @description = @typeUserNew";
            paramName[0] = "@typeUserNew";
            param[0] = typeUserNew;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Modificar un Tipo de Usuario                  */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /****************************************************************/
        public void update()
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Eliminar un Tipo de Usuario                   */
        /*  Date        |                                               */
        /*  Parameters  | int id                                        */
        /****************************************************************/
        public void delete(int id)
        {

        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Consultar un Tipo de Usuario                  */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public object consult(string type_consult)
        {
            switch (type_consult)
            {
                case "L1":
                    string command = "select * from type_user";
                    paramName[0] = "";
                    param[0] = "";
                    return con.loadData(command, TABLE, paramName, param);
                default :
                    return null;
            }
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el combobox de tipo de usuario         */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, ComboBox cmbbx_typeUser           */
        /****************************************************************/
        public void load_cmbbxTypeUser(DataSet ds, ComboBox cmbbx_typeUser)
        {
            ds = (DataSet)this.consult("L1");
            cmbbx_typeUser.DataSource = ds.Tables[TABLE];
            cmbbx_typeUser.DisplayMember = "description";
            cmbbx_typeUser.ValueMember = "id";
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el grid de tipos de usuarios           */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, DataGridView dtgd_typeUser        */
        /****************************************************************/
        public void load_dtgdTypeUser(DataSet ds, DataGridView dtgd_typeUser)
        {
            ds = (DataSet)this.consult("L1");
            dtgd_typeUser.DataSource = ds.Tables[0];
        }
    }
}
