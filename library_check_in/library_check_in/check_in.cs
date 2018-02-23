﻿using System;
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

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        /****************************************************************/
        /*  Author      |                                               */
        /*  Description |                                               */
        /*  Date        |                                               */
        /*  Parameters  |                                               */
        /*  Reurnt      |                                               */
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
    }
}