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
/*                  Licenciatura                     */
/*****************************************************/
namespace library_check_in.career
{
    class Career
    {
        string TABLE = "career";
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
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Consultar carreras                            */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public object consult(string type_consult)
        {
            switch (type_consult)
            {
                case "L1":
                    string command = "select * from career";
                    paramName[0] = "";
                    param[0] = "";
                    return con.loadData(command, TABLE, paramName, param);
                default:
                    return null;
            }
        }
        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el combobox de licenciatura            */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, ComboBox cmbbxCarrer              */
        /****************************************************************/
        public void load_cmbbxCarrer(DataSet ds, ComboBox cmbbx_carrer)
        {
            ds = (DataSet)this.consult("L1");
            cmbbx_carrer.DataSource = ds.Tables[TABLE];
            cmbbx_carrer.DisplayMember = "career_name";
            cmbbx_carrer.ValueMember = "id";
        }
        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el grid de licenciatura                */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, DataGridView dtgd_Career          */
        /****************************************************************/
        public void load_dtgdCareer(DataSet ds, DataGridView dtgd_Career)
        {
            ds = (DataSet)this.consult("L1");
            dtgd_Career.DataSource = ds.Tables[0];
        }
    }
}
