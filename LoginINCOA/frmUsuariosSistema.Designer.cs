namespace LoginINCOA
{
    partial class frmUsuariosSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosSistema));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscadorUsuarios = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnModificarUsuarios = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistroNuevoUsuario = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DetallesUsuariosSistema = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.usuariosTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.UsuariosTableAdapter();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesUsuariosSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuarios Registrados En El Sistema";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnBuscadorUsuarios);
            this.panel1.Controls.Add(this.btnActualizarTabla);
            this.panel1.Controls.Add(this.btnEliminarUsuarios);
            this.panel1.Controls.Add(this.btnModificarUsuarios);
            this.panel1.Location = new System.Drawing.Point(822, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 225);
            this.panel1.TabIndex = 28;
            // 
            // btnBuscadorUsuarios
            // 
            this.btnBuscadorUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscadorUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(93)))), ((int)(((byte)(34)))));
            this.btnBuscadorUsuarios.FlatAppearance.BorderSize = 0;
            this.btnBuscadorUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscadorUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscadorUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscadorUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscadorUsuarios.Image")));
            this.btnBuscadorUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscadorUsuarios.Location = new System.Drawing.Point(12, 124);
            this.btnBuscadorUsuarios.Name = "btnBuscadorUsuarios";
            this.btnBuscadorUsuarios.Size = new System.Drawing.Size(208, 34);
            this.btnBuscadorUsuarios.TabIndex = 15;
            this.btnBuscadorUsuarios.Text = "Buscar Usuarios";
            this.btnBuscadorUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscadorUsuarios.UseVisualStyleBackColor = false;
            this.btnBuscadorUsuarios.Click += new System.EventHandler(this.btnBuscadorUsuarios_Click);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.btnActualizarTabla.FlatAppearance.BorderSize = 0;
            this.btnActualizarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarTabla.Image")));
            this.btnActualizarTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarTabla.Location = new System.Drawing.Point(12, 173);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(208, 34);
            this.btnActualizarTabla.TabIndex = 9;
            this.btnActualizarTabla.Text = "ActualizarTabla";
            this.btnActualizarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarTabla.UseVisualStyleBackColor = false;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUsuarios.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuarios.Image")));
            this.btnEliminarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(12, 73);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(208, 34);
            this.btnEliminarUsuarios.TabIndex = 8;
            this.btnEliminarUsuarios.Text = "Eliminar Usuarios";
            this.btnEliminarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuarios.UseVisualStyleBackColor = false;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnModificarUsuarios
            // 
            this.btnModificarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarUsuarios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarUsuarios.Image")));
            this.btnModificarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuarios.Location = new System.Drawing.Point(12, 22);
            this.btnModificarUsuarios.Name = "btnModificarUsuarios";
            this.btnModificarUsuarios.Size = new System.Drawing.Size(208, 34);
            this.btnModificarUsuarios.TabIndex = 7;
            this.btnModificarUsuarios.Text = "Modificar Usuarios";
            this.btnModificarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUsuarios.UseVisualStyleBackColor = false;
            this.btnModificarUsuarios.Click += new System.EventHandler(this.btnModificarUsuarios_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Registro de Nuevos Usuarios";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Controls.Add(this.cbotipo);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.btnRegistroNuevoUsuario);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.txtnombres);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.txtusuario);
            this.panel9.Controls.Add(this.txtpass);
            this.panel9.Location = new System.Drawing.Point(210, 345);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(846, 170);
            this.panel9.TabIndex = 32;
            // 
            // cbotipo
            // 
            this.cbotipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbotipo.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbotipo.ForeColor = System.Drawing.Color.White;
            this.cbotipo.Location = new System.Drawing.Point(646, 53);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(185, 32);
            this.cbotipo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(692, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tipo Usuario:";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(646, 86);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(185, 5);
            this.panel10.TabIndex = 59;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(445, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(185, 5);
            this.panel11.TabIndex = 60;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(243, 87);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(185, 5);
            this.panel12.TabIndex = 61;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(16, 87);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(210, 5);
            this.panel13.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(463, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Contraseña de Usuario:";
            // 
            // btnRegistroNuevoUsuario
            // 
            this.btnRegistroNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRegistroNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoUsuario.Image")));
            this.btnRegistroNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoUsuario.Location = new System.Drawing.Point(278, 116);
            this.btnRegistroNuevoUsuario.Name = "btnRegistroNuevoUsuario";
            this.btnRegistroNuevoUsuario.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoUsuario.TabIndex = 6;
            this.btnRegistroNuevoUsuario.Text = "Registrar Nuevo Usuario";
            this.btnRegistroNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoUsuario.Click += new System.EventHandler(this.btnRegistroNuevoUsuario_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(275, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Nombre de Usuario:";
            // 
            // txtnombres
            // 
            this.txtnombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombres.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombres.Location = new System.Drawing.Point(16, 54);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(210, 35);
            this.txtnombres.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(52, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nombre y Apellido:";
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtusuario.Location = new System.Drawing.Point(243, 54);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(185, 35);
            this.txtusuario.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpass.Location = new System.Drawing.Point(445, 54);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(185, 35);
            this.txtpass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 170);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // DetallesUsuariosSistema
            // 
            this.DetallesUsuariosSistema.AllowUserToAddRows = false;
            this.DetallesUsuariosSistema.AllowUserToDeleteRows = false;
            this.DetallesUsuariosSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesUsuariosSistema.AutoGenerateColumns = false;
            this.DetallesUsuariosSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesUsuariosSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesUsuariosSistema.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.DetallesUsuariosSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesUsuariosSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesUsuariosSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesUsuariosSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesUsuariosSistema.ColumnHeadersHeight = 35;
            this.DetallesUsuariosSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesUsuariosSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.tipousuarioDataGridViewTextBoxColumn});
            this.DetallesUsuariosSistema.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesUsuariosSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesUsuariosSistema.EnableHeadersVisualStyles = false;
            this.DetallesUsuariosSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesUsuariosSistema.Location = new System.Drawing.Point(27, 36);
            this.DetallesUsuariosSistema.Name = "DetallesUsuariosSistema";
            this.DetallesUsuariosSistema.ReadOnly = true;
            this.DetallesUsuariosSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesUsuariosSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesUsuariosSistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.DetallesUsuariosSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesUsuariosSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesUsuariosSistema.Size = new System.Drawing.Size(788, 273);
            this.DetallesUsuariosSistema.TabIndex = 9;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipousuarioDataGridViewTextBoxColumn
            // 
            this.tipousuarioDataGridViewTextBoxColumn.DataPropertyName = "Tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.HeaderText = "Tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.Name = "tipousuarioDataGridViewTextBoxColumn";
            this.tipousuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuariosSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1066, 534);
            this.Controls.Add(this.DetallesUsuariosSistema);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuariosSistema";
            this.Text = "x";
            this.Load += new System.EventHandler(this.frmUsuariosSistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesUsuariosSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnModificarUsuarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistroNuevoUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DetallesUsuariosSistema;
        private System.Windows.Forms.Button btnBuscadorUsuarios;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private incoa_systemdbDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbotipo;
    }
}