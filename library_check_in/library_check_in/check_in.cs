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
        public frm_signIn()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            frm_report frm_reporte = new frm_report();
            frm_reporte.Show();
        }

        private void btn_typeNotStudentSave_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            string[] paramName = new string[20];
            string[] param = new string[20];
            string typeNotStudentName = txt_typeNotStudentName.Text;
            string command = "type_not_student_new @description =  @typeNotStudentName";
            
            paramName[0] = "@typeNotStudentName";
            param[0] = typeNotStudentName;

            System.Data.DataTable dt = con.loadData(command, paramName, param);
            txt_typeNotStudentName.Clear();
        }



        private void txt_typeNotStudentName_TextChanged(object sender, EventArgs e)
        {
            txt_typeNotStudentName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_typeNotStudentName.Text);
            txt_typeNotStudentName.SelectionStart = txt_typeNotStudentName.Text.Length;
        }

        private void btn_typeUserSave_Click(object sender, EventArgs e)
        {

        }

        private void txt_typeUserName_TextChanged(object sender, EventArgs e)
        {

        }

        void upperText(Text)
        {

        }
    }
}
