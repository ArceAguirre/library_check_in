using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*****************************************************/
/*  Author      |   Arcelia Aguirre                  */
/*  Date        |   19-02-2018                       */
/*  Description |   Clase para operaciones de        */
/*                  Licenciatura                     */
/*****************************************************/
namespace library_check_in.career
{
    class Career
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
        public void save(string carrerName, string carrerKey)
        {
            string command = "career_new @career_name = @carrerName, @career_key = @carrerKey ";
            paramName[0] = "@carrerName";
            param[0] = carrerName;
            paramName[1] = "@carrerKey";
            param[1] = carrerKey;
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
    }
}
