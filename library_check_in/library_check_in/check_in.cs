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
using library_check_in.Not_student;

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
            Student.Student student = new Student.Student();
            /*Combobox*/
            typeUser.load_cmbbxTypeUser(ds, cmbbx_typeUser);
            typeNotStudent.load_cmbbxReport(ds, cmbbx_report);
            typeNotStudent.load_cmbbxReport(ds, cmbbx_type);
            typeNotStudent.load_cmbbxReport(ds, cmbbx_typeRegister);
            career.load_cmbbxCarrer(ds, cmbbx_carrer);
            career.load_cmbbxCarrer(ds, cmbbox_careerStudent);
            DataTable dt = cmbbx_typeRegister.DataSource as DataTable;
            DataRow row = dt.NewRow();
            row["description_typeNotStudent"] = "Alumno";
            dt.Rows.Add(row);
            cmbbx_typeRegister.SelectedIndex = cmbbx_typeRegister.Items.Count - 1;
            /*Grid*/
            career.load_dtgdCareer(ds, dtgd_career);
            typeNotStudent.load_dtgdTypeNotStudent(ds, dtgd_typeNotStudent);
            typeUser.load_dtgdTypeUser(ds, dtgd_typeUser);
            userCICE.load_dtgdUser(ds, dtgd_user);
            student.load_dtgdStudent(ds, dtgd_student);

            /*DataBase*/
            DataBaseSettings dataBaseSettings = new DataBaseSettings();
            btn_create.Enabled = dataBaseSettings.ifExist().Rows.Count == 0 ? true : false;
            btn_drop.Enabled = !btn_create.Enabled;
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
        /*  Author      | Juan Pablo Espinoza                           */
        /*  Description | Agregar un estudiante                         */
        /*  Date        | 08-03-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_add_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idStudent, txt_numberStudent, txt_nameStudent, txt_fatherLasnameStudent, txt_motherLasnameStudent, txt_semesterStudent, };
           
            if (cmbbx_typeRegister.Items.Count != cmbbx_typeRegister.SelectedIndex + 1 && cmbbx_typeRegister.SelectedValue is int)
            {
                NotStudent notStudent = new NotStudent();
                if (txt_idStudent.Text == PROPS.EMPTY)
                    notStudent.save(txt_numberStudent.Text, txt_nameStudent.Text, txt_fatherLasnameStudent.Text, txt_motherLasnameStudent.Text,Int32.Parse(cmbbx_typeRegister.SelectedValue.ToString()));
                else
                    notStudent.update(Int32.Parse(txt_idStudent.Text), txt_numberStudent.Text, txt_nameStudent.Text, txt_fatherLasnameStudent.Text, txt_motherLasnameStudent.Text, Int32.Parse(cmbbx_typeRegister.SelectedValue.ToString()));
                notStudent.load_dtgdStudent(ds, dtgd_student, cmbbx_typeRegister);
            }
            else
            {
                Student.Student student = new Student.Student();
                if (txt_idStudent.Text == PROPS.EMPTY)
                    student.save(txt_numberStudent.Text, txt_nameStudent.Text, txt_fatherLasnameStudent.Text, txt_motherLasnameStudent.Text, txt_semesterStudent.Text, Int32.Parse(cmbbox_careerStudent.SelectedValue.ToString()));
                else
                    student.update(Int32.Parse(txt_idStudent.Text), txt_numberStudent.Text, txt_nameStudent.Text, txt_fatherLasnameStudent.Text, txt_motherLasnameStudent.Text, txt_semesterStudent.Text, Int32.Parse(cmbbox_careerStudent.SelectedValue.ToString()));
                student.load_dtgdStudent(ds, dtgd_student);
            }
            PROPS.clear(component);
        }
        
        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Datos para eliminar y modificar usuarios      */
        /*  Date        | 28-02-2018                                    */
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
        /*  Description | Datos para eliminar y modificar carreras      */
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

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Datos para eliminar y modificar typos de no   */
        /*                estudiantes                                   */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void dtgd_typeNotStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] component = { txt_idTypeNotStudent, txt_typeNotStudentName};
            TypeNotStudent typeNotStudent = new TypeNotStudent();
            PROPS.clear(component);

            if (this.dtgd_typeNotStudent.Columns[e.ColumnIndex].Name.Equals("delete_userNotStudent"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar el Tipo de No Estudiate?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Datos para eliminar y modificar Tipo Usuario  */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
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

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Limpiar campos de Licenciatura                */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void btn_careerCancel_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idCareer, txt_careerName, txt_careerKey };
            PROPS.clear(component);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Limpiar campos de tipos de no estudiantes     */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void btn_typeNotStudentCancel_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_typeNotStudentName, txt_idTypeNotStudent };
            PROPS.clear(component);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Limpiar campos de Tipos de Usuarios           */
        /*  Date        | 27-02-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void btn_typeUserCancel_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idTypeUser, txt_typeUserName };
            PROPS.clear(component);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Limpiar campos de Usuarios                    */
        /*  Date        | 01-03-2018                                    */
        /*  Parameters  | object sender, DataGridViewCellEventArgs e    */
        /****************************************************************/
        private void btn_userCancel_Click(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idUser, txt_nameUser, txt_passwordUser, txt_fatherLastnameUser, txt_motherLastnameUser };
            PROPS.clear(component);
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Crear la Base de Datos                        */
        /*  Date        | 01-03-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_create_Click(object sender, EventArgs e)
        {
            DataBaseSettings dataBaseSettings = new DataBaseSettings();
            dataBaseSettings.createDataBase();
            btn_create.Enabled = dataBaseSettings.ifExist().Rows.Count == 0 ? true : false;
            btn_drop.Enabled = !btn_create.Enabled;
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Agregar un usuario                            */
        /*  Date        | 23-02-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void btn_drop_Click(object sender, EventArgs e)
        {
            DataBaseSettings dataBaseSettings = new DataBaseSettings();
            dataBaseSettings.deleteDataBase();
            btn_create.Enabled = dataBaseSettings.ifExist().Rows.Count == 0 ? true : false;
            btn_drop.Enabled = !btn_create.Enabled;
        }

        private void btn_seeder_Click(object sender, EventArgs e)
        {

        }

        /****************************************************************/
        /*  Author      | Juan Pablo Espiniza                           */
        /*  Description | Eliminar estudiante                           */
        /*  Date        | 08-03-2018                                    */
        /*  Parameters  | object sender, EventArgs e                    */
        /****************************************************************/
        private void dtgd_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] component = { txt_idStudent, txt_numberStudent, txt_nameStudent, txt_fatherLasnameStudent, txt_motherLasnameStudent, txt_semesterStudent };
            Student.Student student = new Student.Student();
            PROPS.clear(component);
            if (this.dtgd_student.Columns[e.ColumnIndex].Name.Equals("delete_student"))
            {
                if (MessageBox.Show("¿Seguro que quieres borrar el Estudiante?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    student.delete(Int32.Parse(dtgd_student.CurrentRow.Cells["id_student"].Value.ToString()));
                }
                student.load_dtgdStudent(ds, dtgd_student);
                return;
            }
            else if (this.dtgd_student.Columns[e.ColumnIndex].Name.Equals("edit_student"))
            {
                if (cmbbx_typeRegister.Items.Count != cmbbx_typeRegister.SelectedIndex + 1 && cmbbx_typeRegister.SelectedValue is int)
                {
                    txt_semesterStudent.Enabled = false;
                    cmbbox_careerStudent.Enabled = false;
                    txt_idStudent.Text = dtgd_student.CurrentRow.Cells["id_student"].Value.ToString();
                    txt_numberStudent.Text = dtgd_student.CurrentRow.Cells["number"].Value.ToString();
                    txt_nameStudent.Text = dtgd_student.CurrentRow.Cells["name"].Value.ToString();
                    txt_fatherLasnameStudent.Text = dtgd_student.CurrentRow.Cells["father_last_name"].Value.ToString();
                    txt_motherLasnameStudent.Text = dtgd_student.CurrentRow.Cells["mother_last_name"].Value.ToString();
                    cmbbox_careerStudent.SelectedValue = 0;
                }
                else
                {
                    txt_semesterStudent.Enabled = true;
                    cmbbox_careerStudent.Enabled = true;
                    txt_idStudent.Text = dtgd_student.CurrentRow.Cells["id_student"].Value.ToString();
                    txt_numberStudent.Text = dtgd_student.CurrentRow.Cells["number"].Value.ToString();
                    txt_nameStudent.Text = dtgd_student.CurrentRow.Cells["student_name"].Value.ToString();
                    txt_fatherLasnameStudent.Text = dtgd_student.CurrentRow.Cells["student_father_last_name"].Value.ToString();
                    txt_motherLasnameStudent.Text = dtgd_student.CurrentRow.Cells["student_mother_last_name"].Value.ToString();
                    txt_semesterStudent.Text = dtgd_student.CurrentRow.Cells["semester"].Value.ToString();
                    cmbbox_careerStudent.SelectedValue = Int32.Parse(dtgd_student.CurrentRow.Cells["id_career"].Value.ToString());
                }
            }
                
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   09-03-2018                      */
        /*  Description |   Función para cerrar el form     */
        /*  Parameteres |   object sender, EventArgs e      */
        /****************************************************/
        private void cbtn_closeCheck_Click(object sender, EventArgs e)
        {
            Close();
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   09-03-2018                      */
        /*  Description |   Función al cambiar el combobox  */
        /*  Parameteres |   object sender, EventArgs e      */
        /****************************************************/
        private void cmbbx_typeRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] component = { txt_idStudent, txt_numberStudent, txt_nameStudent, txt_fatherLasnameStudent, txt_motherLasnameStudent, txt_semesterStudent };
            PROPS.clear(component);
            if(cmbbox_careerStudent.Items.Count > 0)
            {
                cmbbox_careerStudent.SelectedIndex = 0;
            }
            if (cmbbx_typeRegister.Items.Count != cmbbx_typeRegister.SelectedIndex + 1 && cmbbx_typeRegister.SelectedValue is int)
            {
                txt_semesterStudent.Enabled = false;
                cmbbox_careerStudent.Enabled = false;
                NotStudent notStudent = new NotStudent();
                notStudent.load_dtgdStudent(ds, dtgd_student, cmbbx_typeRegister);
            }
            else
            {
                txt_semesterStudent.Enabled = true;
                cmbbox_careerStudent.Enabled = true;
                Student.Student student = new Student.Student();
                student.load_dtgdStudent(ds, dtgd_student);
            }
        }

        /****************************************************/
        /*  Author      |   Juan Pablo Espinoza             */
        /*  Date        |   13-03-2018                      */
        /*  Description |   Bontón de Ayuda                 */
        /*  Parameteres |   object sender, EventArgs e      */
        /****************************************************/
        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacta a este correo: arce.aguirre.trevino@gmail.com ", "Ayuda");
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   21-03-2018                      */
        /*  Description |   Acceder a la biblioteca         */
        /*  Parameteres |   object sender, EventArgs e      */
        /****************************************************/
        private void txt_number_Enter(object sender, EventArgs e)
        {
            //TextBox[] component = { txt_number, txt_name, txt_numberData, txt_career, txt_signInDate };
            //Access.Access access = new Access.Access();
            //access.save(txt_number.Text, txt_number.Text);
            //PROPS.clear(component);
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   21-03-2018                      */
        /*  Description |   Acceder a la biblioteca         */
        /*  Parameteres |   object sender, EventArgs e      */
        /****************************************************/

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        private void txt_number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_number.TextLength == 7)
                {
                    TextBox[] component = { txt_number, txt_name, txt_numberData, txt_career, txt_signInDate };
                    Access.Access access = new Access.Access();
                    DataTable dt = access.save(txt_number.Text, txt_number.Text);
                    try
                    {
                        txt_numberData.Text = dt.Rows[0]["number"].ToString();
                        txt_number.Text = dt.Rows[0]["number"].ToString();
                        txt_name.Text = dt.Rows[0]["student_name"].ToString() + " " + dt.Rows[0]["student_father_last_name"].ToString() + " " + dt.Rows[0]["student_mother_last_name"].ToString();
                        string semestre = dt.Rows[0]["semester"].ToString();
                        txt_career.Text = dt.Rows[0]["career_name"].ToString();
                        txt_signInDate.Text = dt.Rows[0]["signInDate"].ToString();
                    }
                    catch (Exception ex)
                    {
                        txt_numberData.Text = dt.Rows[0]["number"].ToString();
                        txt_number.Text = dt.Rows[0]["number"].ToString();
                        txt_name.Text = dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["father_last_name"].ToString() + " " + dt.Rows[0]["mother_last_name"].ToString();
                        string semestre = dt.Rows[0]["semester"].ToString();
                        txt_career.Text = dt.Rows[0]["description"].ToString();
                        txt_signInDate.Text = dt.Rows[0]["signInDate"].ToString();
                    }

                    myTimer.Tick += new EventHandler(TimerEventProcessor);
                    myTimer.Interval = 2000;
                    myTimer.Start();

                    if (exitFlag)
                    {
                        PROPS.clear(component);
                    }
                   
                }
            }
                
        }

        private static void TimerEventProcessor(Object myObject,
                                           EventArgs myEventArgs)
        {
            myTimer.Stop();

            if(MessageBox.Show("Continue running?", "Count is: " + alarmCounter, MessageBoxButtons.YesNo) == DialogResult.Yes){

            }
                //// Displays a message box asking whether to continue running the timer.
                //if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
                //   MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    // Restarts the timer and increments the counter.
                //    alarmCounter += 1;
                //    myTimer.Enabled = true;
                //}
                //else
                //{
                // Stops the timer.
                exitFlag = true;
            //}
        }

    }
}