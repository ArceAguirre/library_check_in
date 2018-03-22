namespace library_check_in
{
    partial class frm_report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptrbx_CICE = new System.Windows.Forms.PictureBox();
            this.lbl_number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbx_CICE)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbx_CICE
            // 
            this.ptrbx_CICE.Image = global::library_check_in.Properties.Resources.left;
            this.ptrbx_CICE.Location = new System.Drawing.Point(12, 12);
            this.ptrbx_CICE.Name = "ptrbx_CICE";
            this.ptrbx_CICE.Size = new System.Drawing.Size(202, 320);
            this.ptrbx_CICE.TabIndex = 35;
            this.ptrbx_CICE.TabStop = false;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_number.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.ForeColor = System.Drawing.Color.Black;
            this.lbl_number.Location = new System.Drawing.Point(25, 25);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(50, 14);
            this.lbl_number.TabIndex = 36;
            this.lbl_number.Text = "Matricula";
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 387);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.ptrbx_CICE);
            this.Name = "frm_report";
            this.Text = "frm_report";
            this.Load += new System.EventHandler(this.frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbx_CICE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrbx_CICE;
        private System.Windows.Forms.Label lbl_number;
    }
}