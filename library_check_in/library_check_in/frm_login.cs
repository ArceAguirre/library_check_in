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
    }
}
