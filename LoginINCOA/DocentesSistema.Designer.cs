namespace LoginINCOA
{
    partial class DocentesSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesSistema));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMensajeDocentes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscadorDocentes = new System.Windows.Forms.Button();
            this.ModificarDocente = new System.Windows.Forms.Button();
            this.EliminarDocente = new System.Windows.Forms.Button();
            this.ActualizarTabla = new System.Windows.Forms.Button();
            this.DetallesDocentesSistema = new System.Windows.Forms.DataGridView();
            this.cod_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnRegistroNuevoDocente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.docentesTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.DocentesTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDocentesSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensajeDocentes
            // 
            this.lblMensajeDocentes.AutoSize = true;
            this.lblMensajeDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDocentes.ForeColor = System.Drawing.Color.White;
            this.lblMensajeDocentes.Location = new System.Drawing.Point(24, 9);
            this.lblMensajeDocentes.Name = "lblMensajeDocentes";
            this.lblMensajeDocentes.Size = new System.Drawing.Size(253, 18);
            this.lblMensajeDocentes.TabIndex = 35;
            this.lblMensajeDocentes.Text = "Docentes Registrados En El Sistema";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.btnBuscadorDocentes);
            this.panel2.Controls.Add(this.ModificarDocente);
            this.panel2.Controls.Add(this.EliminarDocente);
            this.panel2.Controls.Add(this.ActualizarTabla);
            this.panel2.Location = new System.Drawing.Point(822, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 225);
            this.panel2.TabIndex = 39;
            // 
            // btnBuscadorDocentes
            // 
            this.btnBuscadorDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscadorDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(93)))), ((int)(((byte)(34)))));
            this.btnBuscadorDocentes.FlatAppearance.BorderSize = 0;
            this.btnBuscadorDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscadorDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscadorDocentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscadorDocentes.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscadorDocentes.Image")));
            this.btnBuscadorDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscadorDocentes.Location = new System.Drawing.Point(12, 124);
            this.btnBuscadorDocentes.Name = "btnBuscadorDocentes";
            this.btnBuscadorDocentes.Size = new System.Drawing.Size(208, 34);
            this.btnBuscadorDocentes.TabIndex = 10;
            this.btnBuscadorDocentes.Text = "Buscar Docentes";
            this.btnBuscadorDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscadorDocentes.UseVisualStyleBackColor = false;
            this.btnBuscadorDocentes.Click += new System.EventHandler(this.btnBuscadorUsuarios_Click);
            // 
            // ModificarDocente
            // 
            this.ModificarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificarDocente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ModificarDocente.FlatAppearance.BorderSize = 0;
            this.ModificarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarDocente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarDocente.Image = ((System.Drawing.Image)(resources.GetObject("ModificarDocente.Image")));
            this.ModificarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarDocente.Location = new System.Drawing.Point(12, 22);
            this.ModificarDocente.Name = "ModificarDocente";
            this.ModificarDocente.Size = new System.Drawing.Size(208, 34);
            this.ModificarDocente.TabIndex = 8;
            this.ModificarDocente.Text = "Modificar Docente";
            this.ModificarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarDocente.UseVisualStyleBackColor = false;
            this.ModificarDocente.Click += new System.EventHandler(this.ModificarDocente_Click);
            // 
            // EliminarDocente
            // 
            this.EliminarDocente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarDocente.BackColor = System.Drawing.Color.Brown;
            this.EliminarDocente.FlatAppearance.BorderSize = 0;
            this.EliminarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarDocente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarDocente.Image = ((System.Drawing.Image)(resources.GetObject("EliminarDocente.Image")));
            this.EliminarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarDocente.Location = new System.Drawing.Point(12, 73);
            this.EliminarDocente.Name = "EliminarDocente";
            this.EliminarDocente.Size = new System.Drawing.Size(208, 34);
            this.EliminarDocente.TabIndex = 9;
            this.EliminarDocente.Text = "Eliminar Docente";
            this.EliminarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarDocente.UseVisualStyleBackColor = false;
            this.EliminarDocente.Click += new System.EventHandler(this.EliminarDocente_Click);
            // 
            // ActualizarTabla
            // 
            this.ActualizarTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActualizarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.ActualizarTabla.FlatAppearance.BorderSize = 0;
            this.ActualizarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarTabla.ForeColor = System.Drawing.Color.Transparent;
            this.ActualizarTabla.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarTabla.Image")));
            this.ActualizarTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarTabla.Location = new System.Drawing.Point(12, 173);
            this.ActualizarTabla.Name = "ActualizarTabla";
            this.ActualizarTabla.Size = new System.Drawing.Size(208, 34);
            this.ActualizarTabla.TabIndex = 11;
            this.ActualizarTabla.Text = "Actualizar Tabla";
            this.ActualizarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActualizarTabla.UseVisualStyleBackColor = false;
            this.ActualizarTabla.Click += new System.EventHandler(this.ActualizarTabla_Click);
            // 
            // DetallesDocentesSistema
            // 
            this.DetallesDocentesSistema.AllowUserToAddRows = false;
            this.DetallesDocentesSistema.AllowUserToDeleteRows = false;
            this.DetallesDocentesSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesDocentesSistema.AutoGenerateColumns = false;
            this.DetallesDocentesSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesDocentesSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesDocentesSistema.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.DetallesDocentesSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesDocentesSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesDocentesSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesDocentesSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesDocentesSistema.ColumnHeadersHeight = 35;
            this.DetallesDocentesSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesDocentesSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_docente,
            this.nombre,
            this.apellido,
            this.direccion,
            this.f_nacimiento,
            this.genero,
            this.telefono});
            this.DetallesDocentesSistema.DataSource = this.docentesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesDocentesSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesDocentesSistema.EnableHeadersVisualStyles = false;
            this.DetallesDocentesSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesDocentesSistema.Location = new System.Drawing.Point(27, 36);
            this.DetallesDocentesSistema.MultiSelect = false;
            this.DetallesDocentesSistema.Name = "DetallesDocentesSistema";
            this.DetallesDocentesSistema.ReadOnly = true;
            this.DetallesDocentesSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesDocentesSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesDocentesSistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.DetallesDocentesSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesDocentesSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesDocentesSistema.Size = new System.Drawing.Size(789, 273);
            this.DetallesDocentesSistema.TabIndex = 41;
            // 
            // cod_docente
            // 
            this.cod_docente.DataPropertyName = "cod_docente";
            this.cod_docente.HeaderText = "cod_docente";
            this.cod_docente.Name = "cod_docente";
            this.cod_docente.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // f_nacimiento
            // 
            this.f_nacimiento.DataPropertyName = "f_nacimiento";
            this.f_nacimiento.HeaderText = "Fecha Nacimiento";
            this.f_nacimiento.Name = "f_nacimiento";
            this.f_nacimiento.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // docentesBindingSource
            // 
            this.docentesBindingSource.DataMember = "Docentes";
            this.docentesBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 170);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Registro de Nuevos Usuarios";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Controls.Add(this.cboGenero);
            this.panel9.Controls.Add(this.txtTel);
            this.panel9.Controls.Add(this.txtDireccion);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.mtxtNacimiento);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.txtcod);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.btnRegistroNuevoDocente);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.txtnombres);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.txtapellidos);
            this.panel9.Location = new System.Drawing.Point(210, 345);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(846, 170);
            this.panel9.TabIndex = 44;
            // 
            // cboGenero
            // 
            this.cboGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGenero.BackColor = System.Drawing.Color.DodgerBlue;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboGenero.ForeColor = System.Drawing.Color.White;
            this.cboGenero.Location = new System.Drawing.Point(311, 125);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(66, 32);
            this.cboGenero.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTel.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTel.Location = new System.Drawing.Point(387, 122);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(128, 35);
            this.txtTel.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Location = new System.Drawing.Point(12, 122);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(285, 35);
            this.txtDireccion.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(387, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 5);
            this.panel5.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(415, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Teléfono:";
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(311, 158);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(66, 5);
            this.panel11.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(314, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Genero:";
            // 
            // mtxtNacimiento
            // 
            this.mtxtNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNacimiento.BackColor = System.Drawing.Color.DodgerBlue;
            this.mtxtNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mtxtNacimiento.ForeColor = System.Drawing.Color.White;
            this.mtxtNacimiento.Location = new System.Drawing.Point(691, 45);
            this.mtxtNacimiento.Mask = "00/00/0000";
            this.mtxtNacimiento.Name = "mtxtNacimiento";
            this.mtxtNacimiento.PromptChar = ' ';
            this.mtxtNacimiento.Size = new System.Drawing.Size(108, 25);
            this.mtxtNacimiento.TabIndex = 3;
            this.mtxtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(691, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 5);
            this.panel4.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(675, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 5);
            this.panel3.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 5);
            this.panel1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Dirección:";
            // 
            // txtcod
            // 
            this.txtcod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcod.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcod.Location = new System.Drawing.Point(12, 46);
            this.txtcod.Multiline = true;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(156, 35);
            this.txtcod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Cod Docente:";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(421, 78);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(218, 5);
            this.panel12.TabIndex = 61;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(186, 78);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(213, 5);
            this.panel13.TabIndex = 58;
            // 
            // btnRegistroNuevoDocente
            // 
            this.btnRegistroNuevoDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRegistroNuevoDocente.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoDocente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoDocente.Image")));
            this.btnRegistroNuevoDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoDocente.Location = new System.Drawing.Point(557, 114);
            this.btnRegistroNuevoDocente.Name = "btnRegistroNuevoDocente";
            this.btnRegistroNuevoDocente.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoDocente.TabIndex = 7;
            this.btnRegistroNuevoDocente.Text = "Registrar Nuevo Docente";
            this.btnRegistroNuevoDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoDocente.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoDocente.Click += new System.EventHandler(this.btnRegistroNuevoUsuario_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(468, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Apellido del Docente:";
            // 
            // txtnombres
            // 
            this.txtnombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombres.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombres.Location = new System.Drawing.Point(186, 45);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(213, 35);
            this.txtnombres.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(229, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nombre del Docente:";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellidos.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtapellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtapellidos.Location = new System.Drawing.Point(421, 45);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(218, 35);
            this.txtapellidos.TabIndex = 2;
            // 
            // docentesTableAdapter
            // 
            this.docentesTableAdapter.ClearBeforeFill = true;
            // 
            // DocentesSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1066, 534);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetallesDocentesSistema);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMensajeDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocentesSistema";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.DocentesSistema_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDocentesSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeDocentes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ModificarDocente;
        private System.Windows.Forms.Button EliminarDocente;
        private System.Windows.Forms.Button ActualizarTabla;
        private System.Windows.Forms.DataGridView DetallesDocentesSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnRegistroNuevoDocente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtNacimiento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuscadorDocentes;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource docentesBindingSource;
        private incoa_systemdbDataSetTableAdapters.DocentesTableAdapter docentesTableAdapter;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.ComboBox cboGenero;
    }
}