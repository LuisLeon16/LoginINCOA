namespace LoginINCOA
{
    partial class AgregarNotasTrim1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarNotasTrim1));
            this.DetallesTrim1Sistema = new System.Windows.Forms.DataGridView();
            this.codTrimestre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedio1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnRegistroNota = new System.Windows.Forms.Button();
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
            this.txtOculto1 = new System.Windows.Forms.TextBox();
            this.txtOculto2 = new System.Windows.Forms.TextBox();
            this.txtOculto3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesTrim1Sistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestre1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
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
            this.DetallesTrim1Sistema.BackgroundColor = System.Drawing.Color.MediumAquamarine;
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
            this.codTrimestre1DataGridViewTextBoxColumn,
            this.codalumnoDataGridViewTextBoxColumn,
            this.codasignaturaDataGridViewTextBoxColumn,
            this.act1DataGridViewTextBoxColumn,
            this.act2DataGridViewTextBoxColumn,
            this.examDataGridViewTextBoxColumn,
            this.promedio1DataGridViewTextBoxColumn});
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesTrim1Sistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesTrim1Sistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.DetallesTrim1Sistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesTrim1Sistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesTrim1Sistema.Size = new System.Drawing.Size(953, 330);
            this.DetallesTrim1Sistema.TabIndex = 37;
            // 
            // codTrimestre1DataGridViewTextBoxColumn
            // 
            this.codTrimestre1DataGridViewTextBoxColumn.DataPropertyName = "cod_Trimestre1";
            this.codTrimestre1DataGridViewTextBoxColumn.HeaderText = "cod_Trimestre1";
            this.codTrimestre1DataGridViewTextBoxColumn.Name = "codTrimestre1DataGridViewTextBoxColumn";
            this.codTrimestre1DataGridViewTextBoxColumn.ReadOnly = true;
            this.codTrimestre1DataGridViewTextBoxColumn.Visible = false;
            // 
            // codalumnoDataGridViewTextBoxColumn
            // 
            this.codalumnoDataGridViewTextBoxColumn.DataPropertyName = "cod_alumno";
            this.codalumnoDataGridViewTextBoxColumn.HeaderText = "cod_alumno";
            this.codalumnoDataGridViewTextBoxColumn.Name = "codalumnoDataGridViewTextBoxColumn";
            this.codalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codasignaturaDataGridViewTextBoxColumn
            // 
            this.codasignaturaDataGridViewTextBoxColumn.DataPropertyName = "cod_asignatura";
            this.codasignaturaDataGridViewTextBoxColumn.HeaderText = "cod_asignatura";
            this.codasignaturaDataGridViewTextBoxColumn.Name = "codasignaturaDataGridViewTextBoxColumn";
            this.codasignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // act1DataGridViewTextBoxColumn
            // 
            this.act1DataGridViewTextBoxColumn.DataPropertyName = "Act1";
            this.act1DataGridViewTextBoxColumn.HeaderText = "Act1";
            this.act1DataGridViewTextBoxColumn.Name = "act1DataGridViewTextBoxColumn";
            this.act1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // act2DataGridViewTextBoxColumn
            // 
            this.act2DataGridViewTextBoxColumn.DataPropertyName = "Act2";
            this.act2DataGridViewTextBoxColumn.HeaderText = "Act2";
            this.act2DataGridViewTextBoxColumn.Name = "act2DataGridViewTextBoxColumn";
            this.act2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examDataGridViewTextBoxColumn
            // 
            this.examDataGridViewTextBoxColumn.DataPropertyName = "Exam";
            this.examDataGridViewTextBoxColumn.HeaderText = "Exam";
            this.examDataGridViewTextBoxColumn.Name = "examDataGridViewTextBoxColumn";
            this.examDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // promedio1DataGridViewTextBoxColumn
            // 
            this.promedio1DataGridViewTextBoxColumn.DataPropertyName = "promedio1";
            this.promedio1DataGridViewTextBoxColumn.HeaderText = "Promedio1";
            this.promedio1DataGridViewTextBoxColumn.Name = "promedio1DataGridViewTextBoxColumn";
            this.promedio1DataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel2.Location = new System.Drawing.Point(270, 482);
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
            this.label1.Location = new System.Drawing.Point(281, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Cod Alumno:";
            // 
            // pictureBox1
            // 
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
            this.panel1.Location = new System.Drawing.Point(405, 482);
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
            this.label2.Location = new System.Drawing.Point(444, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cod Asignatura:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(618, 482);
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
            this.label6.Location = new System.Drawing.Point(626, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Act1:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(699, 482);
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
            this.label3.Location = new System.Drawing.Point(707, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Act2:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(861, 482);
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
            this.label5.Location = new System.Drawing.Point(852, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Promedio:";
            // 
            // btnRegistroNota
            // 
            this.btnRegistroNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNota.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistroNota.FlatAppearance.BorderSize = 0;
            this.btnRegistroNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNota.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNota.Image")));
            this.btnRegistroNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNota.Location = new System.Drawing.Point(629, 545);
            this.btnRegistroNota.Name = "btnRegistroNota";
            this.btnRegistroNota.Size = new System.Drawing.Size(208, 34);
            this.btnRegistroNota.TabIndex = 8;
            this.btnRegistroNota.Text = "Registrar Nota";
            this.btnRegistroNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNota.UseVisualStyleBackColor = false;
            this.btnRegistroNota.Click += new System.EventHandler(this.btnRegistroNota_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularPromedio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalcularPromedio.FlatAppearance.BorderSize = 0;
            this.btnCalcularPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPromedio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcularPromedio.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularPromedio.Image")));
            this.btnCalcularPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularPromedio.Location = new System.Drawing.Point(334, 545);
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
            this.label7.Size = new System.Drawing.Size(243, 18);
            this.label7.TabIndex = 94;
            this.label7.Text = "Registro de Notas Primer Trimestre";
            // 
            // cbCodAsignatura
            // 
            this.cbCodAsignatura.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbCodAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAsignatura.ForeColor = System.Drawing.Color.White;
            this.cbCodAsignatura.Location = new System.Drawing.Point(405, 458);
            this.cbCodAsignatura.MaxDropDownItems = 20;
            this.cbCodAsignatura.Name = "cbCodAsignatura";
            this.cbCodAsignatura.Size = new System.Drawing.Size(185, 24);
            this.cbCodAsignatura.TabIndex = 96;
            // 
            // cbCodAlumno
            // 
            this.cbCodAlumno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbCodAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodAlumno.ForeColor = System.Drawing.Color.White;
            this.cbCodAlumno.Location = new System.Drawing.Point(270, 458);
            this.cbCodAlumno.MaxDropDownItems = 20;
            this.cbCodAlumno.Name = "cbCodAlumno";
            this.cbCodAlumno.Size = new System.Drawing.Size(112, 24);
            this.cbCodAlumno.TabIndex = 95;
            this.cbCodAlumno.SelectedIndexChanged += new System.EventHandler(this.cbCodAlumno_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(783, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Exam:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(780, 482);
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
            this.mtxtPromedio.Location = new System.Drawing.Point(861, 452);
            this.mtxtPromedio.Mask = "0,0";
            this.mtxtPromedio.Name = "mtxtPromedio";
            this.mtxtPromedio.Size = new System.Drawing.Size(51, 32);
            this.mtxtPromedio.TabIndex = 97;
            this.mtxtPromedio.Visible = false;
            // 
            // txtAct1
            // 
            this.txtAct1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAct1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtAct1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAct1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAct1.Location = new System.Drawing.Point(618, 447);
            this.txtAct1.Multiline = true;
            this.txtAct1.Name = "txtAct1";
            this.txtAct1.Size = new System.Drawing.Size(54, 35);
            this.txtAct1.TabIndex = 98;
            // 
            // txtAct2
            // 
            this.txtAct2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAct2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtAct2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAct2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAct2.Location = new System.Drawing.Point(699, 447);
            this.txtAct2.Multiline = true;
            this.txtAct2.Name = "txtAct2";
            this.txtAct2.Size = new System.Drawing.Size(54, 35);
            this.txtAct2.TabIndex = 99;
            // 
            // txtExam
            // 
            this.txtExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExam.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExam.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExam.Location = new System.Drawing.Point(780, 447);
            this.txtExam.Multiline = true;
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(54, 35);
            this.txtExam.TabIndex = 100;
            // 
            // txtPromedio2
            // 
            this.txtPromedio2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPromedio2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPromedio2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPromedio2.Enabled = false;
            this.txtPromedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPromedio2.Location = new System.Drawing.Point(861, 448);
            this.txtPromedio2.Multiline = true;
            this.txtPromedio2.Name = "txtPromedio2";
            this.txtPromedio2.Size = new System.Drawing.Size(51, 35);
            this.txtPromedio2.TabIndex = 101;
            // 
            // txtOculto1
            // 
            this.txtOculto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOculto1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtOculto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOculto1.Enabled = false;
            this.txtOculto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOculto1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOculto1.Location = new System.Drawing.Point(270, 492);
            this.txtOculto1.Multiline = true;
            this.txtOculto1.Name = "txtOculto1";
            this.txtOculto1.Size = new System.Drawing.Size(113, 26);
            this.txtOculto1.TabIndex = 102;
            this.txtOculto1.Visible = false;
            // 
            // txtOculto2
            // 
            this.txtOculto2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOculto2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtOculto2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOculto2.Enabled = false;
            this.txtOculto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOculto2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOculto2.Location = new System.Drawing.Point(405, 493);
            this.txtOculto2.Multiline = true;
            this.txtOculto2.Name = "txtOculto2";
            this.txtOculto2.Size = new System.Drawing.Size(185, 24);
            this.txtOculto2.TabIndex = 103;
            this.txtOculto2.Visible = false;
            // 
            // txtOculto3
            // 
            this.txtOculto3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOculto3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtOculto3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOculto3.Enabled = false;
            this.txtOculto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOculto3.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOculto3.Location = new System.Drawing.Point(861, 491);
            this.txtOculto3.Multiline = true;
            this.txtOculto3.Name = "txtOculto3";
            this.txtOculto3.Size = new System.Drawing.Size(51, 35);
            this.txtOculto3.TabIndex = 104;
            this.txtOculto3.Visible = false;
            // 
            // AgregarNotasTrim1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(977, 619);
            this.Controls.Add(this.txtOculto3);
            this.Controls.Add(this.txtOculto2);
            this.Controls.Add(this.txtOculto1);
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
            this.Controls.Add(this.btnRegistroNota);
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
            this.Name = "AgregarNotasTrim1";
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
        private System.Windows.Forms.Button btnRegistroNota;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codTrimestre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn act1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn act2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio1DataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mtxtPromedio;
        private System.Windows.Forms.TextBox txtAct1;
        private System.Windows.Forms.TextBox txtAct2;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.TextBox txtPromedio2;
        private System.Windows.Forms.TextBox txtOculto1;
        private System.Windows.Forms.TextBox txtOculto2;
        private System.Windows.Forms.TextBox txtOculto3;
    }
}