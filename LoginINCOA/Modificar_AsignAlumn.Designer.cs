namespace LoginINCOA
{
    partial class Modificar_AsignAlumn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_AsignAlumn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.btnRegistroNuevoAsignatura = new System.Windows.Forms.Button();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.cbCodDocente = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCodAsignatura = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCodAlumno = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DetallesAsignAlumnSistema = new System.Windows.Forms.DataGridView();
            this.Id_AsAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturasAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeleccionarRegistroAsignatura = new System.Windows.Forms.Button();
            this.asignaturasAlumnosTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter();
            this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAsignAlumnSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 18);
            this.label7.TabIndex = 111;
            this.label7.Text = "Modificación de Alumnos - Asignatura:";
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
            this.MinimizarVentana.TabIndex = 112;
            this.MinimizarVentana.TabStop = false;
            this.MinimizarVentana.Click += new System.EventHandler(this.MinimizarVentana_Click);
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
            this.CerrarVentana.TabIndex = 113;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // btnRegistroNuevoAsignatura
            // 
            this.btnRegistroNuevoAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoAsignatura.BackColor = System.Drawing.Color.Teal;
            this.btnRegistroNuevoAsignatura.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoAsignatura.Image")));
            this.btnRegistroNuevoAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoAsignatura.Location = new System.Drawing.Point(712, 555);
            this.btnRegistroNuevoAsignatura.Name = "btnRegistroNuevoAsignatura";
            this.btnRegistroNuevoAsignatura.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoAsignatura.TabIndex = 129;
            this.btnRegistroNuevoAsignatura.Text = "Modificar Alumn - Asign";
            this.btnRegistroNuevoAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoAsignatura.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoAsignatura.Click += new System.EventHandler(this.btnRegistroNuevoAsignatura_Click);
            // 
            // txtnombres
            // 
            this.txtnombres.BackColor = System.Drawing.Color.Turquoise;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Enabled = false;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtnombres.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombres.Location = new System.Drawing.Point(289, 543);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(360, 24);
            this.txtnombres.TabIndex = 144;
            // 
            // cbCodDocente
            // 
            this.cbCodDocente.BackColor = System.Drawing.Color.Turquoise;
            this.cbCodDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodDocente.Enabled = false;
            this.cbCodDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodDocente.ForeColor = System.Drawing.Color.White;
            this.cbCodDocente.Location = new System.Drawing.Point(636, 453);
            this.cbCodDocente.MaxDropDownItems = 20;
            this.cbCodDocente.Name = "cbCodDocente";
            this.cbCodDocente.Size = new System.Drawing.Size(87, 24);
            this.cbCodDocente.TabIndex = 143;
            this.cbCodDocente.SelectedIndexChanged += new System.EventHandler(this.cbCodDocente_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(289, 568);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 5);
            this.panel3.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 140;
            this.label4.Text = "Nombre Docente:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(636, 478);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(87, 5);
            this.panel7.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(633, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Cod Docente:";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(462, 478);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(151, 5);
            this.panel13.TabIndex = 137;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(466, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 136;
            this.label12.Text = "Nombre de Asignatura:";
            // 
            // cbCodAsignatura
            // 
            this.cbCodAsignatura.BackColor = System.Drawing.Color.Turquoise;
            this.cbCodAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAsignatura.Enabled = false;
            this.cbCodAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbCodAsignatura.Location = new System.Drawing.Point(289, 454);
            this.cbCodAsignatura.MaxDropDownItems = 20;
            this.cbCodAsignatura.Name = "cbCodAsignatura";
            this.cbCodAsignatura.Size = new System.Drawing.Size(150, 24);
            this.cbCodAsignatura.TabIndex = 135;
            this.cbCodAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbCodAsignatura_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(289, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 5);
            this.panel1.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 133;
            this.label2.Text = "Cod Asignatura:";
            // 
            // cbCodAlumno
            // 
            this.cbCodAlumno.BackColor = System.Drawing.Color.Turquoise;
            this.cbCodAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAlumno.Enabled = false;
            this.cbCodAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAlumno.ForeColor = System.Drawing.Color.White;
            this.cbCodAlumno.Location = new System.Drawing.Point(750, 453);
            this.cbCodAlumno.MaxDropDownItems = 20;
            this.cbCodAlumno.Name = "cbCodAlumno";
            this.cbCodAlumno.Size = new System.Drawing.Size(112, 24);
            this.cbCodAlumno.TabIndex = 132;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(750, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 10);
            this.panel2.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(761, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 130;
            this.label1.Text = "Cod Alumno:";
            // 
            // DetallesAsignAlumnSistema
            // 
            this.DetallesAsignAlumnSistema.AllowUserToAddRows = false;
            this.DetallesAsignAlumnSistema.AllowUserToDeleteRows = false;
            this.DetallesAsignAlumnSistema.AutoGenerateColumns = false;
            this.DetallesAsignAlumnSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesAsignAlumnSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesAsignAlumnSistema.BackgroundColor = System.Drawing.Color.Turquoise;
            this.DetallesAsignAlumnSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesAsignAlumnSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesAsignAlumnSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAsignAlumnSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesAsignAlumnSistema.ColumnHeadersHeight = 35;
            this.DetallesAsignAlumnSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesAsignAlumnSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_AsAlum,
            this.cod_asignatura,
            this.n_asignatura,
            this.cod_docente,
            this.nombreDoc,
            this.cod_alumno});
            this.DetallesAsignAlumnSistema.DataSource = this.asignaturasAlumnosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesAsignAlumnSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesAsignAlumnSistema.EnableHeadersVisualStyles = false;
            this.DetallesAsignAlumnSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesAsignAlumnSistema.Location = new System.Drawing.Point(12, 51);
            this.DetallesAsignAlumnSistema.Name = "DetallesAsignAlumnSistema";
            this.DetallesAsignAlumnSistema.ReadOnly = true;
            this.DetallesAsignAlumnSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAsignAlumnSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DetallesAsignAlumnSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesAsignAlumnSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesAsignAlumnSistema.Size = new System.Drawing.Size(953, 330);
            this.DetallesAsignAlumnSistema.TabIndex = 145;
            // 
            // Id_AsAlum
            // 
            this.Id_AsAlum.DataPropertyName = "Id_AsAlum";
            this.Id_AsAlum.HeaderText = "Id_AsAlum";
            this.Id_AsAlum.Name = "Id_AsAlum";
            this.Id_AsAlum.ReadOnly = true;
            this.Id_AsAlum.Visible = false;
            // 
            // cod_asignatura
            // 
            this.cod_asignatura.DataPropertyName = "cod_asignatura";
            this.cod_asignatura.HeaderText = "cod_asignatura";
            this.cod_asignatura.Name = "cod_asignatura";
            this.cod_asignatura.ReadOnly = true;
            // 
            // n_asignatura
            // 
            this.n_asignatura.DataPropertyName = "n_asignatura";
            this.n_asignatura.HeaderText = "n_asignatura";
            this.n_asignatura.Name = "n_asignatura";
            this.n_asignatura.ReadOnly = true;
            // 
            // cod_docente
            // 
            this.cod_docente.DataPropertyName = "cod_docente";
            this.cod_docente.HeaderText = "cod_docente";
            this.cod_docente.Name = "cod_docente";
            this.cod_docente.ReadOnly = true;
            // 
            // nombreDoc
            // 
            this.nombreDoc.DataPropertyName = "nombreDoc";
            this.nombreDoc.HeaderText = "nombreDoc";
            this.nombreDoc.Name = "nombreDoc";
            this.nombreDoc.ReadOnly = true;
            // 
            // cod_alumno
            // 
            this.cod_alumno.DataPropertyName = "cod_alumno";
            this.cod_alumno.HeaderText = "cod_alumno";
            this.cod_alumno.Name = "cod_alumno";
            this.cod_alumno.ReadOnly = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // SeleccionarRegistroAsignatura
            // 
            this.SeleccionarRegistroAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SeleccionarRegistroAsignatura.FlatAppearance.BorderSize = 0;
            this.SeleccionarRegistroAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionarRegistroAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarRegistroAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeleccionarRegistroAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("SeleccionarRegistroAsignatura.Image")));
            this.SeleccionarRegistroAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeleccionarRegistroAsignatura.Location = new System.Drawing.Point(712, 498);
            this.SeleccionarRegistroAsignatura.Name = "SeleccionarRegistroAsignatura";
            this.SeleccionarRegistroAsignatura.Size = new System.Drawing.Size(253, 40);
            this.SeleccionarRegistroAsignatura.TabIndex = 147;
            this.SeleccionarRegistroAsignatura.Text = "Seleccionar Alumn - Asign";
            this.SeleccionarRegistroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistroAsignatura.UseVisualStyleBackColor = false;
            this.SeleccionarRegistroAsignatura.Click += new System.EventHandler(this.SeleccionarRegistroAsignatura_Click);
            // 
            // asignaturasAlumnosTableAdapter
            // 
            this.asignaturasAlumnosTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.BackColor = System.Drawing.Color.Turquoise;
            this.txtNombreAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAsignatura.Enabled = false;
            this.txtNombreAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombreAsignatura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreAsignatura.Location = new System.Drawing.Point(462, 454);
            this.txtNombreAsignatura.Multiline = true;
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(151, 24);
            this.txtNombreAsignatura.TabIndex = 151;
            // 
            // Modificar_AsignAlumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(977, 619);
            this.Controls.Add(this.txtNombreAsignatura);
            this.Controls.Add(this.SeleccionarRegistroAsignatura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DetallesAsignAlumnSistema);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.cbCodDocente);
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
            this.Controls.Add(this.btnRegistroNuevoAsignatura);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificar_AsignAlumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_AsignAlumn";
            this.Load += new System.EventHandler(this.Modificar_AsignAlumn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Modificar_AsignAlumn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAsignAlumnSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.Button btnRegistroNuevoAsignatura;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.ComboBox cbCodDocente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCodAsignatura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCodAlumno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DetallesAsignAlumnSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SeleccionarRegistroAsignatura;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasAlumnosBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter asignaturasAlumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AsAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alumno;
        private System.Windows.Forms.TextBox txtNombreAsignatura;
    }
}