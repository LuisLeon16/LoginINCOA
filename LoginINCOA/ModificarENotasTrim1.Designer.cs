namespace LoginINCOA
{
    partial class ModificarENotasTrim1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarENotasTrim1));
            this.DetallesTrim1Sistema = new System.Windows.Forms.DataGridView();
            this.cod_Trimestre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Act1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Act2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimestre1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCodAsignatura = new System.Windows.Forms.ComboBox();
            this.cbCodAlumno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trimestre1TableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.Trimestre1TableAdapter();
            this.mtxtPromedio = new System.Windows.Forms.MaskedTextBox();
            this.txtAct1 = new System.Windows.Forms.TextBox();
            this.txtAct2 = new System.Windows.Forms.TextBox();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.txtPromedio2 = new System.Windows.Forms.TextBox();
            this.SeleccionarRegistroAsignatura = new System.Windows.Forms.Button();
            this.EliminarRegistrosNota = new System.Windows.Forms.Button();
            this.pctBuscador = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesTrim1Sistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestre1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallesTrim1Sistema
            // 
            this.DetallesTrim1Sistema.AllowUserToAddRows = false;
            this.DetallesTrim1Sistema.AllowUserToDeleteRows = false;
            this.DetallesTrim1Sistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesTrim1Sistema.AutoGenerateColumns = false;
            this.DetallesTrim1Sistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesTrim1Sistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesTrim1Sistema.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DetallesTrim1Sistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesTrim1Sistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesTrim1Sistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesTrim1Sistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesTrim1Sistema.ColumnHeadersHeight = 35;
            this.DetallesTrim1Sistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesTrim1Sistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Trimestre1,
            this.cod_alumno,
            this.cod_asignatura,
            this.Act1,
            this.Act2,
            this.Exam,
            this.promedio1});
            this.DetallesTrim1Sistema.DataSource = this.trimestre1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesTrim1Sistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesTrim1Sistema.EnableHeadersVisualStyles = false;
            this.DetallesTrim1Sistema.GridColor = System.Drawing.Color.Black;
            this.DetallesTrim1Sistema.Location = new System.Drawing.Point(12, 51);
            this.DetallesTrim1Sistema.Name = "DetallesTrim1Sistema";
            this.DetallesTrim1Sistema.ReadOnly = true;
            this.DetallesTrim1Sistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesTrim1Sistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesTrim1Sistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DetallesTrim1Sistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesTrim1Sistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesTrim1Sistema.Size = new System.Drawing.Size(953, 330);
            this.DetallesTrim1Sistema.TabIndex = 37;
            // 
            // cod_Trimestre1
            // 
            this.cod_Trimestre1.DataPropertyName = "cod_Trimestre1";
            this.cod_Trimestre1.HeaderText = "cod_Trimestre1";
            this.cod_Trimestre1.Name = "cod_Trimestre1";
            this.cod_Trimestre1.ReadOnly = true;
            this.cod_Trimestre1.Visible = false;
            // 
            // cod_alumno
            // 
            this.cod_alumno.DataPropertyName = "cod_alumno";
            this.cod_alumno.HeaderText = "cod_alumno";
            this.cod_alumno.Name = "cod_alumno";
            this.cod_alumno.ReadOnly = true;
            // 
            // cod_asignatura
            // 
            this.cod_asignatura.DataPropertyName = "cod_asignatura";
            this.cod_asignatura.HeaderText = "cod_asignatura";
            this.cod_asignatura.Name = "cod_asignatura";
            this.cod_asignatura.ReadOnly = true;
            // 
            // Act1
            // 
            this.Act1.DataPropertyName = "Act1";
            this.Act1.HeaderText = "Act1";
            this.Act1.Name = "Act1";
            this.Act1.ReadOnly = true;
            // 
            // Act2
            // 
            this.Act2.DataPropertyName = "Act2";
            this.Act2.HeaderText = "Act2";
            this.Act2.Name = "Act2";
            this.Act2.ReadOnly = true;
            // 
            // Exam
            // 
            this.Exam.DataPropertyName = "Exam";
            this.Exam.HeaderText = "Exam";
            this.Exam.Name = "Exam";
            this.Exam.ReadOnly = true;
            // 
            // promedio1
            // 
            this.promedio1.DataPropertyName = "promedio1";
            this.promedio1.HeaderText = "Promedio1";
            this.promedio1.Name = "promedio1";
            this.promedio1.ReadOnly = true;
            // 
            // trimestre1BindingSource
            // 
            this.trimestre1BindingSource.DataMember = "Trimestre1";
            this.trimestre1BindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(270, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 5);
            this.panel2.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Cod Alumno:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(405, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 5);
            this.panel1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(444, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cod Asignatura:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(618, 498);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 5);
            this.panel6.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(626, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Act1:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(699, 498);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 5);
            this.panel3.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(707, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Act2:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(861, 498);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(51, 5);
            this.panel5.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(852, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Promedio:";
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarNota.BackColor = System.Drawing.Color.ForestGreen;
            this.btnModificarNota.Enabled = false;
            this.btnModificarNota.FlatAppearance.BorderSize = 0;
            this.btnModificarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarNota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarNota.Image")));
            this.btnModificarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarNota.Location = new System.Drawing.Point(657, 550);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(208, 34);
            this.btnModificarNota.TabIndex = 8;
            this.btnModificarNota.Text = "Modificar Nota";
            this.btnModificarNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarNota.UseVisualStyleBackColor = false;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularPromedio.BackColor = System.Drawing.Color.Orchid;
            this.btnCalcularPromedio.Enabled = false;
            this.btnCalcularPromedio.FlatAppearance.BorderSize = 0;
            this.btnCalcularPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPromedio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcularPromedio.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularPromedio.Image")));
            this.btnCalcularPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularPromedio.Location = new System.Drawing.Point(689, 387);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(208, 34);
            this.btnCalcularPromedio.TabIndex = 7;
            this.btnCalcularPromedio.Text = "Calcular Prom.";
            this.btnCalcularPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularPromedio.UseVisualStyleBackColor = false;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
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
            this.CerrarVentana.TabIndex = 90;
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
            this.MinimizarVentana.TabIndex = 89;
            this.MinimizarVentana.TabStop = false;
            this.MinimizarVentana.Click += new System.EventHandler(this.MinimizarVentana_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 18);
            this.label7.TabIndex = 94;
            this.label7.Text = "Modificación y/o Eliminación de Notas Primer Trimestre";
            // 
            // cbCodAsignatura
            // 
            this.cbCodAsignatura.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cbCodAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAsignatura.Enabled = false;
            this.cbCodAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbCodAsignatura.Location = new System.Drawing.Point(405, 474);
            this.cbCodAsignatura.MaxDropDownItems = 20;
            this.cbCodAsignatura.Name = "cbCodAsignatura";
            this.cbCodAsignatura.Size = new System.Drawing.Size(185, 24);
            this.cbCodAsignatura.TabIndex = 96;
            // 
            // cbCodAlumno
            // 
            this.cbCodAlumno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cbCodAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAlumno.Enabled = false;
            this.cbCodAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAlumno.ForeColor = System.Drawing.Color.White;
            this.cbCodAlumno.Location = new System.Drawing.Point(270, 474);
            this.cbCodAlumno.MaxDropDownItems = 20;
            this.cbCodAlumno.Name = "cbCodAlumno";
            this.cbCodAlumno.Size = new System.Drawing.Size(112, 24);
            this.cbCodAlumno.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(783, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Exam:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(780, 498);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 5);
            this.panel4.TabIndex = 82;
            // 
            // trimestre1TableAdapter
            // 
            this.trimestre1TableAdapter.ClearBeforeFill = true;
            // 
            // mtxtPromedio
            // 
            this.mtxtPromedio.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mtxtPromedio.Enabled = false;
            this.mtxtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mtxtPromedio.ForeColor = System.Drawing.Color.White;
            this.mtxtPromedio.Location = new System.Drawing.Point(861, 468);
            this.mtxtPromedio.Mask = "0,0";
            this.mtxtPromedio.Name = "mtxtPromedio";
            this.mtxtPromedio.Size = new System.Drawing.Size(51, 32);
            this.mtxtPromedio.TabIndex = 97;
            this.mtxtPromedio.Visible = false;
            // 
            // txtAct1
            // 
            this.txtAct1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAct1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtAct1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAct1.Enabled = false;
            this.txtAct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAct1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAct1.Location = new System.Drawing.Point(618, 463);
            this.txtAct1.Multiline = true;
            this.txtAct1.Name = "txtAct1";
            this.txtAct1.Size = new System.Drawing.Size(54, 35);
            this.txtAct1.TabIndex = 98;
            // 
            // txtAct2
            // 
            this.txtAct2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAct2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtAct2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAct2.Enabled = false;
            this.txtAct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAct2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAct2.Location = new System.Drawing.Point(699, 463);
            this.txtAct2.Multiline = true;
            this.txtAct2.Name = "txtAct2";
            this.txtAct2.Size = new System.Drawing.Size(54, 35);
            this.txtAct2.TabIndex = 99;
            // 
            // txtExam
            // 
            this.txtExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExam.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExam.Enabled = false;
            this.txtExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExam.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExam.Location = new System.Drawing.Point(780, 463);
            this.txtExam.Multiline = true;
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(54, 35);
            this.txtExam.TabIndex = 100;
            // 
            // txtPromedio2
            // 
            this.txtPromedio2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPromedio2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtPromedio2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPromedio2.Enabled = false;
            this.txtPromedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPromedio2.Location = new System.Drawing.Point(861, 464);
            this.txtPromedio2.Multiline = true;
            this.txtPromedio2.Name = "txtPromedio2";
            this.txtPromedio2.Size = new System.Drawing.Size(51, 35);
            this.txtPromedio2.TabIndex = 101;
            // 
            // SeleccionarRegistroAsignatura
            // 
            this.SeleccionarRegistroAsignatura.BackColor = System.Drawing.Color.DodgerBlue;
            this.SeleccionarRegistroAsignatura.Enabled = false;
            this.SeleccionarRegistroAsignatura.FlatAppearance.BorderSize = 0;
            this.SeleccionarRegistroAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionarRegistroAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarRegistroAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeleccionarRegistroAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("SeleccionarRegistroAsignatura.Image")));
            this.SeleccionarRegistroAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeleccionarRegistroAsignatura.Location = new System.Drawing.Point(445, 387);
            this.SeleccionarRegistroAsignatura.Name = "SeleccionarRegistroAsignatura";
            this.SeleccionarRegistroAsignatura.Size = new System.Drawing.Size(218, 34);
            this.SeleccionarRegistroAsignatura.TabIndex = 120;
            this.SeleccionarRegistroAsignatura.Text = "Seleccionar Nota";
            this.SeleccionarRegistroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistroAsignatura.UseVisualStyleBackColor = false;
            this.SeleccionarRegistroAsignatura.Click += new System.EventHandler(this.SeleccionarRegistroAsignatura_Click);
            // 
            // EliminarRegistrosNota
            // 
            this.EliminarRegistrosNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarRegistrosNota.BackColor = System.Drawing.Color.Brown;
            this.EliminarRegistrosNota.Enabled = false;
            this.EliminarRegistrosNota.FlatAppearance.BorderSize = 0;
            this.EliminarRegistrosNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRegistrosNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarRegistrosNota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarRegistrosNota.Image = ((System.Drawing.Image)(resources.GetObject("EliminarRegistrosNota.Image")));
            this.EliminarRegistrosNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarRegistrosNota.Location = new System.Drawing.Point(368, 550);
            this.EliminarRegistrosNota.Name = "EliminarRegistrosNota";
            this.EliminarRegistrosNota.Size = new System.Drawing.Size(205, 34);
            this.EliminarRegistrosNota.TabIndex = 121;
            this.EliminarRegistrosNota.Text = "Eliminar Nota";
            this.EliminarRegistrosNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarRegistrosNota.UseVisualStyleBackColor = false;
            this.EliminarRegistrosNota.Click += new System.EventHandler(this.EliminarRegistrosNota_Click);
            // 
            // pctBuscador
            // 
            this.pctBuscador.BackColor = System.Drawing.Color.Teal;
            this.pctBuscador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pctBuscador.Image")));
            this.pctBuscador.Location = new System.Drawing.Point(223, 387);
            this.pctBuscador.Name = "pctBuscador";
            this.pctBuscador.Size = new System.Drawing.Size(60, 34);
            this.pctBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBuscador.TabIndex = 123;
            this.pctBuscador.TabStop = false;
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBuscador.ForeColor = System.Drawing.Color.White;
            this.txtBuscador.Location = new System.Drawing.Point(284, 387);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(135, 34);
            this.txtBuscador.TabIndex = 122;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(347, 562);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(15, 14);
            this.chkEliminar.TabIndex = 124;
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Location = new System.Drawing.Point(636, 562);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(15, 14);
            this.chkModificar.TabIndex = 125;
            this.chkModificar.UseVisualStyleBackColor = true;
            this.chkModificar.CheckedChanged += new System.EventHandler(this.chkModificar_CheckedChanged);
            // 
            // ModificarENotasTrim1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(977, 618);
            this.Controls.Add(this.chkModificar);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.pctBuscador);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.EliminarRegistrosNota);
            this.Controls.Add(this.SeleccionarRegistroAsignatura);
            this.Controls.Add(this.txtPromedio2);
            this.Controls.Add(this.txtExam);
            this.Controls.Add(this.txtAct2);
            this.Controls.Add(this.txtAct1);
            this.Controls.Add(this.mtxtPromedio);
            this.Controls.Add(this.cbCodAsignatura);
            this.Controls.Add(this.cbCodAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.btnModificarNota);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetallesTrim1Sistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarENotasTrim1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarNotas";
            this.Load += new System.EventHandler(this.AgregarNotasTrim1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgregarNotasTrim1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesTrim1Sistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestre1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DetallesTrim1Sistema;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificarNota;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCodAsignatura;
        private System.Windows.Forms.ComboBox cbCodAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource trimestre1BindingSource;
        private incoa_systemdbDataSetTableAdapters.Trimestre1TableAdapter trimestre1TableAdapter;
        private System.Windows.Forms.MaskedTextBox mtxtPromedio;
        private System.Windows.Forms.TextBox txtAct1;
        private System.Windows.Forms.TextBox txtAct2;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.TextBox txtPromedio2;
        private System.Windows.Forms.Button SeleccionarRegistroAsignatura;
        private System.Windows.Forms.Button EliminarRegistrosNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Trimestre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio1;
        private System.Windows.Forms.PictureBox pctBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkModificar;
    }
}