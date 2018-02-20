using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using library_check_in.career;
using library_check_in.Type_not_student;
using library_check_in.Type_user;
using library_check_in.User_CICE;

namespace library_check_in
{
    public partial class frm_signIn : Form
    {
        string[] paramName = new string[20];
        object[] param = new object[20];
        /*Variables Golbales*/
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        Connection con = new Connection();

        /****************************************************************/
        /*  Description | Constructor del form                          */
        /*  Date        |                                               */
        /****************************************************************/
        public frm_signIn()
        {
            InitializeComponent();
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Inicializar el form                           */
        /*  Date        |                                               */
        /*  Parameters  | object sender, EventArgs e                    */
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
            cmbbx_typeUser.DataSource = ds.Tables["type_user"];
            cmbbx_typeUser.DisplayMember = "description";
            cmbbx_typeUser.ValueMember = "id";
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
        private void btn_typeNotStudentSave_Click(object sender, EventArgs e)
        {
            TypeNotStudent typeNotStudent = new TypeNotStudent();
            typeNotStudent.save(txt_typeNotStudentName.Text);
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
            TypeUser typeUser = new TypeUser();
            typeUser.save(txt_typeUserName.Text);
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
        /*  Description | Agregar una carrera                           */
        /*  Date        |                                               */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_careerSave_Click(object sender, EventArgs e)
        {
            Career career = new Career();
            career.save(txt_careerName.Text, txt_careerKey.Text);
            txt_careerName.Clear();
            txt_careerKey.Clear();
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description | Agregar un usuario                            */
        /*  Date        |                                               */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_userSave_Click(object sender, EventArgs e)
        {
            UserCICE userCICE = new UserCICE();
            userCICE.save(txt_nameUser.Text, txt_passwordUser.Text, txt_fatherLastnameUser.Text, 
                txt_motherLastnameUser.Text, Int32.Parse(cmbbx_typeUser.SelectedValue.ToString()));
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