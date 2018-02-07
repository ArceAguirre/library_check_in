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
            this.TxtB_FechaEntrada = new System.Windows.Forms.TextBox();
            this.TxtB_Carrera = new System.Windows.Forms.TextBox();
            this.TxtB_MatriculaOut = new System.Windows.Forms.TextBox();
            this.TxtB_Nombre = new System.Windows.Forms.TextBox();
            this.img_logoUANL = new System.Windows.Forms.Panel();
            this.TxtB_MatriculaIn = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_Bienvenido = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_MatriculaOut = new System.Windows.Forms.Label();
            this.Lbl_MatriculaIn = new System.Windows.Forms.Label();
            this.Lbl_Carrera = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.tbpg_report = new System.Windows.Forms.TabPage();
            this.tbpg_dataUp = new System.Windows.Forms.TabPage();
            this.btn_studentUp = new System.Windows.Forms.Button();
            this.btn_employeeUp = new System.Windows.Forms.Button();
            this.btn_postgraduateUp = new System.Windows.Forms.Button();
            this.btn_guestUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Reporte = new System.Windows.Forms.Label();
            this.lbl_fechadesde = new System.Windows.Forms.Label();
            this.lbl_fechahasta = new System.Windows.Forms.Label();
            this.dttmpk_initialDate = new System.Windows.Forms.DateTimePicker();
            this.dttmpk_finalDate = new System.Windows.Forms.DateTimePicker();
            this.btn_generate = new System.Windows.Forms.Button();
            this.cmbbx_report = new System.Windows.Forms.ComboBox();
            this.cmbbx_carrer = new System.Windows.Forms.ComboBox();
            this.txt_semester = new System.Windows.Forms.TextBox();
            this.lbl_report = new System.Windows.Forms.Label();
            this.lbl_carrer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblctl_signIn.SuspendLayout();
            this.tbpg_signIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbpg_report.SuspendLayout();
            this.tbpg_dataUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblctl_signIn
            // 
            this.tblctl_signIn.Controls.Add(this.tbpg_signIn);
            this.tblctl_signIn.Controls.Add(this.tbpg_report);
            this.tblctl_signIn.Controls.Add(this.tbpg_dataUp);
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
            this.tbpg_signIn.Controls.Add(this.TxtB_FechaEntrada);
            this.tbpg_signIn.Controls.Add(this.TxtB_Carrera);
            this.tbpg_signIn.Controls.Add(this.TxtB_MatriculaOut);
            this.tbpg_signIn.Controls.Add(this.TxtB_Nombre);
            this.tbpg_signIn.Controls.Add(this.img_logoUANL);
            this.tbpg_signIn.Controls.Add(this.TxtB_MatriculaIn);
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
            // TxtB_FechaEntrada
            // 
            this.TxtB_FechaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_FechaEntrada.Location = new System.Drawing.Point(141, 259);
            this.TxtB_FechaEntrada.Name = "TxtB_FechaEntrada";
            this.TxtB_FechaEntrada.PasswordChar = '*';
            this.TxtB_FechaEntrada.Size = new System.Drawing.Size(234, 20);
            this.TxtB_FechaEntrada.TabIndex = 42;
            // 
            // TxtB_Carrera
            // 
            this.TxtB_Carrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_Carrera.Location = new System.Drawing.Point(141, 233);
            this.TxtB_Carrera.Name = "TxtB_Carrera";
            this.TxtB_Carrera.Size = new System.Drawing.Size(234, 20);
            this.TxtB_Carrera.TabIndex = 41;
            // 
            // TxtB_MatriculaOut
            // 
            this.TxtB_MatriculaOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_MatriculaOut.Location = new System.Drawing.Point(141, 207);
            this.TxtB_MatriculaOut.Name = "TxtB_MatriculaOut";
            this.TxtB_MatriculaOut.PasswordChar = '*';
            this.TxtB_MatriculaOut.Size = new System.Drawing.Size(234, 20);
            this.TxtB_MatriculaOut.TabIndex = 40;
            // 
            // TxtB_Nombre
            // 
            this.TxtB_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_Nombre.Location = new System.Drawing.Point(141, 181);
            this.TxtB_Nombre.Name = "TxtB_Nombre";
            this.TxtB_Nombre.Size = new System.Drawing.Size(234, 20);
            this.TxtB_Nombre.TabIndex = 39;
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
            // TxtB_MatriculaIn
            // 
            this.TxtB_MatriculaIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_MatriculaIn.Location = new System.Drawing.Point(141, 132);
            this.TxtB_MatriculaIn.Name = "TxtB_MatriculaIn";
            this.TxtB_MatriculaIn.Size = new System.Drawing.Size(234, 20);
            this.TxtB_MatriculaIn.TabIndex = 31;
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
            this.Lbl_Nombre.Location = new System.Drawing.Point(91, 183);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Nombre.TabIndex = 29;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Lbl_MatriculaOut
            // 
            this.Lbl_MatriculaOut.AutoSize = true;
            this.Lbl_MatriculaOut.Location = new System.Drawing.Point(85, 209);
            this.Lbl_MatriculaOut.Name = "Lbl_MatriculaOut";
            this.Lbl_MatriculaOut.Size = new System.Drawing.Size(50, 13);
            this.Lbl_MatriculaOut.TabIndex = 30;
            this.Lbl_MatriculaOut.Text = "Matricula";
            // 
            // Lbl_MatriculaIn
            // 
            this.Lbl_MatriculaIn.AutoSize = true;
            this.Lbl_MatriculaIn.Location = new System.Drawing.Point(85, 134);
            this.Lbl_MatriculaIn.Name = "Lbl_MatriculaIn";
            this.Lbl_MatriculaIn.Size = new System.Drawing.Size(50, 13);
            this.Lbl_MatriculaIn.TabIndex = 33;
            this.Lbl_MatriculaIn.Text = "Matricula";
            // 
            // Lbl_Carrera
            // 
            this.Lbl_Carrera.AutoSize = true;
            this.Lbl_Carrera.Location = new System.Drawing.Point(94, 235);
            this.Lbl_Carrera.Name = "Lbl_Carrera";
            this.Lbl_Carrera.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Carrera.TabIndex = 31;
            this.Lbl_Carrera.Text = "Carrera";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(44, 261);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(91, 13);
            this.Lbl_Fecha.TabIndex = 32;
            this.Lbl_Fecha.Text = "Fecha de entrada";
            // 
            // tbpg_report
            // 
            this.tbpg_report.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpg_report.Controls.Add(this.label6);
            this.tbpg_report.Controls.Add(this.lbl_carrer);
            this.tbpg_report.Controls.Add(this.lbl_report);
            this.tbpg_report.Controls.Add(this.txt_semester);
            this.tbpg_report.Controls.Add(this.cmbbx_carrer);
            this.tbpg_report.Controls.Add(this.cmbbx_report);
            this.tbpg_report.Controls.Add(this.btn_generate);
            this.tbpg_report.Controls.Add(this.dttmpk_finalDate);
            this.tbpg_report.Controls.Add(this.dttmpk_initialDate);
            this.tbpg_report.Controls.Add(this.lbl_fechahasta);
            this.tbpg_report.Controls.Add(this.lbl_fechadesde);
            this.tbpg_report.Controls.Add(this.lbl_Reporte);
            this.tbpg_report.Location = new System.Drawing.Point(4, 22);
            this.tbpg_report.Name = "tbpg_report";
            this.tbpg_report.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_report.Size = new System.Drawing.Size(448, 324);
            this.tbpg_report.TabIndex = 1;
            this.tbpg_report.Text = "Reportes";
            this.tbpg_report.Click += new System.EventHandler(this.tbpg_report_Click);
            // 
            // tbpg_dataUp
            // 
            this.tbpg_dataUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpg_dataUp.Controls.Add(this.button1);
            this.tbpg_dataUp.Controls.Add(this.label3);
            this.tbpg_dataUp.Controls.Add(this.label2);
            this.tbpg_dataUp.Controls.Add(this.label1);
            this.tbpg_dataUp.Controls.Add(this.button4);
            this.tbpg_dataUp.Controls.Add(this.button3);
            this.tbpg_dataUp.Controls.Add(this.button2);
            this.tbpg_dataUp.Controls.Add(this.btn_guestUp);
            this.tbpg_dataUp.Controls.Add(this.btn_postgraduateUp);
            this.tbpg_dataUp.Controls.Add(this.btn_employeeUp);
            this.tbpg_dataUp.Controls.Add(this.btn_studentUp);
            this.tbpg_dataUp.Location = new System.Drawing.Point(4, 22);
            this.tbpg_dataUp.Name = "tbpg_dataUp";
            this.tbpg_dataUp.Size = new System.Drawing.Size(448, 324);
            this.tbpg_dataUp.TabIndex = 2;
            this.tbpg_dataUp.Text = "Carga de datos";
            // 
            // btn_studentUp
            // 
            this.btn_studentUp.Location = new System.Drawing.Point(62, 124);
            this.btn_studentUp.Name = "btn_studentUp";
            this.btn_studentUp.Size = new System.Drawing.Size(147, 23);
            this.btn_studentUp.TabIndex = 0;
            this.btn_studentUp.Text = "Alumnos";
            this.btn_studentUp.UseVisualStyleBackColor = true;
            // 
            // btn_employeeUp
            // 
            this.btn_employeeUp.Location = new System.Drawing.Point(62, 153);
            this.btn_employeeUp.Name = "btn_employeeUp";
            this.btn_employeeUp.Size = new System.Drawing.Size(147, 23);
            this.btn_employeeUp.TabIndex = 1;
            this.btn_employeeUp.Text = "Empleados";
            this.btn_employeeUp.UseVisualStyleBackColor = true;
            // 
            // btn_postgraduateUp
            // 
            this.btn_postgraduateUp.Location = new System.Drawing.Point(62, 182);
            this.btn_postgraduateUp.Name = "btn_postgraduateUp";
            this.btn_postgraduateUp.Size = new System.Drawing.Size(147, 23);
            this.btn_postgraduateUp.TabIndex = 2;
            this.btn_postgraduateUp.Text = "Postgrado";
            this.btn_postgraduateUp.UseVisualStyleBackColor = true;
            // 
            // btn_guestUp
            // 
            this.btn_guestUp.Location = new System.Drawing.Point(62, 211);
            this.btn_guestUp.Name = "btn_guestUp";
            this.btn_guestUp.Size = new System.Drawing.Size(147, 23);
            this.btn_guestUp.TabIndex = 3;
            this.btn_guestUp.Text = "Invitados";
            this.btn_guestUp.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Empleados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Postgrado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Invitados";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Varios registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Solo un registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Alumnos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Reporte
            // 
            this.lbl_Reporte.AutoSize = true;
            this.lbl_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reporte.Location = new System.Drawing.Point(177, 19);
            this.lbl_Reporte.Name = "lbl_Reporte";
            this.lbl_Reporte.Size = new System.Drawing.Size(111, 31);
            this.lbl_Reporte.TabIndex = 0;
            this.lbl_Reporte.Text = "Reporte";
            // 
            // lbl_fechadesde
            // 
            this.lbl_fechadesde.AutoSize = true;
            this.lbl_fechadesde.Location = new System.Drawing.Point(88, 104);
            this.lbl_fechadesde.Name = "lbl_fechadesde";
            this.lbl_fechadesde.Size = new System.Drawing.Size(24, 13);
            this.lbl_fechadesde.TabIndex = 2;
            this.lbl_fechadesde.Text = "De:";
            // 
            // lbl_fechahasta
            // 
            this.lbl_fechahasta.AutoSize = true;
            this.lbl_fechahasta.Location = new System.Drawing.Point(229, 104);
            this.lbl_fechahasta.Name = "lbl_fechahasta";
            this.lbl_fechahasta.Size = new System.Drawing.Size(17, 13);
            this.lbl_fechahasta.TabIndex = 3;
            this.lbl_fechahasta.Text = "A:";
            // 
            // dttmpk_initialDate
            // 
            this.dttmpk_initialDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpk_initialDate.Location = new System.Drawing.Point(122, 104);
            this.dttmpk_initialDate.Name = "dttmpk_initialDate";
            this.dttmpk_initialDate.Size = new System.Drawing.Size(99, 20);
            this.dttmpk_initialDate.TabIndex = 4;
            // 
            // dttmpk_finalDate
            // 
            this.dttmpk_finalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpk_finalDate.Location = new System.Drawing.Point(252, 104);
            this.dttmpk_finalDate.Name = "dttmpk_finalDate";
            this.dttmpk_finalDate.Size = new System.Drawing.Size(98, 20);
            this.dttmpk_finalDate.TabIndex = 5;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(197, 211);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generar";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // cmbbx_report
            // 
            this.cmbbx_report.FormattingEnabled = true;
            this.cmbbx_report.Location = new System.Drawing.Point(118, 130);
            this.cmbbx_report.Name = "cmbbx_report";
            this.cmbbx_report.Size = new System.Drawing.Size(232, 21);
            this.cmbbx_report.TabIndex = 7;
            // 
            // cmbbx_carrer
            // 
            this.cmbbx_carrer.FormattingEnabled = true;
            this.cmbbx_carrer.Location = new System.Drawing.Point(118, 158);
            this.cmbbx_carrer.Name = "cmbbx_carrer";
            this.cmbbx_carrer.Size = new System.Drawing.Size(232, 21);
            this.cmbbx_carrer.TabIndex = 9;
            // 
            // txt_semester
            // 
            this.txt_semester.Location = new System.Drawing.Point(118, 185);
            this.txt_semester.Name = "txt_semester";
            this.txt_semester.Size = new System.Drawing.Size(100, 20);
            this.txt_semester.TabIndex = 10;
            // 
            // lbl_report
            // 
            this.lbl_report.AutoSize = true;
            this.lbl_report.Location = new System.Drawing.Point(64, 133);
            this.lbl_report.Name = "lbl_report";
            this.lbl_report.Size = new System.Drawing.Size(48, 13);
            this.lbl_report.TabIndex = 11;
            this.lbl_report.Text = "Reporte:";
            // 
            // lbl_carrer
            // 
            this.lbl_carrer.AutoSize = true;
            this.lbl_carrer.Location = new System.Drawing.Point(68, 161);
            this.lbl_carrer.Name = "lbl_carrer";
            this.lbl_carrer.Size = new System.Drawing.Size(44, 13);
            this.lbl_carrer.TabIndex = 12;
            this.lbl_carrer.Text = "Carrera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Semestre:";
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
            this.tbpg_report.ResumeLayout(false);
            this.tbpg_report.PerformLayout();
            this.tbpg_dataUp.ResumeLayout(false);
            this.tbpg_dataUp.PerformLayout();
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
        private System.Windows.Forms.TextBox TxtB_FechaEntrada;
        private System.Windows.Forms.TextBox TxtB_Carrera;
        private System.Windows.Forms.TextBox TxtB_MatriculaOut;
        private System.Windows.Forms.TextBox TxtB_Nombre;
        private System.Windows.Forms.TextBox TxtB_MatriculaIn;
        private System.Windows.Forms.TabPage tbpg_dataUp;
        private System.Windows.Forms.Button btn_guestUp;
        private System.Windows.Forms.Button btn_postgraduateUp;
        private System.Windows.Forms.Button btn_employeeUp;
        private System.Windows.Forms.Button btn_studentUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_semester;
        private System.Windows.Forms.ComboBox cmbbx_carrer;
        private System.Windows.Forms.ComboBox cmbbx_report;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.DateTimePicker dttmpk_finalDate;
        private System.Windows.Forms.DateTimePicker dttmpk_initialDate;
        private System.Windows.Forms.Label lbl_fechahasta;
        private System.Windows.Forms.Label lbl_fechadesde;
        private System.Windows.Forms.Label lbl_Reporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_carrer;
        private System.Windows.Forms.Label lbl_report;
    }
}