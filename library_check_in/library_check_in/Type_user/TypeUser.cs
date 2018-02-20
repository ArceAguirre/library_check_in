using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /*  Author      |                                               */
        /*  Description | Consultar un Tipo de Usuario                  */
        /*  Date        |                                               */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public void consult(string type_consult)
        {

        }
    }
}
