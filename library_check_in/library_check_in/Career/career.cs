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
        string[] paramName = new string[20];
        object[] param = new object[20];
        Connection con = new Connection();

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar una carrera                           */
        /*  Date        | 19-02-2018                                    */
        /*  Parameters  | string carrerName, string carrerKey           */
        /****************************************************************/
        public void save(string carrerName, string carrerKey)
        {
            string command = "career_new @career_name = @career_name, @career_key = @careerKey ";
            paramName[0] = "@career_name";
            paramName[1] = "@careerKey";
            param[0] = carrerName;
            param[1] = carrerKey;
            DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Modificar una carrera                         */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | int id, string carrerName, string carrerKey   */
        /****************************************************************/
        public void update(int id, string carrerName, string carrerKey)
        {
            string command = "career_update @id = @id, @career_name = @career_name,	@career_key = @careerKey";
            paramName[0] = "@id";
            paramName[1] = "@career_name";
            paramName[2] = "@careerKey";
            param[0] = id;
            param[1] = carrerName;
            param[2] = carrerKey;
            DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Eliminar una carrera                          */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | int id                                        */
        /****************************************************************/
        public void delete(int id)
        {
            string command = "career_delete @id = @id";
            paramName[0] = "@id";
            param[0] = id;
            DataTable dt = con.loadData(command, paramName, param);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre Treviño                       */
        /*  Description | Consultar carreras                            */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | string type_consult                           */
        /****************************************************************/
        public object consult(int id, string career_name, string career_key, string type_consult)
        {
            string command = "career_consult @id = @id, @career_name = @career_name, @career_key = @career_key, @type_consult = @type_consult";
            paramName[0] = "@id";
            paramName[1] = "@career_name";
            paramName[2] = "@career_key";
            paramName[3] = "@type_consult";
            param[0] = id;
            param[1] = career_name;
            param[2] = career_key;
            param[3] = type_consult;
            return con.loadData(command, PROPS.TABLE_CAREER, paramName, param);
               
        }
        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el combobox de licenciatura            */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, ComboBox cmbbxCarrer              */
        /****************************************************************/
        public void load_cmbbxCarrer(DataSet ds, ComboBox cmbbx_carrer)
        {
            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.EMPTY, PROPS.CONSULT_L1);
            cmbbx_carrer.DataSource = ds.Tables[PROPS.TABLE_CAREER];
            cmbbx_carrer.DisplayMember = "career_name";
            cmbbx_carrer.ValueMember = "id_career";
        }
        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Cargar el grid de licenciatura                */
        /*  Date        | 22-02-2018                                    */
        /*  Parameters  | DataSet ds, DataGridView dtgd_Career          */
        /****************************************************************/
        public void load_dtgdCareer(DataSet ds, DataGridView dtgd_Career)
        {
            ds = (DataSet)this.consult(PROPS.CERO, PROPS.EMPTY, PROPS.EMPTY, PROPS.CONSULT_L1);
            dtgd_Career.DataSource = ds.Tables[PROPS.TABLE_CAREER];
        }
    }
}
