namespace LoginINCOA
{
    partial class MensajeNoSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeNoSeleccion));
            this.ContenedorMsjModificarUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorImgMUs = new System.Windows.Forms.Panel();
            this.Separador = new System.Windows.Forms.PictureBox();
            this.ImgMUs = new System.Windows.Forms.PictureBox();
            this.ContenedorAccMUs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbLimpiezaMsj1 = new System.Windows.Forms.Label();
            this.ConteoRegresivo = new System.Windows.Forms.Timer(this.components);
            this.ContenedorMsjModificarUsuarios.SuspendLayout();
            this.ContenedorImgMUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMUs)).BeginInit();
            this.ContenedorAccMUs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorMsjModificarUsuarios
            // 
            this.ContenedorMsjModificarUsuarios.ColumnCount = 1;
            this.ContenedorMsjModificarUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMsjModificarUsuarios.Controls.Add(this.ContenedorImgMUs, 0, 0);
            this.ContenedorMsjModificarUsuarios.Controls.Add(this.ContenedorAccMUs, 0, 1);
            this.ContenedorMsjModificarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMsjModificarUsuarios.Location = new System.Drawing.Point(0, 0);
            this.ContenedorMsjModificarUsuarios.Name = "ContenedorMsjModificarUsuarios";
            this.ContenedorMsjModificarUsuarios.RowCount = 2;
            this.ContenedorMsjModificarUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMsjModificarUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMsjModificarUsuarios.Size = new System.Drawing.Size(438, 331);
            this.ContenedorMsjModificarUsuarios.TabIndex = 0;
            // 
            // ContenedorImgMUs
            // 
            this.ContenedorImgMUs.Controls.Add(this.Separador);
            this.ContenedorImgMUs.Controls.Add(this.ImgMUs);
            this.ContenedorImgMUs.Location = new System.Drawing.Point(0, 0);
            this.ContenedorImgMUs.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorImgMUs.Name = "ContenedorImgMUs";
            this.ContenedorImgMUs.Size = new System.Drawing.Size(438, 165);
            this.ContenedorImgMUs.TabIndex = 0;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.White;
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(438, 10);
            this.Separador.TabIndex = 3;
            this.Separador.TabStop = false;
            // 
            // ImgMUs
            // 
            this.ImgMUs.Image = ((System.Drawing.Image)(resources.GetObject("ImgMUs.Image")));
            this.ImgMUs.Location = new System.Drawing.Point(101, 16);
            this.ImgMUs.Name = "ImgMUs";
            this.ImgMUs.Size = new System.Drawing.Size(226, 150);
            this.ImgMUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgMUs.TabIndex = 0;
            this.ImgMUs.TabStop = false;
            // 
            // ContenedorAccMUs
            // 
            this.ContenedorAccMUs.Controls.Add(this.label1);
            this.ContenedorAccMUs.Controls.Add(this.btnAceptar);
            this.ContenedorAccMUs.Controls.Add(this.lbLimpiezaMsj1);
            this.ContenedorAccMUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorAccMUs.Location = new System.Drawing.Point(3, 168);
            this.ContenedorAccMUs.Name = "ContenedorAccMUs";
            this.ContenedorAccMUs.Size = new System.Drawing.Size(432, 160);
            this.ContenedorAccMUs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "No hay ningún elemento seleccionado...";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(159, 94);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 47);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.brnAceptar_Click);
            // 
            // lbLimpiezaMsj1
            // 
            this.lbLimpiezaMsj1.AutoSize = true;
            this.lbLimpiezaMsj1.BackColor = System.Drawing.Color.Transparent;
            this.lbLimpiezaMsj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimpiezaMsj1.ForeColor = System.Drawing.Color.White;
            this.lbLimpiezaMsj1.Location = new System.Drawing.Point(15, 13);
            this.lbLimpiezaMsj1.Name = "lbLimpiezaMsj1";
            this.lbLimpiezaMsj1.Size = new System.Drawing.Size(390, 24);
            this.lbLimpiezaMsj1.TabIndex = 5;
            this.lbLimpiezaMsj1.Text = "Recuerda hacer clic en el registro a gestionar";
            // 
            // ConteoRegresivo
            // 
            this.ConteoRegresivo.Interval = 1000;
            this.ConteoRegresivo.Tick += new System.EventHandler(this.ConteoRegresivo_Tick);
            // 
            // MensajeNoSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(438, 331);
            this.Controls.Add(this.ContenedorMsjModificarUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MensajeNoSeleccion";
            this.Text = "Debe seleccionar elemento requerido";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MensajeNoSeleccion_Load);
            this.ContenedorMsjModificarUsuarios.ResumeLayout(false);
            this.ContenedorImgMUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMUs)).EndInit();
            this.ContenedorAccMUs.ResumeLayout(false);
            this.ContenedorAccMUs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorMsjModificarUsuarios;
        private System.Windows.Forms.Panel ContenedorImgMUs;
        private System.Windows.Forms.PictureBox ImgMUs;
        private System.Windows.Forms.Panel ContenedorAccMUs;
        private System.Windows.Forms.PictureBox Separador;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbLimpiezaMsj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer ConteoRegresivo;
    }
}