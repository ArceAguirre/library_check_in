using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
