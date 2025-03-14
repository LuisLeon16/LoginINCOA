namespace LoginINCOA
{
    partial class Eliminar_AsignAlumn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_AsignAlumn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.DetallesAlumnAsignSistema = new System.Windows.Forms.DataGridView();
            this.asignaturasAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.asignaturasAlumnosTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Id_AlumAs = new System.Windows.Forms.Label();
            this.SeleccionarRegistroAsignatura = new System.Windows.Forms.Button();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.cbCodDocente = new System.Windows.Forms.ComboBox();
            this.cbNomAsignatura = new System.Windows.Forms.ComboBox();
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
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id_AsAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumnAsignSistema)).BeginInit();
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
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 18);
            this.label7.TabIndex = 112;
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
            this.MinimizarVentana.TabIndex = 113;
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
            this.CerrarVentana.TabIndex = 114;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // DetallesAlumnAsignSistema
            // 
            this.DetallesAlumnAsignSistema.AllowUserToAddRows = false;
            this.DetallesAlumnAsignSistema.AllowUserToDeleteRows = false;
            this.DetallesAlumnAsignSistema.AutoGenerateColumns = false;
            this.DetallesAlumnAsignSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesAlumnAsignSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesAlumnAsignSistema.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DetallesAlumnAsignSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesAlumnAsignSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesAlumnAsignSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumnAsignSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesAlumnAsignSistema.ColumnHeadersHeight = 35;
            this.DetallesAlumnAsignSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesAlumnAsignSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_AsAlum,
            this.cod_asignatura,
            this.n_asignatura,
            this.cod_docente,
            this.nombreDoc,
            this.cod_alumno});
            this.DetallesAlumnAsignSistema.DataSource = this.asignaturasAlumnosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesAlumnAsignSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesAlumnAsignSistema.EnableHeadersVisualStyles = false;
            this.DetallesAlumnAsignSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesAlumnAsignSistema.Location = new System.Drawing.Point(12, 51);
            this.DetallesAlumnAsignSistema.Name = "DetallesAlumnAsignSistema";
            this.DetallesAlumnAsignSistema.ReadOnly = true;
            this.DetallesAlumnAsignSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumnAsignSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.DetallesAlumnAsignSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesAlumnAsignSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesAlumnAsignSistema.Size = new System.Drawing.Size(953, 330);
            this.DetallesAlumnAsignSistema.TabIndex = 115;
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
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(848, 457);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(98, 25);
            this.txtid.TabIndex = 170;
            this.txtid.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(848, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 5);
            this.panel4.TabIndex = 169;
            this.panel4.Visible = false;
            // 
            // Id_AlumAs
            // 
            this.Id_AlumAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Id_AlumAs.AutoSize = true;
            this.Id_AlumAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_AlumAs.ForeColor = System.Drawing.Color.White;
            this.Id_AlumAs.Location = new System.Drawing.Point(845, 409);
            this.Id_AlumAs.Name = "Id_AlumAs";
            this.Id_AlumAs.Size = new System.Drawing.Size(106, 16);
            this.Id_AlumAs.TabIndex = 168;
            this.Id_AlumAs.Text = "Cod. Asignatura:";
            this.Id_AlumAs.Visible = false;
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
            this.SeleccionarRegistroAsignatura.Location = new System.Drawing.Point(703, 502);
            this.SeleccionarRegistroAsignatura.Name = "SeleccionarRegistroAsignatura";
            this.SeleccionarRegistroAsignatura.Size = new System.Drawing.Size(253, 40);
            this.SeleccionarRegistroAsignatura.TabIndex = 167;
            this.SeleccionarRegistroAsignatura.Text = "Seleccionar Alumn - Asign";
            this.SeleccionarRegistroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistroAsignatura.UseVisualStyleBackColor = false;
            this.SeleccionarRegistroAsignatura.Click += new System.EventHandler(this.SeleccionarRegistroAsignatura_Click);
            // 
            // txtnombres
            // 
            this.txtnombres.BackColor = System.Drawing.Color.White;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Enabled = false;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtnombres.ForeColor = System.Drawing.Color.Black;
            this.txtnombres.Location = new System.Drawing.Point(280, 547);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(360, 24);
            this.txtnombres.TabIndex = 166;
            // 
            // cbCodDocente
            // 
            this.cbCodDocente.BackColor = System.Drawing.Color.White;
            this.cbCodDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodDocente.Enabled = false;
            this.cbCodDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodDocente.ForeColor = System.Drawing.Color.Black;
            this.cbCodDocente.Location = new System.Drawing.Point(602, 457);
            this.cbCodDocente.MaxDropDownItems = 20;
            this.cbCodDocente.Name = "cbCodDocente";
            this.cbCodDocente.Size = new System.Drawing.Size(87, 24);
            this.cbCodDocente.TabIndex = 165;
            this.cbCodDocente.SelectedIndexChanged += new System.EventHandler(this.cbCodDocente_SelectedIndexChanged);
            // 
            // cbNomAsignatura
            // 
            this.cbNomAsignatura.BackColor = System.Drawing.Color.White;
            this.cbNomAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomAsignatura.Enabled = false;
            this.cbNomAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNomAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomAsignatura.ForeColor = System.Drawing.Color.Black;
            this.cbNomAsignatura.Location = new System.Drawing.Point(439, 458);
            this.cbNomAsignatura.MaxDropDownItems = 20;
            this.cbNomAsignatura.Name = "cbNomAsignatura";
            this.cbNomAsignatura.Size = new System.Drawing.Size(151, 24);
            this.cbNomAsignatura.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(280, 572);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 5);
            this.panel3.TabIndex = 163;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 162;
            this.label4.Text = "Nombre Docente:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(602, 482);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(87, 5);
            this.panel7.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(599, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 160;
            this.label3.Text = "Cod Docente:";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(439, 482);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(151, 5);
            this.panel13.TabIndex = 159;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(443, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 158;
            this.label12.Text = "Nombre de Asignatura:";
            // 
            // cbCodAsignatura
            // 
            this.cbCodAsignatura.BackColor = System.Drawing.Color.White;
            this.cbCodAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAsignatura.Enabled = false;
            this.cbCodAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAsignatura.ForeColor = System.Drawing.Color.Black;
            this.cbCodAsignatura.Location = new System.Drawing.Point(280, 458);
            this.cbCodAsignatura.MaxDropDownItems = 20;
            this.cbCodAsignatura.Name = "cbCodAsignatura";
            this.cbCodAsignatura.Size = new System.Drawing.Size(150, 24);
            this.cbCodAsignatura.TabIndex = 157;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(280, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 5);
            this.panel1.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 155;
            this.label2.Text = "Cod Asignatura:";
            // 
            // cbCodAlumno
            // 
            this.cbCodAlumno.BackColor = System.Drawing.Color.White;
            this.cbCodAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAlumno.Enabled = false;
            this.cbCodAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAlumno.ForeColor = System.Drawing.Color.Black;
            this.cbCodAlumno.Location = new System.Drawing.Point(716, 457);
            this.cbCodAlumno.MaxDropDownItems = 20;
            this.cbCodAlumno.Name = "cbCodAlumno";
            this.cbCodAlumno.Size = new System.Drawing.Size(112, 24);
            this.cbCodAlumno.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(716, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 10);
            this.panel2.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(727, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 152;
            this.label1.Text = "Cod Alumno:";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarRegistro.FlatAppearance.BorderSize = 0;
            this.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRegistro.Image")));
            this.btnEliminarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(703, 559);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(253, 40);
            this.btnEliminarRegistro.TabIndex = 151;
            this.btnEliminarRegistro.Text = "Eliminar Alumn - Asign";
            this.btnEliminarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 171;
            this.pictureBox1.TabStop = false;
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
            // Eliminar_AsignAlumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(977, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Id_AlumAs);
            this.Controls.Add(this.SeleccionarRegistroAsignatura);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.cbCodDocente);
            this.Controls.Add(this.cbNomAsignatura);
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
            this.Controls.Add(this.btnEliminarRegistro);
            this.Controls.Add(this.DetallesAlumnAsignSistema);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar_AsignAlumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar_AsignAlumn";
            this.Load += new System.EventHandler(this.Eliminar_AsignAlumn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Eliminar_AsignAlumn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumnAsignSistema)).EndInit();
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
        private System.Windows.Forms.DataGridView DetallesAlumnAsignSistema;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasAlumnosBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter asignaturasAlumnosTableAdapter;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Id_AlumAs;
        private System.Windows.Forms.Button SeleccionarRegistroAsignatura;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.ComboBox cbCodDocente;
        private System.Windows.Forms.ComboBox cbNomAsignatura;
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
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AsAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alumno;
    }
}