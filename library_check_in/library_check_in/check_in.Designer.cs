namespace library_check_in
{
    partial class frm_entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_entrada));
            this.tblctl_signIn = new System.Windows.Forms.TabControl();
            this.tbpg_signIn = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.img_logoUANL = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_Bienvenido = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_MatriculaOut = new System.Windows.Forms.Label();
            this.Lbl_MatriculaIn = new System.Windows.Forms.Label();
            this.Lbl_Carrera = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.tbpg_report = new System.Windows.Forms.TabPage();
            this.tblctl_signIn.SuspendLayout();
            this.tbpg_signIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblctl_signIn
            // 
            this.tblctl_signIn.Controls.Add(this.tbpg_signIn);
            this.tblctl_signIn.Controls.Add(this.tbpg_report);
            this.tblctl_signIn.Location = new System.Drawing.Point(12, 12);
            this.tblctl_signIn.Name = "tblctl_signIn";
            this.tblctl_signIn.SelectedIndex = 0;
            this.tblctl_signIn.Size = new System.Drawing.Size(456, 350);
            this.tblctl_signIn.TabIndex = 12;
            this.tblctl_signIn.Tag = "";
            // 
            // tbpg_signIn
            // 
            this.tbpg_signIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpg_signIn.Controls.Add(this.textBox3);
            this.tbpg_signIn.Controls.Add(this.textBox4);
            this.tbpg_signIn.Controls.Add(this.textBox1);
            this.tbpg_signIn.Controls.Add(this.textBox2);
            this.tbpg_signIn.Controls.Add(this.img_logoUANL);
            this.tbpg_signIn.Controls.Add(this.txt_name);
            this.tbpg_signIn.Controls.Add(this.pictureBox2);
            this.tbpg_signIn.Controls.Add(this.Lbl_Bienvenido);
            this.tbpg_signIn.Controls.Add(this.Lbl_Nombre);
            this.tbpg_signIn.Controls.Add(this.Lbl_MatriculaOut);
            this.tbpg_signIn.Controls.Add(this.Lbl_MatriculaIn);
            this.tbpg_signIn.Controls.Add(this.Lbl_Carrera);
            this.tbpg_signIn.Controls.Add(this.Lbl_Fecha);
            this.tbpg_signIn.Location = new System.Drawing.Point(4, 22);
            this.tbpg_signIn.Name = "tbpg_signIn";
            this.tbpg_signIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_signIn.Size = new System.Drawing.Size(448, 324);
            this.tbpg_signIn.TabIndex = 0;
            this.tbpg_signIn.Text = "Registro";
            this.tbpg_signIn.Click += new System.EventHandler(this.tbpg_signIn_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(112, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(234, 20);
            this.textBox3.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(112, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 20);
            this.textBox4.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(112, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(112, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 39;
            // 
            // img_logoUANL
            // 
            this.img_logoUANL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_logoUANL.BackgroundImage")));
            this.img_logoUANL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_logoUANL.Location = new System.Drawing.Point(6, 6);
            this.img_logoUANL.Name = "img_logoUANL";
            this.img_logoUANL.Size = new System.Drawing.Size(100, 100);
            this.img_logoUANL.TabIndex = 38;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(112, 142);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(234, 20);
            this.txt_name.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(338, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_Bienvenido
            // 
            this.Lbl_Bienvenido.AutoSize = true;
            this.Lbl_Bienvenido.Location = new System.Drawing.Point(188, 67);
            this.Lbl_Bienvenido.Name = "Lbl_Bienvenido";
            this.Lbl_Bienvenido.Size = new System.Drawing.Size(60, 13);
            this.Lbl_Bienvenido.TabIndex = 28;
            this.Lbl_Bienvenido.Text = "Bienvenido";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(62, 180);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Nombre.TabIndex = 29;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Lbl_MatriculaOut
            // 
            this.Lbl_MatriculaOut.AutoSize = true;
            this.Lbl_MatriculaOut.Location = new System.Drawing.Point(56, 206);
            this.Lbl_MatriculaOut.Name = "Lbl_MatriculaOut";
            this.Lbl_MatriculaOut.Size = new System.Drawing.Size(50, 13);
            this.Lbl_MatriculaOut.TabIndex = 30;
            this.Lbl_MatriculaOut.Text = "Matricula";
            // 
            // Lbl_MatriculaIn
            // 
            this.Lbl_MatriculaIn.AutoSize = true;
            this.Lbl_MatriculaIn.Location = new System.Drawing.Point(56, 144);
            this.Lbl_MatriculaIn.Name = "Lbl_MatriculaIn";
            this.Lbl_MatriculaIn.Size = new System.Drawing.Size(50, 13);
            this.Lbl_MatriculaIn.TabIndex = 33;
            this.Lbl_MatriculaIn.Text = "Matricula";
            // 
            // Lbl_Carrera
            // 
            this.Lbl_Carrera.AutoSize = true;
            this.Lbl_Carrera.Location = new System.Drawing.Point(65, 232);
            this.Lbl_Carrera.Name = "Lbl_Carrera";
            this.Lbl_Carrera.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Carrera.TabIndex = 31;
            this.Lbl_Carrera.Text = "Carrera";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(15, 258);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(91, 13);
            this.Lbl_Fecha.TabIndex = 32;
            this.Lbl_Fecha.Text = "Fecha de entrada";
            // 
            // tbpg_report
            // 
            this.tbpg_report.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpg_report.Location = new System.Drawing.Point(4, 22);
            this.tbpg_report.Name = "tbpg_report";
            this.tbpg_report.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_report.Size = new System.Drawing.Size(663, 324);
            this.tbpg_report.TabIndex = 1;
            this.tbpg_report.Text = "Reportes";
            this.tbpg_report.Click += new System.EventHandler(this.tbpg_report_Click);
            // 
            // frm_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 370);
            this.Controls.Add(this.tblctl_signIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_entrada";
            this.Text = "Entrada en CICE";
            this.tblctl_signIn.ResumeLayout(false);
            this.tbpg_signIn.ResumeLayout(false);
            this.tbpg_signIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tblctl_signIn;
        private System.Windows.Forms.TabPage tbpg_signIn;
        private System.Windows.Forms.TabPage tbpg_report;
        private System.Windows.Forms.Panel img_logoUANL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_Bienvenido;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_MatriculaOut;
        private System.Windows.Forms.Label Lbl_MatriculaIn;
        private System.Windows.Forms.Label Lbl_Carrera;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_name;
    }
}