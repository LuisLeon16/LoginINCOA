namespace LoginINCOA
{
    partial class AsignaturasSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignaturasSistema));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnRegistroNuevoAsignatura = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarAsignatura = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnModificarAsignaturas = new System.Windows.Forms.Button();
            this.DetalleAsignaturasSistema = new System.Windows.Forms.DataGridView();
            this.codasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.asignaturasTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AsignaturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAsignaturasSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(265, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asignaturas Registradas En El Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Registro de Nuevas Asignaturas";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Controls.Add(this.btnModificarAlumnos);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.txtid);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.btnRegistroNuevoAsignatura);
            this.panel9.Controls.Add(this.txtnombre);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(27, 168);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(275, 298);
            this.panel9.TabIndex = 34;
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarAlumnos.BackColor = System.Drawing.Color.Green;
            this.btnModificarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnModificarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlumnos.Location = new System.Drawing.Point(31, 236);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(208, 34);
            this.btnModificarAlumnos.TabIndex = 37;
            this.btnModificarAlumnos.Text = " Ver Asignatura - Alumno";
            this.btnModificarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarAlumnos.UseVisualStyleBackColor = false;
            this.btnModificarAlumnos.Click += new System.EventHandler(this.btnModificarAlumnos_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(14, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 64;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(14, 41);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(185, 35);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID Asignatura:";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(14, 134);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(210, 5);
            this.panel13.TabIndex = 58;
            // 
            // btnRegistroNuevoAsignatura
            // 
            this.btnRegistroNuevoAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRegistroNuevoAsignatura.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoAsignatura.Image")));
            this.btnRegistroNuevoAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoAsignatura.Location = new System.Drawing.Point(9, 167);
            this.btnRegistroNuevoAsignatura.Name = "btnRegistroNuevoAsignatura";
            this.btnRegistroNuevoAsignatura.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoAsignatura.TabIndex = 6;
            this.btnRegistroNuevoAsignatura.Text = "Registrar Nueva Materia";
            this.btnRegistroNuevoAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoAsignatura.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoAsignatura.Click += new System.EventHandler(this.btnRegistroNuevoAsignatura_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombre.Location = new System.Drawing.Point(14, 101);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(210, 35);
            this.txtnombre.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nombre de Asignatura:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnEliminarAsignatura);
            this.panel1.Controls.Add(this.btnActualizarTabla);
            this.panel1.Controls.Add(this.btnModificarAsignaturas);
            this.panel1.Location = new System.Drawing.Point(308, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 115);
            this.panel1.TabIndex = 35;
            // 
            // btnEliminarAsignatura
            // 
            this.btnEliminarAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarAsignatura.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarAsignatura.FlatAppearance.BorderSize = 0;
            this.btnEliminarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarAsignatura.Image")));
            this.btnEliminarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAsignatura.Location = new System.Drawing.Point(267, 33);
            this.btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            this.btnEliminarAsignatura.Size = new System.Drawing.Size(214, 44);
            this.btnEliminarAsignatura.TabIndex = 10;
            this.btnEliminarAsignatura.Text = "Eliminar Asignatura";
            this.btnEliminarAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarAsignatura.UseVisualStyleBackColor = false;
            this.btnEliminarAsignatura.Click += new System.EventHandler(this.btnEliminarAsignatura_Click);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.btnActualizarTabla.FlatAppearance.BorderSize = 0;
            this.btnActualizarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarTabla.Image")));
            this.btnActualizarTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarTabla.Location = new System.Drawing.Point(504, 33);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(214, 44);
            this.btnActualizarTabla.TabIndex = 9;
            this.btnActualizarTabla.Text = "ActualizarTabla";
            this.btnActualizarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarTabla.UseVisualStyleBackColor = false;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // btnModificarAsignaturas
            // 
            this.btnModificarAsignaturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarAsignaturas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarAsignaturas.FlatAppearance.BorderSize = 0;
            this.btnModificarAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAsignaturas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarAsignaturas.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAsignaturas.Image")));
            this.btnModificarAsignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAsignaturas.Location = new System.Drawing.Point(24, 33);
            this.btnModificarAsignaturas.Name = "btnModificarAsignaturas";
            this.btnModificarAsignaturas.Size = new System.Drawing.Size(214, 44);
            this.btnModificarAsignaturas.TabIndex = 7;
            this.btnModificarAsignaturas.Text = "Modificar Asignaturas";
            this.btnModificarAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarAsignaturas.UseVisualStyleBackColor = false;
            this.btnModificarAsignaturas.Click += new System.EventHandler(this.btnModificarAsignaturas_Click);
            // 
            // DetalleAsignaturasSistema
            // 
            this.DetalleAsignaturasSistema.AllowUserToAddRows = false;
            this.DetalleAsignaturasSistema.AllowUserToDeleteRows = false;
            this.DetalleAsignaturasSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleAsignaturasSistema.AutoGenerateColumns = false;
            this.DetalleAsignaturasSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleAsignaturasSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetalleAsignaturasSistema.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.DetalleAsignaturasSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetalleAsignaturasSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetalleAsignaturasSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleAsignaturasSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetalleAsignaturasSistema.ColumnHeadersHeight = 35;
            this.DetalleAsignaturasSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetalleAsignaturasSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codasignaturaDataGridViewTextBoxColumn,
            this.nasignaturaDataGridViewTextBoxColumn});
            this.DetalleAsignaturasSistema.DataSource = this.asignaturasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetalleAsignaturasSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetalleAsignaturasSistema.EnableHeadersVisualStyles = false;
            this.DetalleAsignaturasSistema.GridColor = System.Drawing.Color.Black;
            this.DetalleAsignaturasSistema.Location = new System.Drawing.Point(308, 168);
            this.DetalleAsignaturasSistema.Name = "DetalleAsignaturasSistema";
            this.DetalleAsignaturasSistema.ReadOnly = true;
            this.DetalleAsignaturasSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleAsignaturasSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetalleAsignaturasSistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.DetalleAsignaturasSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetalleAsignaturasSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleAsignaturasSistema.Size = new System.Drawing.Size(743, 354);
            this.DetalleAsignaturasSistema.TabIndex = 36;
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
            this.nasignaturaDataGridViewTextBoxColumn.HeaderText = "Nombre Asignatura";
            this.nasignaturaDataGridViewTextBoxColumn.Name = "nasignaturaDataGridViewTextBoxColumn";
            this.nasignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // AsignaturasSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1066, 534);
            this.Controls.Add(this.DetalleAsignaturasSistema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignaturasSistema";
            this.Text = "AsignaturasSistema";
            this.Load += new System.EventHandler(this.AsignaturasSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAsignaturasSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnRegistroNuevoAsignatura;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnModificarAsignaturas;
        private System.Windows.Forms.Button btnEliminarAsignatura;
        private System.Windows.Forms.DataGridView DetalleAsignaturasSistema;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasignaturaDataGridViewTextBoxColumn;
    }
}