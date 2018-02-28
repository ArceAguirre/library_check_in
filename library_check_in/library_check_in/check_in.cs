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
        /****************************************************************/
        public frm_signIn()
        {
            InitializeComponent();
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Inicializar el form                           */
        /*  Date        | 23-02-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void frm_signIn_Load(object sender, EventArgs e)
        {
            TypeUser typeUser = new TypeUser();
            TypeNotStudent typeNotStudent = new TypeNotStudent();
            Career career = new Career();
            UserCICE userCICE = new UserCICE();
            /*Combobox*/
            typeUser.load_cmbbxTypeUser(ds, cmbbx_typeUser);
            typeNotStudent.load_cmbbxReport(ds, cmbbx_report);
            typeNotStudent.load_cmbbxReport(ds, cmbbx_type);
            typeNotStudent.load_cmbbxReport(ds, cmbbx_typeRegister);
            career.load_cmbbxCarrer(ds, cmbbx_carrer);
            career.load_cmbbxCarrer(ds, cmbbox_careerStudent);

            /*Grid*/
            career.load_dtgdCareer(ds, dtgd_career);
            typeNotStudent.load_dtgdTypeNotStudent(ds, dtgd_typeNotStudent);
            typeUser.load_dtgdTypeUser(ds, dtgd_typeUser);
            userCICE.load_dtgdUser(ds, dtgd_user);

        }

        /****************************************************************/
        /*  Description | Generar el reporte seleccionado               */
        /*  Date        |                                               */
        /*  Pestaña     | Reportes                                      */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_generate_Click(object sender, EventArgs e)
        {
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un tipo de no estudiante              */
        /*  Date        | 23-02-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_typeNotStudentSave_Click(object sender, EventArgs e)
        {
            TypeNotStudent typeNotStudent = new TypeNotStudent();
            typeNotStudent.save(txt_typeNotStudentName.Text);
            txt_typeNotStudentName.Clear();
            typeNotStudent.load_dtgdTypeNotStudent(ds, dtgd_typeNotStudent);
        }

        /****************************************************************/
        /*  Author      | Juan Pablo Espinoza                           */
        /*  Description | Mayusculas en la pirmera letra de cada palabra*/
        /*  Date        | 15-02-2018                                    */
        /*  Parameters  | (object sender, EventArgs e                   */
        /****************************************************************/
        private void txt_typeNotStudentName_TextChanged(object sender, EventArgs e)
        {
            txt_typeNotStudentName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_typeNotStudentName.Text);
            txt_typeNotStudentName.SelectionStart = txt_typeNotStudentName.Text.Length;
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar nuevo  tipo usuario                   */
        /*  Date        | 23-02-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_typeUserSave_Click(object sender, EventArgs e)
        {
            TypeUser typeUser = new TypeUser();
            typeUser.save(txt_typeUserName.Text);
            txt_typeUserName.Clear();
            typeUser.load_dtgdTypeUser(ds, dtgd_typeUser);
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /****************************************************************/
        private void txt_typeUserName_TextChanged(object sender, EventArgs e)
        {
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar una carrera                           */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_careerSave_Click(object sender, EventArgs e)
        {
            Career career = new Career();

            if (txt_idCareer.Text == PROPS.EMPTY)
            {
                career.save(txt_careerName.Text, txt_careerKey.Text);
            }
            else
            {
                career.update(Int32.Parse(txt_idCareer.Text), txt_careerName.Text, txt_careerKey.Text);
            }
            txt_idCareer.Clear();
            txt_careerName.Clear();
            txt_careerKey.Clear();
            career.load_dtgdCareer(ds, dtgd_career);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un usuario                            */
        /*  Date        | 23-02-2018                                    */
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
            userCICE.load_dtgdUser(ds, dtgd_user);
        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /****************************************************************/
        private void btn_create_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | El campo solo acepta caracteres númericos     */
        /*  Date        | 23-02-2018                                    */
        /*  Parameters  | object sender, KeyPressEventArgs e            */
        /****************************************************************/
        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dtgd_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("grid", "asd");
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Datos para eliminar y modificar               */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void dtgd_career_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Career career = new Career();
            txt_idCareer.Text = PROPS.EMPTY;
            txt_careerName.Text = PROPS.EMPTY;
            txt_careerKey.Text = PROPS.EMPTY;

            if (this.dtgd_career.Columns[e.ColumnIndex].Name.Equals("delete_carrer"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar la Licenciatura?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    career.delete(Int32.Parse(dtgd_career.CurrentRow.Cells["id_career"].Value.ToString()));
                }
                career.load_dtgdCareer(ds, dtgd_career);
                return;   
            }else if (this.dtgd_career.Columns[e.ColumnIndex].Name.Equals("edit_carrer"))
            {
                txt_idCareer.Text = dtgd_career.CurrentRow.Cells["id_career"].Value.ToString();
                txt_careerName.Text = dtgd_career.CurrentRow.Cells["career_name"].Value.ToString();
                txt_careerKey.Text = dtgd_career.CurrentRow.Cells["career_key"].Value.ToString();
            }
        }
    }
}