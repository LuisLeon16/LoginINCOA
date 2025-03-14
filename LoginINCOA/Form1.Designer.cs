namespace LoginINCOA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CajaUsuariosLogin = new System.Windows.Forms.TextBox();
            this.textoIniciarSesion = new System.Windows.Forms.Label();
            this.LogoLogin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textoContrasena = new System.Windows.Forms.Label();
            this.PassLogin = new System.Windows.Forms.TextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgPass = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(807, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 654);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // CajaUsuariosLogin
            // 
            this.CajaUsuariosLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CajaUsuariosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CajaUsuariosLogin.ForeColor = System.Drawing.Color.LightGray;
            this.CajaUsuariosLogin.Location = new System.Drawing.Point(365, 353);
            this.CajaUsuariosLogin.Multiline = true;
            this.CajaUsuariosLogin.Name = "CajaUsuariosLogin";
            this.CajaUsuariosLogin.Size = new System.Drawing.Size(441, 35);
            this.CajaUsuariosLogin.TabIndex = 0;
            this.CajaUsuariosLogin.Text = "Ingrese su usuario...";
            this.CajaUsuariosLogin.Enter += new System.EventHandler(this.CajaUsuariosLogin_Enter);
            this.CajaUsuariosLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CajaUsuariosLogin_KeyDown);
            this.CajaUsuariosLogin.Leave += new System.EventHandler(this.CajaUsuariosLogin_Leave);
            // 
            // textoIniciarSesion
            // 
            this.textoIniciarSesion.AutoSize = true;
            this.textoIniciarSesion.BackColor = System.Drawing.SystemColors.Control;
            this.textoIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textoIniciarSesion.Location = new System.Drawing.Point(522, 302);
            this.textoIniciarSesion.Name = "textoIniciarSesion";
            this.textoIniciarSesion.Size = new System.Drawing.Size(126, 29);
            this.textoIniciarSesion.TabIndex = 2;
            this.textoIniciarSesion.Text = "USUARIO:";
            // 
            // LogoLogin
            // 
            this.LogoLogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("LogoLogin.Image")));
            this.LogoLogin.Location = new System.Drawing.Point(306, -29);
            this.LogoLogin.Name = "LogoLogin";
            this.LogoLogin.Size = new System.Drawing.Size(497, 300);
            this.LogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoLogin.TabIndex = 6;
            this.LogoLogin.TabStop = false;
            this.LogoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(365, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 5);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(365, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 5);
            this.panel3.TabIndex = 15;
            // 
            // textoContrasena
            // 
            this.textoContrasena.AutoSize = true;
            this.textoContrasena.BackColor = System.Drawing.SystemColors.Control;
            this.textoContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textoContrasena.Location = new System.Drawing.Point(498, 423);
            this.textoContrasena.Name = "textoContrasena";
            this.textoContrasena.Size = new System.Drawing.Size(186, 29);
            this.textoContrasena.TabIndex = 13;
            this.textoContrasena.Text = "CONTRASEÑA:";
            // 
            // PassLogin
            // 
            this.PassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PassLogin.ForeColor = System.Drawing.Color.LightGray;
            this.PassLogin.Location = new System.Drawing.Point(365, 467);
            this.PassLogin.Multiline = true;
            this.PassLogin.Name = "PassLogin";
            this.PassLogin.PasswordChar = '*';
            this.PassLogin.Size = new System.Drawing.Size(441, 35);
            this.PassLogin.TabIndex = 1;
            this.PassLogin.Text = "password";
            this.PassLogin.Enter += new System.EventHandler(this.PassLogin_Enter);
            this.PassLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassLogin_KeyDown);
            this.PassLogin.Leave += new System.EventHandler(this.PassLogin_Leave);
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(270, 322);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(77, 79);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 16;
            this.imgUser.TabStop = false;
            // 
            // imgPass
            // 
            this.imgPass.Image = ((System.Drawing.Image)(resources.GetObject("imgPass.Image")));
            this.imgPass.Location = new System.Drawing.Point(270, 431);
            this.imgPass.Name = "imgPass";
            this.imgPass.Size = new System.Drawing.Size(77, 79);
            this.imgPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPass.TabIndex = 17;
            this.imgPass.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(475, 556);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(200, 40);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "INGRESAR";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.imgPass);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textoContrasena);
            this.Controls.Add(this.PassLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LogoLogin);
            this.Controls.Add(this.textoIniciarSesion);
            this.Controls.Add(this.CajaUsuariosLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox CajaUsuariosLogin;
        private System.Windows.Forms.Label textoIniciarSesion;
        private System.Windows.Forms.PictureBox LogoLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label textoContrasena;
        private System.Windows.Forms.TextBox PassLogin;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgPass;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}

