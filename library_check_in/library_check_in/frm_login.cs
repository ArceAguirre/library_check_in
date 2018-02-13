using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            var user = txt_name.Text;
            var pass = txt_password.Text;

            string command = "select id_type_user from user_CICE where user_name = @user and user_password = @password";
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            var cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", pass);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
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
