using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library_check_in.Student
{
    class Student
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
