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
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private void frm_signIn_Load(object sender, EventArgs e)
        {
            // Build the Connection String and create a SQL Connection object
            //String cnnStr = "Data Source = localhost; Initial Catalog = Northwind; Integrated Security = SSPI";
            //SqlConnection cnn = new SqlConnection(cnnStr);
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            // Create a SQL Command object from the connection object and setup the SELECT command
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM type_user";
            // Create the data adapter to use to get the data and handle connecting to the DB
            da = new SqlDataAdapter(cmd);
            // Get the data from the database. I am using the Northwind database the customers table
            da.Fill(ds, "type_user");
            // Disconnect the event handler to handle the comboBox1_SelectedIndexChanged event
            // while the combo box is being populated, otherwise it will fire a couple of times
            // before you are ready to handle them.
            this.cmbbx_typeUser.SelectedIndexChanged -= new System.EventHandler(this.cmbbx_typeUser_SelectedIndexChanged);
            // Connect the cobo box to the data source from where the data is comming from
            // In this case the Customers data table in the dataset.
            cmbbx_typeUser.DataSource = ds.Tables["type_user"];
            // Tell the combo box what collumn to display to the user
            cmbbx_typeUser.DisplayMember = "description";
            // Tell the combo box what collumn to use with the displayed value, value is not displayed
            cmbbx_typeUser.ValueMember = "id";
            // Restored the event handler
            this.cmbbx_typeUser.SelectedIndexChanged += new System.EventHandler(this.cmbbx_typeUser_SelectedIndexChanged);
        }
        public static int indice;
        private void cmbbx_typeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the user clicks on a item in the combo box ist primary key will be displayed.
            //MessageBox.Show("Customer Primary Key is \"" + cmbbx_typeUser.SelectedValue + "\"");
            indice = Int32.Parse(cmbbx_typeUser.SelectedValue.ToString());
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
            var typeUserNew = txt_typeUserName.Text;

            string command = "type_user_new @description = @typeUserNew";
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            var cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@typeUserNew", typeUserNew);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            txt_typeUserName.Clear();
        }
        private void txt_typeUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_careerSave_Click(object sender, EventArgs e)
        {
            string carrerName = txt_careerName.Text;
            string carrerKey = txt_careerKey.Text;
            string command = "career_new @career_name = @carrerName, @career_key = @carrerKey ";
            SqlConnection conn = new SqlConnection(Connection.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@carrerName", carrerName);
            cmd.Parameters.AddWithValue("@carrerKey", carrerKey);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            txt_careerName.Clear();
            txt_careerKey.Clear();
        }
        private void btn_userSave_Click(object sender, EventArgs e)
        {
            var nameUser = txt_nameUser.Text;
            var passwordUser = txt_passwordUser.Text;
            var fatherLastnameUser = txt_fatherLastnameUser.Text;
            var motherLastnameUser = txt_motherLastnameUser.Text;
            var typeUser = indice;

            string command = "user_CICE_new @user_name = @nameUser, @user_password = @passwordUser, @father_last_name = @fatherLastnameUser, @mother_last_name = @motherLastnameUser, @id_type_user = @typeUser ";
            var conn = new SqlConnection(Connection.CONNECTION_STRING);
            var cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@nameUser", nameUser);
            cmd.Parameters.AddWithValue("@passwordUser", passwordUser);
            cmd.Parameters.AddWithValue("@fatherLastnameUser", fatherLastnameUser);
            cmd.Parameters.AddWithValue("@motherLastnameUser", motherLastnameUser);
            cmd.Parameters.AddWithValue("@typeUser", typeUser);
            System.Data.DataTable dt = new System.Data.DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            txt_nameUser.Clear();
            txt_passwordUser.Clear();
            txt_fatherLastnameUser.Clear();
            txt_motherLastnameUser.Clear();
        }

    }
}
