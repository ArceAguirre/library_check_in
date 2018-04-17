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
/**
 *  Author      | Arcelia Aguirre
 *  Date        | 02-02-2018
 *  Description | Pantalla de login
 */
namespace library_check_in{
    public partial class frm_login : Form
    {
        /**
         *  Author      | Arcelia Aguirre 
         *  Date        | 09-03-2018
         *  Description | Constructor del form
         */
        public frm_login()
        {
            InitializeComponent();
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 09-03-2018
         *  Description | Funcion al iniciar sesion
         *  Parameteres | object sender, EventArgs e
         */
        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 09-03-2018
         *  Description | Funcion al iniciar sesion
         */
        private void Login()
        {
            DataTable dt = new DataTable();
            UserCICE userCICE = new UserCICE();

            /*Validación*/
            TextBox[] component = { txt_name, txt_password };
            if (!PROPS.emptyTextBox(component))
                return;

            //dt =  userCICE.login(txt_name.Text, txt_password.Text);
            //if (dt != null)
            //{
            //    if (dt.Rows.Count == 0)
            //        MessageBox.Show("Usuario o Password Incorrectos");
            //    else
            //    {
            //        frm_signIn frm_checkIn = new frm_signIn();
            //        frm_checkIn.Show();
            //    }
            //}
            /*Quitar*/
            frm_signIn frm_checkIn2 = new frm_signIn();
            frm_checkIn2.Show();
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 28-02-2018
         *  Description | Funcion al inicar la pantalla
         *  Parameteres | object sender, EventArgs e
         */
        private void frm_login_Load(object sender, EventArgs e)
        {
            this.txt_name.Text = "Usuario";
            this.txt_password.Text = "password";
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 28-02-2018
         *  Description | Placeholder
         *  Parameteres | object sender, KeyPressEventArgs e             
         */
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(this.txt_name.Text == "Usuario")
            //    this.txt_name.Text = "";
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 28-02-2018
         *  Description | Placeholder
         *  Parameteres | object sender, KeyEventArgs e   
         */
        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            //if (this.txt_name.Text == "")
            //    this.txt_name.Text = "Usuario";
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 28-02-2018
         *  Description | Placeholder
         *  Parameteres | object sender, KeyEventArgs e
         */
        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (this.txt_password.Text == "password")
            //    this.txt_password.Text = "";
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 28-02-2018
         *  Description | Placeholder
         *  Parameteres | object sender, KeyEventArgs e
         */
        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            //if (this.txt_password.Text == "")
            //    this.txt_password.Text = "password";
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Date        | 09-03-2018
         *  Description | Función para cerrar el form
         *  Parameteres | object sender, EventArgs e
         */
        private void cbtn_closeLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}