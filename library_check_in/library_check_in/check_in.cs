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
            TextBox[] component = { txt_typeNotStudentName, txt_idTypeNotStudent };
            TypeNotStudent typeNotStudent = new TypeNotStudent();
            if (txt_idTypeNotStudent.Text == PROPS.EMPTY)
                typeNotStudent.save(txt_typeNotStudentName.Text);
            else
                typeNotStudent.update(Int32.Parse(txt_idTypeNotStudent.Text), txt_typeNotStudentName.Text);
            PROPS.clear(component);
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
            TextBox[] component = { txt_idTypeUser, txt_typeUserName };
            TypeUser typeUser = new TypeUser();

            if (txt_idTypeUser.Text == PROPS.EMPTY)
                typeUser.save(txt_typeUserName.Text);
            else
                typeUser.update(Int32.Parse(txt_idTypeUser.Text), txt_typeUserName.Text);
            PROPS.clear(component);
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
            TextBox[] component = { txt_idCareer, txt_careerName, txt_careerKey };
            Career career = new Career();
            if (txt_idCareer.Text == PROPS.EMPTY)
                career.save(txt_careerName.Text, txt_careerKey.Text);
            else
                career.update(Int32.Parse(txt_idCareer.Text), txt_careerName.Text, txt_careerKey.Text);
            PROPS.clear(component);
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
            TextBox[] component = { txt_idUser, txt_nameUser, txt_passwordUser, txt_fatherLastnameUser, txt_motherLastnameUser };
            UserCICE userCICE = new UserCICE();
            if (txt_idUser.Text == PROPS.EMPTY)
                userCICE.save(txt_nameUser.Text, txt_passwordUser.Text, txt_fatherLastnameUser.Text, txt_motherLastnameUser.Text, Int32.Parse(cmbbx_typeUser.SelectedValue.ToString()));
            else
                userCICE.update(Int32.Parse(txt_idUser.Text), txt_nameUser.Text, txt_passwordUser.Text, PROPS.EMPTY, txt_fatherLastnameUser.Text, txt_motherLastnameUser.Text, Int32.Parse(cmbbx_typeUser.SelectedValue.ToString()));
            PROPS.clear(component);
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
        /*  Description | Datos para eliminar y modificar               */
        /*  Date        | -02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void dtgd_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] component = { txt_idUser, txt_nameUser, txt_passwordUser, txt_fatherLastnameUser, txt_motherLastnameUser };
            UserCICE userCICE = new UserCICE();
            PROPS.clear(component);
            if (this.dtgd_user.Columns[e.ColumnIndex].Name.Equals("delete_user"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar el Usuario?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    userCICE.delete(Int32.Parse(dtgd_user.CurrentRow.Cells["id_user"].Value.ToString()));
                }
                userCICE.load_dtgdUser(ds, dtgd_user);
                return;
            }
            else if (this.dtgd_user.Columns[e.ColumnIndex].Name.Equals("edit_user"))
            {
                txt_idUser.Text = dtgd_user.CurrentRow.Cells["id_user"].Value.ToString();
                txt_nameUser.Text = dtgd_user.CurrentRow.Cells["name_user"].Value.ToString();
                cmbbx_typeUser.SelectedValue = Int32.Parse(dtgd_user.CurrentRow.Cells["id_type_user"].Value.ToString());
                txt_fatherLastnameUser.Text = dtgd_user.CurrentRow.Cells["fatherLastName_user"].Value.ToString();
                txt_motherLastnameUser.Text = dtgd_user.CurrentRow.Cells["motherLastName_user"].Value.ToString();
            }
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Datos para eliminar y modificar               */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void dtgd_career_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] component = { txt_idCareer, txt_careerName, txt_careerKey };
            Career career = new Career();
            PROPS.clear(component);
            if (this.dtgd_career.Columns[e.ColumnIndex].Name.Equals("delete_carrer"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar la Licenciatura?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    career.delete(Int32.Parse(dtgd_career.CurrentRow.Cells["id_career"].Value.ToString()));
                }
                career.load_dtgdCareer(ds, dtgd_career);
                return;
            }
            else if (this.dtgd_career.Columns[e.ColumnIndex].Name.Equals("edit_carrer"))
            {
                txt_idCareer.Text = dtgd_career.CurrentRow.Cells["id_career"].Value.ToString();
                txt_careerName.Text = dtgd_career.CurrentRow.Cells["career_name"].Value.ToString();
                txt_careerKey.Text = dtgd_career.CurrentRow.Cells["career_key"].Value.ToString();
            }
        }

        private void dtgd_typeNotStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] component = { txt_idTypeNotStudent, txt_typeNotStudentName};
            TypeNotStudent typeNotStudent = new TypeNotStudent();
            PROPS.clear(component);

            if (this.dtgd_typeNotStudent.Columns[e.ColumnIndex].Name.Equals("delete_userNotStudent"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar elTtipo de No Estudiate?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    typeNotStudent.delete(Int32.Parse(dtgd_typeNotStudent.CurrentRow.Cells["id_typeNotStudent"].Value.ToString()));
                }
                typeNotStudent.load_dtgdTypeNotStudent(ds, dtgd_typeNotStudent);
                return;
            }
            else if (this.dtgd_typeNotStudent.Columns[e.ColumnIndex].Name.Equals("edit_typeNotStudent"))
            {
                txt_idTypeNotStudent.Text = dtgd_typeNotStudent.CurrentRow.Cells["id_typeNotStudent"].Value.ToString();
                txt_typeNotStudentName.Text = dtgd_typeNotStudent.CurrentRow.Cells["description_typeNotStudent"].Value.ToString();
            }
        }

        private void dtgd_typeUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] component = { txt_idTypeUser, txt_typeUserName };
            TypeUser typeUser = new TypeUser();
            PROPS.clear(component);

            if (this.dtgd_typeUser.Columns[e.ColumnIndex].Name.Equals("delete_typeUser"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar el Tipo de Usuario?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    typeUser.delete(Int32.Parse(dtgd_typeUser.CurrentRow.Cells["id_typeUser"].Value.ToString()));
                }
                typeUser.load_dtgdTypeUser(ds, dtgd_typeUser);
                    return;
            }
            else if (this.dtgd_typeUser.Columns[e.ColumnIndex].Name.Equals("edit_typeUser"))
            {
                txt_idTypeUser.Text = dtgd_typeUser.CurrentRow.Cells["id_typeUser"].Value.ToString();
                txt_typeUserName.Text = dtgd_typeUser.CurrentRow.Cells["description_typeUser"].Value.ToString();
            }
        }

        private void btn_careerCancel_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idCareer, txt_careerName, txt_careerKey };
            PROPS.clear(component);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_typeNotStudentName, txt_idTypeNotStudent};
            PROPS.clear(component);
        }

        private void btn_typeUserCancel_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idTypeUser, txt_typeUserName };
            PROPS.clear(component);
        }
    }
}