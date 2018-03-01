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
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un Tipo de Usuario                    */
        /*  Date        | 19-02-2018                                    */
        /*  Parameters  | string typeUserNew                            */
        /****************************************************************/
        public void save(string description)
        {
            string command = "type_user_new @description = @description";
            paramName[0] = "@description";
            param[0] = description;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Modificar un Tipo de Usuario                  */
        /*  Date        | 28-02-2018                                    */
        /*  Parameters  | int id, string description                    */
        /****************************************************************/
        public void update(int id, string description)
        {
            string command = "type_user_update @id =  @id, @description = @description";
            paramName[0] = "@id";
            paramName[1] = "@description";
            param[0] = id;
            param[1] = description;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Eliminar un Tipo de Usuario                   */
        /*  Date        | 28-02-2018                                    */
        /*  Parameters  | int id                                        */
        /****************************************************************/
        public void delete(int id)
        {
            string command = "type_user_delete @id = @id";
            paramName[0] = "@id";
            param[0] = id;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
        }
        /****************************************************************/
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Consultar un Tipo de Usuario                  */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public object consult(int id, string description, string type_consult)
        {
            string command = "type_user_consult @id = @id, @description = @description, @type_consult = @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@description";
            paramName[2] = "@type_consult";
            param[0] = id;
            param[1] = description;
            param[2] = type_consult;
            return con.loadData(command, PROPS.TABLE_TYPE_USER, paramName, param);
               
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el combobox de tipo de usuario         */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, ComboBox cmbbx_typeUser           */
        /****************************************************************/
        public void load_cmbbxTypeUser(DataSet ds, ComboBox cmbbx_typeUser)
        {
            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.CONSULT_L1);
            cmbbx_typeUser.DataSource = ds.Tables[PROPS.TABLE_TYPE_USER];
            cmbbx_typeUser.DisplayMember = "description_typeUser";
            cmbbx_typeUser.ValueMember = "id_typeUser";
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el grid de tipos de usuarios           */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, DataGridView dtgd_typeUser        */
        /****************************************************************/
        public void load_dtgdTypeUser(DataSet ds, DataGridView dtgd_typeUser)
        {
            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.CONSULT_L1);
            dtgd_typeUser.DataSource = ds.Tables[PROPS.TABLE_TYPE_USER];
        }
    }
}
