namespace LoginINCOA
{
    partial class AlumnosSistemaDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosSistemaDocente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnBuscadorAlumnos = new System.Windows.Forms.Button();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.DetallesAlumnosSistema = new System.Windows.Forms.DataGridView();
            this.codalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codseccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistroNuevoAlumno = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mtxtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.alumnosTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AlumnosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumnosSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alumnos Registrados en el Sistema";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.btnActualizarTabla);
            this.panel1.Controls.Add(this.btnBuscadorAlumnos);
            this.panel1.Controls.Add(this.btnModificarAlumnos);
            this.panel1.Location = new System.Drawing.Point(825, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 225);
            this.panel1.TabIndex = 29;
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
            this.btnActualizarTabla.Location = new System.Drawing.Point(12, 146);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(208, 34);
            this.btnActualizarTabla.TabIndex = 14;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarTabla.UseVisualStyleBackColor = false;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // btnBuscadorAlumnos
            // 
            this.btnBuscadorAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscadorAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(93)))), ((int)(((byte)(34)))));
            this.btnBuscadorAlumnos.FlatAppearance.BorderSize = 0;
            this.btnBuscadorAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscadorAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscadorAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscadorAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscadorAlumnos.Image")));
            this.btnBuscadorAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscadorAlumnos.Location = new System.Drawing.Point(12, 94);
            this.btnBuscadorAlumnos.Name = "btnBuscadorAlumnos";
            this.btnBuscadorAlumnos.Size = new System.Drawing.Size(208, 34);
            this.btnBuscadorAlumnos.TabIndex = 13;
            this.btnBuscadorAlumnos.Text = "Buscar Alumnos";
            this.btnBuscadorAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscadorAlumnos.UseVisualStyleBackColor = false;
            this.btnBuscadorAlumnos.Click += new System.EventHandler(this.btnBuscadorAlumnos_Click);
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarAlumnos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnModificarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAlumnos.Image")));
            this.btnModificarAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlumnos.Location = new System.Drawing.Point(12, 41);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(208, 34);
            this.btnModificarAlumnos.TabIndex = 12;
            this.btnModificarAlumnos.Text = "Modificar Alumnos";
            this.btnModificarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarAlumnos.UseVisualStyleBackColor = false;
            this.btnModificarAlumnos.Click += new System.EventHandler(this.btnModificarAlumnos_Click);
            // 
            // DetallesAlumnosSistema
            // 
            this.DetallesAlumnosSistema.AllowUserToAddRows = false;
            this.DetallesAlumnosSistema.AllowUserToDeleteRows = false;
            this.DetallesAlumnosSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesAlumnosSistema.AutoGenerateColumns = false;
            this.DetallesAlumnosSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesAlumnosSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesAlumnosSistema.BackgroundColor = System.Drawing.Color.Silver;
            this.DetallesAlumnosSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesAlumnosSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesAlumnosSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumnosSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesAlumnosSistema.ColumnHeadersHeight = 35;
            this.DetallesAlumnosSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesAlumnosSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.fnacimientoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.codseccionDataGridViewTextBoxColumn});
            this.DetallesAlumnosSistema.DataSource = this.alumnosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesAlumnosSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesAlumnosSistema.EnableHeadersVisualStyles = false;
            this.DetallesAlumnosSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesAlumnosSistema.Location = new System.Drawing.Point(27, 36);
            this.DetallesAlumnosSistema.Name = "DetallesAlumnosSistema";
            this.DetallesAlumnosSistema.ReadOnly = true;
            this.DetallesAlumnosSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumnosSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesAlumnosSistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            this.DetallesAlumnosSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesAlumnosSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesAlumnosSistema.Size = new System.Drawing.Size(792, 273);
            this.DetallesAlumnosSistema.TabIndex = 35;
            // 
            // codalumnoDataGridViewTextBoxColumn
            // 
            this.codalumnoDataGridViewTextBoxColumn.DataPropertyName = "cod_alumno";
            this.codalumnoDataGridViewTextBoxColumn.HeaderText = "cod_alumno";
            this.codalumnoDataGridViewTextBoxColumn.Name = "codalumnoDataGridViewTextBoxColumn";
            this.codalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnacimientoDataGridViewTextBoxColumn
            // 
            this.fnacimientoDataGridViewTextBoxColumn.DataPropertyName = "f_nacimiento";
            this.fnacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fnacimientoDataGridViewTextBoxColumn.Name = "fnacimientoDataGridViewTextBoxColumn";
            this.fnacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            this.especialidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codseccionDataGridViewTextBoxColumn
            // 
            this.codseccionDataGridViewTextBoxColumn.DataPropertyName = "cod_seccion";
            this.codseccionDataGridViewTextBoxColumn.HeaderText = "cod_seccion";
            this.codseccionDataGridViewTextBoxColumn.Name = "codseccionDataGridViewTextBoxColumn";
            this.codseccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Registro de Nuevos Alumnos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 170);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(167, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombre.Location = new System.Drawing.Point(93, 47);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(226, 35);
            this.txtnombre.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(568, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Fecha Nac:";
            // 
            // btnRegistroNuevoAlumno
            // 
            this.btnRegistroNuevoAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRegistroNuevoAlumno.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoAlumno.Image")));
            this.btnRegistroNuevoAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoAlumno.Location = new System.Drawing.Point(576, 133);
            this.btnRegistroNuevoAlumno.Name = "btnRegistroNuevoAlumno";
            this.btnRegistroNuevoAlumno.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoAlumno.TabIndex = 11;
            this.btnRegistroNuevoAlumno.Text = "Registrar Nuevo Alumno";
            this.btnRegistroNuevoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoAlumno.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoAlumno.Click += new System.EventHandler(this.btnRegistroNuevoAlumno_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Genero:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(467, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Cod Sección:";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSeccion.Location = new System.Drawing.Point(468, 140);
            this.txtSeccion.Multiline = true;
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(91, 35);
            this.txtSeccion.TabIndex = 10;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(93, 82);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(226, 5);
            this.panel13.TabIndex = 58;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(560, 82);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(108, 5);
            this.panel12.TabIndex = 61;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(22, 175);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(66, 5);
            this.panel11.TabIndex = 60;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(469, 175);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(91, 5);
            this.panel10.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cod Alumno:";
            // 
            // txtcod
            // 
            this.txtcod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcod.Location = new System.Drawing.Point(6, 49);
            this.txtcod.Multiline = true;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(79, 35);
            this.txtcod.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(7, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 5);
            this.panel2.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(329, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 5);
            this.panel3.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(406, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Apellido:";
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txtapellido.Location = new System.Drawing.Point(327, 47);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(226, 35);
            this.txtapellido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(349, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Teléfono:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(322, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 5);
            this.panel4.TabIndex = 69;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Location = new System.Drawing.Point(322, 140);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(128, 35);
            this.txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(257, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAnio.Location = new System.Drawing.Point(246, 140);
            this.txtAnio.Multiline = true;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(54, 35);
            this.txtAnio.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(246, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 5);
            this.panel6.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(122, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Especialidad:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(100, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 5);
            this.panel5.TabIndex = 75;
            // 
            // mtxtNacimiento
            // 
            this.mtxtNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.mtxtNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mtxtNacimiento.ForeColor = System.Drawing.Color.White;
            this.mtxtNacimiento.Location = new System.Drawing.Point(560, 49);
            this.mtxtNacimiento.Mask = "00/00/0000";
            this.mtxtNacimiento.Name = "mtxtNacimiento";
            this.mtxtNacimiento.PromptChar = ' ';
            this.mtxtNacimiento.Size = new System.Drawing.Size(108, 25);
            this.mtxtNacimiento.TabIndex = 4;
            this.mtxtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.panel9.Controls.Add(this.cboEspecialidad);
            this.panel9.Controls.Add(this.cboGenero);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.txtDireccion);
            this.panel9.Controls.Add(this.mtxtNacimiento);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.txtAnio);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.txtTelefono);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.txtapellido);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.txtcod);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.txtSeccion);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.btnRegistroNuevoAlumno);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.txtnombre);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(211, 315);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(846, 199);
            this.panel9.TabIndex = 34;
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboEspecialidad.ForeColor = System.Drawing.Color.White;
            this.cboEspecialidad.Location = new System.Drawing.Point(100, 141);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(128, 32);
            this.cboEspecialidad.TabIndex = 7;
            // 
            // cboGenero
            // 
            this.cboGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboGenero.ForeColor = System.Drawing.Color.White;
            this.cboGenero.Location = new System.Drawing.Point(21, 142);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(66, 32);
            this.cboGenero.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(673, 83);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 5);
            this.panel7.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(726, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 80;
            this.label7.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Location = new System.Drawing.Point(673, 50);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 35);
            this.txtDireccion.TabIndex = 5;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // AlumnosSistemaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1066, 534);
            this.Controls.Add(this.DetallesAlumnosSistema);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnosSistemaDocente";
            this.Text = "AlumnosSistema";
            this.Load += new System.EventHandler(this.AlumnosSistema_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumnosSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnBuscadorAlumnos;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private System.Windows.Forms.DataGridView DetallesAlumnosSistema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistroNuevoAlumno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox mtxtNacimiento;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private incoa_systemdbDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codseccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.ComboBox cboGenero;
    }
}