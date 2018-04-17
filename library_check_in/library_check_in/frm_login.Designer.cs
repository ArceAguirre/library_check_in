namespace library_check_in
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
            this.btn_login = new System.Windows.Forms.Button();
            this.img_logoFCFM = new System.Windows.Forms.Panel();
            this.img_logoUANL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbtn_closeLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lbl_name.Location = new System.Drawing.Point(494, 204);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "Nombre";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lbl_password.Location = new System.Drawing.Point(477, 230);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 28;
            this.lbl_password.Text = "Contraseña";
            // 
            // txt_name
            // 
            this.txt_name.AccessibleName = "Nombre de Usuario";
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_name.Location = new System.Drawing.Point(81, 430);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 29);
            this.txt_name.TabIndex = 29;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            this.txt_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyUp);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btn_login.Location = new System.Drawing.Point(81, 498);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 39);
            this.btn_login.TabIndex = 31;
            this.btn_login.Text = "INGRESAR";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // img_logoFCFM
            // 
            this.img_logoFCFM.BackColor = System.Drawing.Color.Transparent;
            this.img_logoFCFM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_logoFCFM.BackgroundImage")));
            this.img_logoFCFM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_logoFCFM.Location = new System.Drawing.Point(497, 104);
            this.img_logoFCFM.Name = "img_logoFCFM";
            this.img_logoFCFM.Size = new System.Drawing.Size(80, 80);
            this.img_logoFCFM.TabIndex = 25;
            // 
            // img_logoUANL
            // 
            this.img_logoUANL.BackColor = System.Drawing.Color.Transparent;
            this.img_logoUANL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_logoUANL.BackgroundImage")));
            this.img_logoUANL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_logoUANL.Location = new System.Drawing.Point(411, 104);
            this.img_logoUANL.Name = "img_logoUANL";
            this.img_logoUANL.Size = new System.Drawing.Size(80, 80);
            this.img_logoUANL.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 747);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.AccessibleName = "Contraseña de Usuario";
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.Location = new System.Drawing.Point(81, 464);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(200, 29);
            this.txt_password.TabIndex = 30;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            this.txt_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyUp);
            // 
            // cbtn_closeLogin
            // 
            this.cbtn_closeLogin.BackColor = System.Drawing.Color.Maroon;
            this.cbtn_closeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtn_closeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn_closeLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbtn_closeLogin.Location = new System.Drawing.Point(325, 12);
            this.cbtn_closeLogin.Name = "cbtn_closeLogin";
            this.cbtn_closeLogin.Size = new System.Drawing.Size(27, 23);
            this.cbtn_closeLogin.TabIndex = 33;
            this.cbtn_closeLogin.Text = "X";
            this.cbtn_closeLogin.UseVisualStyleBackColor = false;
            this.cbtn_closeLogin.Click += new System.EventHandler(this.cbtn_closeLogin_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(364, 742);
            this.Controls.Add(this.cbtn_closeLogin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.img_logoFCFM);
            this.Controls.Add(this.img_logoUANL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel img_logoFCFM;
        private System.Windows.Forms.Panel img_logoUANL;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button cbtn_closeLogin;
    }
}

