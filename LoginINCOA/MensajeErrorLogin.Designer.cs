﻿namespace LoginINCOA
{
    partial class MensajeErrorLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeErrorLogin));
            this.ContenedorMensaje = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorIMG = new System.Windows.Forms.Panel();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.Separador = new System.Windows.Forms.PictureBox();
            this.IMGError = new System.Windows.Forms.PictureBox();
            this.ContenedorMSJ = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbError1Msj2 = new System.Windows.Forms.Label();
            this.lbError1Msj1 = new System.Windows.Forms.Label();
            this.ConteoRegresivo = new System.Windows.Forms.Timer(this.components);
            this.ContenedorMensaje.SuspendLayout();
            this.ContenedorIMG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGError)).BeginInit();
            this.ContenedorMSJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorMensaje
            // 
            this.ContenedorMensaje.ColumnCount = 1;
            this.ContenedorMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMensaje.Controls.Add(this.ContenedorIMG, 0, 0);
            this.ContenedorMensaje.Controls.Add(this.ContenedorMSJ, 0, 1);
            this.ContenedorMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMensaje.Location = new System.Drawing.Point(0, 0);
            this.ContenedorMensaje.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorMensaje.Name = "ContenedorMensaje";
            this.ContenedorMensaje.RowCount = 2;
            this.ContenedorMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMensaje.Size = new System.Drawing.Size(438, 331);
            this.ContenedorMensaje.TabIndex = 0;
            // 
            // ContenedorIMG
            // 
            this.ContenedorIMG.Controls.Add(this.btnCerrarVentana);
            this.ContenedorIMG.Controls.Add(this.Separador);
            this.ContenedorIMG.Controls.Add(this.IMGError);
            this.ContenedorIMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorIMG.Location = new System.Drawing.Point(0, 0);
            this.ContenedorIMG.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorIMG.Name = "ContenedorIMG";
            this.ContenedorIMG.Size = new System.Drawing.Size(438, 165);
            this.ContenedorIMG.TabIndex = 0;
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(400, 13);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(32, 29);
            this.btnCerrarVentana.TabIndex = 11;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(438, 10);
            this.Separador.TabIndex = 1;
            this.Separador.TabStop = false;
            // 
            // IMGError
            // 
            this.IMGError.Image = ((System.Drawing.Image)(resources.GetObject("IMGError.Image")));
            this.IMGError.Location = new System.Drawing.Point(97, -5);
            this.IMGError.Name = "IMGError";
            this.IMGError.Size = new System.Drawing.Size(234, 174);
            this.IMGError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGError.TabIndex = 0;
            this.IMGError.TabStop = false;
            // 
            // ContenedorMSJ
            // 
            this.ContenedorMSJ.Controls.Add(this.btnAceptar);
            this.ContenedorMSJ.Controls.Add(this.lbError1Msj2);
            this.ContenedorMSJ.Controls.Add(this.lbError1Msj1);
            this.ContenedorMSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMSJ.Location = new System.Drawing.Point(0, 165);
            this.ContenedorMSJ.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorMSJ.Name = "ContenedorMSJ";
            this.ContenedorMSJ.Size = new System.Drawing.Size(438, 166);
            this.ContenedorMSJ.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Kanit ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(168, 99);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 47);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbError1Msj2
            // 
            this.lbError1Msj2.AutoSize = true;
            this.lbError1Msj2.BackColor = System.Drawing.Color.Transparent;
            this.lbError1Msj2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError1Msj2.ForeColor = System.Drawing.Color.White;
            this.lbError1Msj2.Location = new System.Drawing.Point(103, 46);
            this.lbError1Msj2.Name = "lbError1Msj2";
            this.lbError1Msj2.Size = new System.Drawing.Size(246, 29);
            this.lbError1Msj2.TabIndex = 1;
            this.lbError1Msj2.Text = "por favor intente otra vez...";
            // 
            // lbError1Msj1
            // 
            this.lbError1Msj1.AutoSize = true;
            this.lbError1Msj1.BackColor = System.Drawing.Color.Transparent;
            this.lbError1Msj1.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError1Msj1.ForeColor = System.Drawing.Color.White;
            this.lbError1Msj1.Location = new System.Drawing.Point(15, 19);
            this.lbError1Msj1.Name = "lbError1Msj1";
            this.lbError1Msj1.Size = new System.Drawing.Size(408, 29);
            this.lbError1Msj1.TabIndex = 0;
            this.lbError1Msj1.Text = "Lo sentimos, usuario y/o contraseña inválida";
            // 
            // ConteoRegresivo
            // 
            this.ConteoRegresivo.Interval = 1000;
            this.ConteoRegresivo.Tick += new System.EventHandler(this.ConteoRegresivo_Tick);
            // 
            // MensajeErrorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(438, 331);
            this.Controls.Add(this.ContenedorMensaje);
            this.Font = new System.Drawing.Font("Exo 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MensajeErrorLogin";
            this.Text = "g";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MensajeErrorLogin_Load);
            this.ContenedorMensaje.ResumeLayout(false);
            this.ContenedorIMG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGError)).EndInit();
            this.ContenedorMSJ.ResumeLayout(false);
            this.ContenedorMSJ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorMensaje;
        private System.Windows.Forms.Panel ContenedorIMG;
        private System.Windows.Forms.PictureBox Separador;
        private System.Windows.Forms.PictureBox IMGError;
        private System.Windows.Forms.Panel ContenedorMSJ;
        private System.Windows.Forms.Label lbError1Msj2;
        private System.Windows.Forms.Label lbError1Msj1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private System.Windows.Forms.Timer ConteoRegresivo;
    }
}