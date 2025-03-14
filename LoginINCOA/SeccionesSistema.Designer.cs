namespace LoginINCOA
{
    partial class SeccionesSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeccionesSistema));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarSecciones = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnModificarSecciones = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnRegistroNuevoSeccion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombreSeccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetallesSeccionesSistema = new System.Windows.Forms.DataGridView();
            this.codseccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.seccionesTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.SeccionesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSeccionesSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnEliminarSecciones);
            this.panel1.Controls.Add(this.btnActualizarTabla);
            this.panel1.Controls.Add(this.btnModificarSecciones);
            this.panel1.Location = new System.Drawing.Point(304, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 115);
            this.panel1.TabIndex = 41;
            // 
            // btnEliminarSecciones
            // 
            this.btnEliminarSecciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarSecciones.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarSecciones.FlatAppearance.BorderSize = 0;
            this.btnEliminarSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSecciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarSecciones.Image")));
            this.btnEliminarSecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarSecciones.Location = new System.Drawing.Point(263, 33);
            this.btnEliminarSecciones.Name = "btnEliminarSecciones";
            this.btnEliminarSecciones.Size = new System.Drawing.Size(214, 44);
            this.btnEliminarSecciones.TabIndex = 5;
            this.btnEliminarSecciones.Text = "Eliminar Secciones";
            this.btnEliminarSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarSecciones.UseVisualStyleBackColor = false;
            this.btnEliminarSecciones.Click += new System.EventHandler(this.btnEliminarSecciones_Click);
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
            this.btnActualizarTabla.TabIndex = 6;
            this.btnActualizarTabla.Text = "ActualizarTabla";
            this.btnActualizarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarTabla.UseVisualStyleBackColor = false;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // btnModificarSecciones
            // 
            this.btnModificarSecciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarSecciones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarSecciones.FlatAppearance.BorderSize = 0;
            this.btnModificarSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSecciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarSecciones.Image")));
            this.btnModificarSecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarSecciones.Location = new System.Drawing.Point(24, 33);
            this.btnModificarSecciones.Name = "btnModificarSecciones";
            this.btnModificarSecciones.Size = new System.Drawing.Size(214, 44);
            this.btnModificarSecciones.TabIndex = 4;
            this.btnModificarSecciones.Text = "Modificar Secciones";
            this.btnModificarSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarSecciones.UseVisualStyleBackColor = false;
            this.btnModificarSecciones.Click += new System.EventHandler(this.btnModificarSecciones_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txtCapacidad);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.txtIdSeccion);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.btnRegistroNuevoSeccion);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.txtnombreSeccion);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.txtSeccion);
            this.panel9.Location = new System.Drawing.Point(23, 170);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(275, 354);
            this.panel9.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(30, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 5);
            this.panel3.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapacidad.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCapacidad.Location = new System.Drawing.Point(30, 243);
            this.txtCapacidad.Multiline = true;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(185, 35);
            this.txtCapacidad.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(30, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 64;
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdSeccion.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtIdSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIdSeccion.Location = new System.Drawing.Point(30, 34);
            this.txtIdSeccion.Multiline = true;
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.Size = new System.Drawing.Size(185, 35);
            this.txtIdSeccion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID Seccion:";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(30, 208);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(185, 5);
            this.panel12.TabIndex = 61;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(30, 142);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(185, 5);
            this.panel13.TabIndex = 58;
            // 
            // btnRegistroNuevoSeccion
            // 
            this.btnRegistroNuevoSeccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroNuevoSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRegistroNuevoSeccion.FlatAppearance.BorderSize = 0;
            this.btnRegistroNuevoSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNuevoSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNuevoSeccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistroNuevoSeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroNuevoSeccion.Image")));
            this.btnRegistroNuevoSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNuevoSeccion.Location = new System.Drawing.Point(14, 294);
            this.btnRegistroNuevoSeccion.Name = "btnRegistroNuevoSeccion";
            this.btnRegistroNuevoSeccion.Size = new System.Drawing.Size(253, 40);
            this.btnRegistroNuevoSeccion.TabIndex = 6;
            this.btnRegistroNuevoSeccion.Text = "Registrar Nueva Sección";
            this.btnRegistroNuevoSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroNuevoSeccion.UseVisualStyleBackColor = false;
            this.btnRegistroNuevoSeccion.Click += new System.EventHandler(this.btnRegistroNuevoSeccion_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Seccion:";
            // 
            // txtnombreSeccion
            // 
            this.txtnombreSeccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombreSeccion.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtnombreSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreSeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombreSeccion.Location = new System.Drawing.Point(30, 112);
            this.txtnombreSeccion.Multiline = true;
            this.txtnombreSeccion.Name = "txtnombreSeccion";
            this.txtnombreSeccion.Size = new System.Drawing.Size(210, 35);
            this.txtnombreSeccion.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(27, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nombre de Seccion:";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeccion.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSeccion.Location = new System.Drawing.Point(30, 175);
            this.txtSeccion.Multiline = true;
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(185, 35);
            this.txtSeccion.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Registro de Nuevas Secciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Secciones Registradas En El Sistema";
            // 
            // DetallesSeccionesSistema
            // 
            this.DetallesSeccionesSistema.AllowUserToAddRows = false;
            this.DetallesSeccionesSistema.AllowUserToDeleteRows = false;
            this.DetallesSeccionesSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesSeccionesSistema.AutoGenerateColumns = false;
            this.DetallesSeccionesSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesSeccionesSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesSeccionesSistema.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.DetallesSeccionesSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesSeccionesSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesSeccionesSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSeccionesSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesSeccionesSistema.ColumnHeadersHeight = 35;
            this.DetallesSeccionesSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesSeccionesSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codseccionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.seccionDataGridViewTextBoxColumn,
            this.capacidadDataGridViewTextBoxColumn});
            this.DetallesSeccionesSistema.DataSource = this.seccionesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesSeccionesSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesSeccionesSistema.EnableHeadersVisualStyles = false;
            this.DetallesSeccionesSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesSeccionesSistema.Location = new System.Drawing.Point(304, 170);
            this.DetallesSeccionesSistema.Name = "DetallesSeccionesSistema";
            this.DetallesSeccionesSistema.ReadOnly = true;
            this.DetallesSeccionesSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSeccionesSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesSeccionesSistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.DetallesSeccionesSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesSeccionesSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesSeccionesSistema.Size = new System.Drawing.Size(743, 354);
            this.DetallesSeccionesSistema.TabIndex = 42;
            // 
            // codseccionDataGridViewTextBoxColumn
            // 
            this.codseccionDataGridViewTextBoxColumn.DataPropertyName = "cod_seccion";
            this.codseccionDataGridViewTextBoxColumn.HeaderText = "cod_seccion";
            this.codseccionDataGridViewTextBoxColumn.Name = "codseccionDataGridViewTextBoxColumn";
            this.codseccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seccionDataGridViewTextBoxColumn
            // 
            this.seccionDataGridViewTextBoxColumn.DataPropertyName = "seccion";
            this.seccionDataGridViewTextBoxColumn.HeaderText = "Seccion";
            this.seccionDataGridViewTextBoxColumn.Name = "seccionDataGridViewTextBoxColumn";
            this.seccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            this.capacidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seccionesBindingSource
            // 
            this.seccionesBindingSource.DataMember = "Secciones";
            this.seccionesBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seccionesTableAdapter
            // 
            this.seccionesTableAdapter.ClearBeforeFill = true;
            // 
            // SeccionesSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1066, 534);
            this.Controls.Add(this.DetallesSeccionesSistema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeccionesSistema";
            this.Text = "SeccionesSistema";
            this.Load += new System.EventHandler(this.SeccionesSistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSeccionesSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnModificarSecciones;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdSeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnRegistroNuevoSeccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnombreSeccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarSecciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.DataGridView DetallesSeccionesSistema;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private incoa_systemdbDataSetTableAdapters.SeccionesTableAdapter seccionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codseccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
    }
}