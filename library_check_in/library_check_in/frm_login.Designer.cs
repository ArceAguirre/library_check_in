﻿namespace library_check_in
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.img_logoFCFM = new System.Windows.Forms.Panel();
            this.img_logoUANL = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(231, 322);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "Nombre";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(214, 348);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 28;
            this.lbl_password.Text = "Contraseña";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(281, 319);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 29;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(281, 345);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 30;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(281, 371);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 23);
            this.btn_login.TabIndex = 31;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Gotham Bold", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(62, 547);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 78);
            this.textBox1.TabIndex = 34;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::library_check_in.Properties.Resources.bison;
            this.pictureBox4.Location = new System.Drawing.Point(787, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 93);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // img_logoFCFM
            // 
            this.img_logoFCFM.BackColor = System.Drawing.Color.Transparent;
            this.img_logoFCFM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_logoFCFM.BackgroundImage")));
            this.img_logoFCFM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_logoFCFM.Location = new System.Drawing.Point(366, 208);
            this.img_logoFCFM.Name = "img_logoFCFM";
            this.img_logoFCFM.Size = new System.Drawing.Size(80, 80);
            this.img_logoFCFM.TabIndex = 25;
            // 
            // img_logoUANL
            // 
            this.img_logoUANL.BackColor = System.Drawing.Color.Transparent;
            this.img_logoUANL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_logoUANL.BackgroundImage")));
            this.img_logoUANL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_logoUANL.Location = new System.Drawing.Point(172, 208);
            this.img_logoUANL.Name = "img_logoUANL";
            this.img_logoUANL.Size = new System.Drawing.Size(80, 80);
            this.img_logoUANL.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::library_check_in.Properties.Resources.left_box;
            this.pictureBox2.Location = new System.Drawing.Point(49, 533);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 109);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library_check_in.Properties.Resources.left;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 791);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::library_check_in.Properties.Resources.right;
            this.pictureBox3.Location = new System.Drawing.Point(596, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(549, 748);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(679, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 20);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(679, 341);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(368, 20);
            this.textBox3.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(679, 378);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(368, 20);
            this.textBox4.TabIndex = 40;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(679, 418);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(368, 20);
            this.textBox5.TabIndex = 41;
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1136, 826);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.img_logoFCFM);
            this.Controls.Add(this.img_logoUANL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel img_logoFCFM;
        private System.Windows.Forms.Panel img_logoUANL;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

