namespace LoginINCOA
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.IconInicioRetorno = new System.Windows.Forms.PictureBox();
            this.btnIconPanel = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IconPanel = new System.Windows.Forms.Panel();
            this.IconContainer = new System.Windows.Forms.Panel();
            this.btnNotas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NombreUsuarioAD = new System.Windows.Forms.Label();
            this.SaludoAD = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSecciones = new System.Windows.Forms.Button();
            this.btnAsignaturas = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HoraSistema = new System.Windows.Forms.Label();
            this.LineaDivisoraAD = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconInicioRetorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIconPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.IconPanel.SuspendLayout();
            this.IconContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineaDivisoraAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1213, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(34, 33);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1173, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 33);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1253, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuTop.Controls.Add(this.btnMinimizar);
            this.MenuTop.Controls.Add(this.btnRestaurar);
            this.MenuTop.Controls.Add(this.IconInicioRetorno);
            this.MenuTop.Controls.Add(this.btnIconPanel);
            this.MenuTop.Controls.Add(this.btnMaximizar);
            this.MenuTop.Controls.Add(this.btnSalir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1300, 43);
            this.MenuTop.TabIndex = 1;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // IconInicioRetorno
            // 
            this.IconInicioRetorno.BackColor = System.Drawing.Color.Transparent;
            this.IconInicioRetorno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconInicioRetorno.Image = ((System.Drawing.Image)(resources.GetObject("IconInicioRetorno.Image")));
            this.IconInicioRetorno.Location = new System.Drawing.Point(88, 5);
            this.IconInicioRetorno.Name = "IconInicioRetorno";
            this.IconInicioRetorno.Size = new System.Drawing.Size(36, 32);
            this.IconInicioRetorno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconInicioRetorno.TabIndex = 26;
            this.IconInicioRetorno.TabStop = false;
            this.IconInicioRetorno.Click += new System.EventHandler(this.IconInicioRetorno_Click);
            // 
            // btnIconPanel
            // 
            this.btnIconPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnIconPanel.Image")));
            this.btnIconPanel.Location = new System.Drawing.Point(29, 5);
            this.btnIconPanel.Name = "btnIconPanel";
            this.btnIconPanel.Size = new System.Drawing.Size(36, 32);
            this.btnIconPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIconPanel.TabIndex = 4;
            this.btnIconPanel.TabStop = false;
            this.btnIconPanel.Click += new System.EventHandler(this.btnIconPanel_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1213, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 33);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IconPanel
            // 
            this.IconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.IconPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPanel.Controls.Add(this.IconContainer);
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconPanel.Location = new System.Drawing.Point(0, 43);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(234, 607);
            this.IconPanel.TabIndex = 3;
            // 
            // IconContainer
            // 
            this.IconContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IconContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(100)))), ((int)(((byte)(183)))));
            this.IconContainer.Controls.Add(this.btnNotas);
            this.IconContainer.Controls.Add(this.pictureBox3);
            this.IconContainer.Controls.Add(this.NombreUsuarioAD);
            this.IconContainer.Controls.Add(this.SaludoAD);
            this.IconContainer.Controls.Add(this.btnCerrarSesion);
            this.IconContainer.Controls.Add(this.btnSecciones);
            this.IconContainer.Controls.Add(this.btnAsignaturas);
            this.IconContainer.Controls.Add(this.btnAlumnos);
            this.IconContainer.Controls.Add(this.btnDocentes);
            this.IconContainer.Controls.Add(this.btnUsuarios);
            this.IconContainer.Controls.Add(this.label1);
            this.IconContainer.Controls.Add(this.pictureBox1);
            this.IconContainer.Location = new System.Drawing.Point(10, 7);
            this.IconContainer.Name = "IconContainer";
            this.IconContainer.Size = new System.Drawing.Size(211, 584);
            this.IconContainer.TabIndex = 0;
            // 
            // btnNotas
            // 
            this.btnNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(19, 470);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(173, 46);
            this.btnNotas.TabIndex = 24;
            this.btnNotas.Text = "Notas";
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // NombreUsuarioAD
            // 
            this.NombreUsuarioAD.AutoSize = true;
            this.NombreUsuarioAD.BackColor = System.Drawing.Color.Transparent;
            this.NombreUsuarioAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuarioAD.ForeColor = System.Drawing.Color.MintCream;
            this.NombreUsuarioAD.Location = new System.Drawing.Point(97, 111);
            this.NombreUsuarioAD.Name = "NombreUsuarioAD";
            this.NombreUsuarioAD.Size = new System.Drawing.Size(37, 16);
            this.NombreUsuarioAD.TabIndex = 22;
            this.NombreUsuarioAD.Text = "User";
            // 
            // SaludoAD
            // 
            this.SaludoAD.AutoSize = true;
            this.SaludoAD.BackColor = System.Drawing.Color.Transparent;
            this.SaludoAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaludoAD.ForeColor = System.Drawing.Color.MintCream;
            this.SaludoAD.Location = new System.Drawing.Point(60, 111);
            this.SaludoAD.Name = "SaludoAD";
            this.SaludoAD.Size = new System.Drawing.Size(40, 16);
            this.SaludoAD.TabIndex = 21;
            this.SaludoAD.Text = "Hola,";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(19, 528);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(173, 46);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Salir";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSecciones
            // 
            this.btnSecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecciones.FlatAppearance.BorderSize = 0;
            this.btnSecciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSecciones.ForeColor = System.Drawing.Color.White;
            this.btnSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnSecciones.Image")));
            this.btnSecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecciones.Location = new System.Drawing.Point(19, 405);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Size = new System.Drawing.Size(173, 46);
            this.btnSecciones.TabIndex = 4;
            this.btnSecciones.Text = "Secciones";
            this.btnSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecciones.UseVisualStyleBackColor = true;
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignaturas.FlatAppearance.BorderSize = 0;
            this.btnAsignaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAsignaturas.ForeColor = System.Drawing.Color.White;
            this.btnAsignaturas.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignaturas.Image")));
            this.btnAsignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaturas.Location = new System.Drawing.Point(19, 340);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Size = new System.Drawing.Size(175, 46);
            this.btnAsignaturas.TabIndex = 3;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignaturas.UseVisualStyleBackColor = true;
            this.btnAsignaturas.Click += new System.EventHandler(this.btnAsignaturas_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.Image")));
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(19, 277);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(173, 46);
            this.btnAlumnos.TabIndex = 2;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnDocentes.Image")));
            this.btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Location = new System.Drawing.Point(19, 211);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(173, 46);
            this.btnDocentes.TabIndex = 1;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(100)))), ((int)(((byte)(183)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(19, 145);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(173, 46);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "I.N.C.O.A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.HoraSistema);
            this.panel1.Controls.Add(this.LineaDivisoraAD);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(234, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 71);
            this.panel1.TabIndex = 4;
            // 
            // HoraSistema
            // 
            this.HoraSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraSistema.AutoSize = true;
            this.HoraSistema.BackColor = System.Drawing.Color.Transparent;
            this.HoraSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraSistema.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HoraSistema.Location = new System.Drawing.Point(836, 40);
            this.HoraSistema.Name = "HoraSistema";
            this.HoraSistema.Size = new System.Drawing.Size(38, 16);
            this.HoraSistema.TabIndex = 9;
            this.HoraSistema.Text = "Hora";
            // 
            // LineaDivisoraAD
            // 
            this.LineaDivisoraAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaDivisoraAD.BackColor = System.Drawing.Color.GhostWhite;
            this.LineaDivisoraAD.Location = new System.Drawing.Point(-1, 62);
            this.LineaDivisoraAD.Name = "LineaDivisoraAD";
            this.LineaDivisoraAD.Size = new System.Drawing.Size(1071, 5);
            this.LineaDivisoraAD.TabIndex = 24;
            this.LineaDivisoraAD.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(748, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(814, 24);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(184, 17);
            this.lblBienvenida.TabIndex = 7;
            this.lblBienvenida.Text = "Tipo Usuario: Administrador";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(234, 43);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1066, 536);
            this.panelContenedor.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IconPanel);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconInicioRetorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIconPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.IconPanel.ResumeLayout(false);
            this.IconContainer.ResumeLayout(false);
            this.IconContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineaDivisoraAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnIconPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LineaDivisoraAD;
        private System.Windows.Forms.Label HoraSistema;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox IconInicioRetorno;
        private System.Windows.Forms.Panel IconContainer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NombreUsuarioAD;
        private System.Windows.Forms.Label SaludoAD;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSecciones;
        private System.Windows.Forms.Button btnAsignaturas;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNotas;
    }
}