namespace LoginINCOA
{
    partial class Registrar_AsignAlumn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_AsignAlumn));
            this.DetallesAlumAsignSistema = new System.Windows.Forms.DataGridView();
            this.idAsAlumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturasAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.asignaturasAlumnosTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.cbCodAlumno = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCodAsignatura = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistroNuevoAsignatura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCodDocente = new System.Windows.Forms.ComboBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumAsignSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallesAlumAsignSistema
            // 
            this.DetallesAlumAsignSistema.AllowUserToAddRows = false;
            this.DetallesAlumAsignSistema.AllowUserToDeleteRows = false;
            this.DetallesAlumAsignSistema.AutoGenerateColumns = false;
            this.DetallesAlumAsignSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesAlumAsignSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesAlumAsignSistema.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.DetallesAlumAsignSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesAlumAsignSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesAlumAsignSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumAsignSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DetallesAlumAsignSistema.ColumnHeadersHeight = 35;
            this.DetallesAlumAsignSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesAlumAsignSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsAlumDataGridViewTextBoxColumn,
            this.codasignaturaDataGridViewTextBoxColumn,
            this.nasignaturaDataGridViewTextBoxColumn,
            this.coddocenteDataGridViewTextBoxColumn,
            this.nombreDocDataGridViewTextBoxColumn,
            this.codalumnoDataGridViewTextBoxColumn});
            this.DetallesAlumAsignSistema.DataSource = this.asignaturasAlumnosBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesAlumAsignSistema.DefaultCellStyle = dataGridViewCellStyle10;
            this.DetallesAlumAsignSistema.EnableHeadersVisualStyles = false;
            this.DetallesAlumAsignSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesAlumAsignSistema.Location = new System.Drawing.Point(12, 51);
            this.DetallesAlumAsignSistema.Name = "DetallesAlumAsignSistema";
            this.DetallesAlumAsignSistema.ReadOnly = true;
            this.DetallesAlumAsignSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumAsignSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.DetallesAlumAsignSistema.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DetallesAlumAsignSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesAlumAsignSistema.Size = new System.Drawing.Size(953, 330);
            this.DetallesAlumAsignSistema.TabIndex = 2;
            // 
            // idAsAlumDataGridViewTextBoxColumn
            // 
            this.idAsAlumDataGridViewTextBoxColumn.DataPropertyName = "Id_AsAlum";
            this.idAsAlumDataGridViewTextBoxColumn.HeaderText = "Id_AsAlum";
            this.idAsAlumDataGridViewTextBoxColumn.Name = "idAsAlumDataGridViewTextBoxColumn";
            this.idAsAlumDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsAlumDataGridViewTextBoxColumn.Visible = false;
            // 
            // codasignaturaDataGridViewTextBoxColumn
            // 
            this.codasignaturaDataGridViewTextBoxColumn.DataPropertyName = "cod_asignatura";
            this.codasignaturaDataGridViewTextBoxColumn.HeaderText = "cod_asignatura";
            this.codasignaturaDataGridViewTextBoxColumn.Name = "codasignaturaDataGridViewTextBoxColumn";
            this.codasignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nasignaturaDataGridViewTextBoxColumn
            // 
            this.nasignaturaDataGridViewTextBoxColumn.DataPropertyName = "n_asignatura";
            this.nasignaturaDataGridViewTextBoxColumn.HeaderText = "n_asignatura";
            this.nasignaturaDataGridViewTextBoxColumn.Name = "nasignaturaDataGridViewTextBoxColumn";
            this.nasignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coddocenteDataGridViewTextBoxColumn
            // 
            this.coddocenteDataGridViewTextBoxColumn.DataPropertyName = "cod_docente";
            this.coddocenteDataGridViewTextBoxColumn.HeaderText = "cod_docente";
            this.coddocenteDataGridViewTextBoxColumn.Name = "coddocenteDataGridViewTextBoxColumn";
            this.coddocenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDocDataGridViewTextBoxColumn
            // 
            this.nombreDocDataGridViewTextBoxColumn.DataPropertyName = "nombreDoc";
            this.nombreDocDataGridViewTextBoxColumn.HeaderText = "nombreDoc";
            this.nombreDocDataGridViewTextBoxColumn.Name = "nombreDocDataGridViewTextBoxColumn";
            this.nombreDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codalumnoDataGridViewTextBoxColumn
            // 
            this.codalumnoDataGridViewTextBoxColumn.DataPropertyName = "cod_alumno";
            this.codalumnoDataGridViewTextBoxColumn.HeaderText = "cod_alumno";
            this.codalumnoDataGridViewTextBoxColumn.Name = "codalumnoDataGridViewTextBoxColumn";
            this.codalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignaturasAlumnosBindingSource
            // 
            this.asignaturasAlumnosBindingSource.DataMember = "AsignaturasAlumnos";
            this.asignaturasAlumnosBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasAlumnosTableAdapter
            // 
            this.asignaturasAlumnosTableAdapter.ClearBeforeFill = true;
            // 
            // CerrarVentana
            // 
            this.CerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.CerrarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarVentana.BackgroundImage")));
            this.CerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarVentana.Location = new System.Drawing.Point(933, 12);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 91;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // MinimizarVentana
            // 
            this.MinimizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.MinimizarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizarVentana.BackgroundImage")));
            this.MinimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarVentana.Location = new System.Drawing.Point(889, 12);
            this.MinimizarVentana.Name = "MinimizarVentana";
            this.MinimizarVentana.Size = new System.Drawing.Size(34, 33);
            this.MinimizarVentana.TabIndex = 92;
            this.MinimizarVentana.TabStop = false;
            this.MinimizarVentana.Click += new System.EventHandler(this.MinimizarVentana_Click);
            // 
            // cbCodAlumno
            // 
            this.cbCodAlumno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbCodAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAlumno.ForeColor = System.Drawing.Color.White;
            this.cbCodAlumno.Location = new System.Drawing.Point(712, 453);
            this.cbCodAlumno.MaxDropDownItems = 20;
            this.cbCodAlumno.Name = "cbCodAlumno";
            this.cbCodAlumno.Size = new System.Drawing.Size(112, 24);
            this.cbCodAlumno.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(712, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 10);
            this.panel2.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(723, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Cod Alumno:";
            // 
            // cbCodAsignatura
            // 
            this.cbCodAsignatura.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbCodAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbCodAsignatura.Location = new System.Drawing.Point(276, 454);
            this.cbCodAsignatura.MaxDropDownItems = 20;
            this.cbCodAsignatura.Name = "cbCodAsignatura";
            this.cbCodAsignatura.Size = new System.Drawing.Size(150, 24);
            this.cbCodAsignatura.TabIndex = 98;
            this.cbCodAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbCodAsignatura_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(276, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 5);
            this.panel1.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Cod Asignatura:";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(435, 478);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(151, 5);
            this.panel13.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(439, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 100;
            this.label12.Text = "Nombre de Asignatura:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(598, 478);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(87, 5);
            this.panel7.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(595, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Cod Docente:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(214, 570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 5);
            this.panel3.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(359, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Nombre Docente:";
            // 
            // btnRegistroNuevoAsignatura
            // 
            this.btnRegistroNuevoAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistroNuevoAsignatura.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoAsignatura.Image")));
            this.btnRegistroNuevoAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoAsignatura.Location = new System.Drawing.Point(701, 538);
            this.btnRegistroNuevoAsignatura.Name = "btnRegistroNuevoAsignatura";
            this.btnRegistroNuevoAsignatura.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoAsignatura.TabIndex = 108;
            this.btnRegistroNuevoAsignatura.Text = "Registrar Alumn - Asign";
            this.btnRegistroNuevoAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoAsignatura.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoAsignatura.Click += new System.EventHandler(this.btnRegistroNuevoAsignatura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 18);
            this.label7.TabIndex = 110;
            this.label7.Text = "Registro de Alumnos y Asignatura:";
            // 
            // cbCodDocente
            // 
            this.cbCodDocente.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbCodDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodDocente.ForeColor = System.Drawing.Color.White;
            this.cbCodDocente.Location = new System.Drawing.Point(598, 453);
            this.cbCodDocente.MaxDropDownItems = 20;
            this.cbCodDocente.Name = "cbCodDocente";
            this.cbCodDocente.Size = new System.Drawing.Size(87, 24);
            this.cbCodDocente.TabIndex = 112;
            this.cbCodDocente.SelectedIndexChanged += new System.EventHandler(this.cbCodDocente_SelectedIndexChanged);
            // 
            // txtnombres
            // 
            this.txtnombres.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Enabled = false;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtnombres.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombres.Location = new System.Drawing.Point(214, 545);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(422, 24);
            this.txtnombres.TabIndex = 127;
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtNombreAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAsignatura.Enabled = false;
            this.txtNombreAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombreAsignatura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreAsignatura.Location = new System.Drawing.Point(435, 454);
            this.txtNombreAsignatura.Multiline = true;
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(151, 24);
            this.txtNombreAsignatura.TabIndex = 128;
            // 
            // Registrar_AsignAlumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(977, 619);
            this.Controls.Add(this.txtNombreAsignatura);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.cbCodDocente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistroNuevoAsignatura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCodAsignatura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCodAlumno);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.DetallesAlumAsignSistema);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar_AsignAlumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar_AsignAlumn";
            this.Load += new System.EventHandler(this.Registrar_AsignAlumn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registrar_AsignAlumn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumAsignSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetallesAlumAsignSistema;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasAlumnosBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter asignaturasAlumnosTableAdapter;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.ComboBox cbCodAlumno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCodAsignatura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistroNuevoAsignatura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCodDocente;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsAlumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNombreAsignatura;
    }
}