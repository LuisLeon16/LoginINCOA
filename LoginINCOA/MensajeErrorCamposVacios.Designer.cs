﻿namespace LoginINCOA
{
    partial class MensajeErrorCamposVacios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeErrorCamposVacios));
            this.ConteoRegresivo = new System.Windows.Forms.Timer(this.components);
            this.ContenedorIMG = new System.Windows.Forms.Panel();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.Separador = new System.Windows.Forms.PictureBox();
            this.IMGError = new System.Windows.Forms.PictureBox();
            this.ContenedorMSJ = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ContenedorIMG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGError)).BeginInit();
            this.ContenedorMSJ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConteoRegresivo
            // 
            this.ConteoRegresivo.Interval = 1000;
            this.ConteoRegresivo.Tick += new System.EventHandler(this.ConteoRegresivo_Tick);
            // 
            // ContenedorIMG
            // 
            this.ContenedorIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ContenedorIMG.Controls.Add(this.btnCerrarVentana);
            this.ContenedorIMG.Controls.Add(this.Separador);
            this.ContenedorIMG.Controls.Add(this.IMGError);
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
            this.btnCerrarVentana.Location = new System.Drawing.Point(398, 11);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(32, 29);
            this.btnCerrarVentana.TabIndex = 13;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(438, 10);
            this.Separador.TabIndex = 3;
            this.Separador.TabStop = false;
            // 
            // IMGError
            // 
            this.IMGError.Image = ((System.Drawing.Image)(resources.GetObject("IMGError.Image")));
            this.IMGError.Location = new System.Drawing.Point(100, 13);
            this.IMGError.Name = "IMGError";
            this.IMGError.Size = new System.Drawing.Size(229, 154);
            this.IMGError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGError.TabIndex = 0;
            this.IMGError.TabStop = false;
            // 
            // ContenedorMSJ
            // 
            this.ContenedorMSJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ContenedorMSJ.ColumnCount = 1;
            this.ContenedorMSJ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMSJ.Controls.Add(this.ContenedorIMG, 0, 0);
            this.ContenedorMSJ.Controls.Add(this.panel1, 0, 1);
            this.ContenedorMSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMSJ.Location = new System.Drawing.Point(0, 0);
            this.ContenedorMSJ.Name = "ContenedorMSJ";
            this.ContenedorMSJ.RowCount = 2;
            this.ContenedorMSJ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMSJ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMSJ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorMSJ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorMSJ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorMSJ.Size = new System.Drawing.Size(438, 331);
            this.ContenedorMSJ.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 160);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(200, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "intente nuevamente...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "todos los campos,";
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
            this.btnAceptar.Location = new System.Drawing.Point(165, 100);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 47);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lo sentimos, le recordamos que debe completar";
            // 
            // MensajeErrorCamposVacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(438, 331);
            this.Controls.Add(this.ContenedorMSJ);
            this.Font = new System.Drawing.Font("Exo 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MensajeErrorCamposVacios";
            this.Text = "Campos Requeridos Incompletos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MensajeErrorCamposVacios_Load);
            this.ContenedorIMG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGError)).EndInit();
            this.ContenedorMSJ.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ConteoRegresivo;
        private System.Windows.Forms.Panel ContenedorIMG;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private System.Windows.Forms.PictureBox Separador;
        private System.Windows.Forms.PictureBox IMGError;
        private System.Windows.Forms.TableLayoutPanel ContenedorMSJ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
    }
}