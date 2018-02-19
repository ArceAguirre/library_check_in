using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace library_check_in
{
    public partial class frm_signIn : Form
    {
        /*Variables Golbales*/
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        Connection con = new Connection();
        string[] paramName = new string[20];
        string[] param = new string[20];
        public static int indice;

        /****************************************************************/
        /*  Description | Constructor del form                          */
        /*  Date        |                                               */
        /****************************************************************/
        public frm_signIn()
        {
            InitializeComponent();
        }

        /****************************************************************/
        /*  Description | Generar el reporte seleccionado               */
        /*  Date        |                                               */
        /*  Pestaña     | Reportes                                      */
        /*  Parameters  | object sender, EventArgs e                    */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void btn_generate_Click(object sender, EventArgs e)
        {
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void frm_signIn_Load(object sender, EventArgs e)
        {
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM type_user";
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "type_user");
            this.cmbbx_typeUser.SelectedIndexChanged -= new System.EventHandler(this.cmbbx_typeUser_SelectedIndexChanged);
            cmbbx_typeUser.DataSource = ds.Tables["type_user"];
            cmbbx_typeUser.DisplayMember = "description";
            cmbbx_typeUser.ValueMember = "id";
            this.cmbbx_typeUser.SelectedIndexChanged += new System.EventHandler(this.cmbbx_typeUser_SelectedIndexChanged);
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void cmbbx_typeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = Int32.Parse(cmbbx_typeUser.SelectedValue.ToString());
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void btn_typeNotStudentSave_Click(object sender, EventArgs e)
        {
            string typeNotStudentName = txt_typeNotStudentName.Text;
            string command = "type_not_student_new @description =  @typeNotStudentName";
            paramName[0] = "@typeNotStudentName";
            param[0] = typeNotStudentName;
            System.Data.DataTable dt = con.loadData(command, paramName, param);
            txt_typeNotStudentName.Clear();
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void txt_typeNotStudentName_TextChanged(object sender, EventArgs e)
        {
            txt_typeNotStudentName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_typeNotStudentName.Text);
            txt_typeNotStudentName.SelectionStart = txt_typeNotStudentName.Text.Length;
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void btn_typeUserSave_Click(object sender, EventArgs e)
        {
            var typeUserNew = txt_typeUserName.Text;

            string command = "type_user_new @description = @typeUserNew";
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            var cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@typeUserNew", typeUserNew);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            txt_typeUserName.Clear();
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void txt_typeUserName_TextChanged(object sender, EventArgs e)
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void btn_careerSave_Click(object sender, EventArgs e)
        {
            string carrerName = txt_careerName.Text;
            string carrerKey = txt_careerKey.Text;
            string command = "career_new @career_name = @carrerName, @career_key = @carrerKey ";
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@carrerName", carrerName);
            cmd.Parameters.AddWithValue("@carrerKey", carrerKey);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            txt_careerName.Clear();
            txt_careerKey.Clear();
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void btn_userSave_Click(object sender, EventArgs e)
        {
            var nameUser = txt_nameUser.Text;
            var passwordUser = txt_passwordUser.Text;
            var fatherLastnameUser = txt_fatherLastnameUser.Text;
            var motherLastnameUser = txt_motherLastnameUser.Text;
            var typeUser = indice;

            string command = "user_CICE_new @user_name = @nameUser, @user_password = @passwordUser, @father_last_name = @fatherLastnameUser, @mother_last_name = @motherLastnameUser, @id_type_user = @typeUser ";
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            var cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@nameUser", nameUser);
            cmd.Parameters.AddWithValue("@passwordUser", passwordUser);
            cmd.Parameters.AddWithValue("@fatherLastnameUser", fatherLastnameUser);
            cmd.Parameters.AddWithValue("@motherLastnameUser", motherLastnameUser);
            cmd.Parameters.AddWithValue("@typeUser", typeUser);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            txt_nameUser.Clear();
            txt_passwordUser.Clear();
            txt_fatherLastnameUser.Clear();
            txt_motherLastnameUser.Clear();
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
        /****************************************************************/
        private void btn_create_Click(object sender, EventArgs e)
        {

        }
    }
}
