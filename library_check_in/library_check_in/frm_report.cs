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
    public partial class frm_report : Form
    {
        public frm_report()
        {
            InitializeComponent();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            var pos = this.PointToScreen(lbl_number.Location);
            pos = ptrbx_CICE.PointToClient(pos);
            lbl_number.Parent = ptrbx_CICE;
            lbl_number.Location = pos;
            lbl_number.BackColor = Color.Transparent;
        }
    }
}
