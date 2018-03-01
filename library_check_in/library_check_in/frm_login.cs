using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using library_check_in.User_CICE;

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Pantalla de login               */
/****************************************************/
namespace library_check_in{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            DataTable dt = new DataTable();
            UserCICE userCICE = new UserCICE();

            dt =  userCICE.login(txt_name.Text, txt_password.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o Password Incorrectos");
            }
            else
            {
                frm_signIn frm_checkIn = new frm_signIn();
                frm_checkIn.Show();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.txt_name.Text = "Usuario";
            this.txt_password.Text = "password";
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   28-02-2018                      */
        /*  Description |   Placeholder                     */
        /****************************************************/
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.txt_name.Text == "Usuario"){
                this.txt_name.Text = "";
            }
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   28-02-2018                      */
        /*  Description |   Placeholder                     */
        /****************************************************/
        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txt_name.Text == "")
            {
                this.txt_name.Text = "Usuario";
            }
        }

        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   28-02-2018                      */
        /*  Description |   Placeholder                     */
        /****************************************************/
        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txt_password.Text == "password")
            {
                this.txt_password.Text = "";
            }
        }
        /****************************************************/
        /*  Author      |   Arcelia Aguirre                 */
        /*  Date        |   28-02-2018                      */
        /*  Description |   Placeholder                     */
        /****************************************************/
        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txt_password.Text == "")
            {
                this.txt_password.Text = "Usuario";
            }
        }
    }
}
