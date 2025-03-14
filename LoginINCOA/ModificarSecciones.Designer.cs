namespace LoginINCOA
{
    partial class ModificarSecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarSecciones));
            this.DetallesSeccionesSistema = new System.Windows.Forms.DataGridView();
            this.cod_seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.seccionesTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.SeccionesTableAdapter();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCapacidadMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSecc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidSeccionMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombreSeccionMod = new System.Windows.Forms.TextBox();
            this.txtSeccionMod = new System.Windows.Forms.TextBox();
            this.btnSeleccionarRegistroSeccion = new System.Windows.Forms.Button();
            this.btnModificarRegistrosSecciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSeccionesSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallesSeccionesSistema
            // 
            this.DetallesSeccionesSistema.AllowUserToAddRows = false;
            this.DetallesSeccionesSistema.AllowUserToDeleteRows = false;
            this.DetallesSeccionesSistema.AutoGenerateColumns = false;
            this.DetallesSeccionesSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesSeccionesSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesSeccionesSistema.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DetallesSeccionesSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesSeccionesSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesSeccionesSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSeccionesSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DetallesSeccionesSistema.ColumnHeadersHeight = 35;
            this.DetallesSeccionesSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesSeccionesSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_seccion,
            this.nombre,
            this.seccion,
            this.capacidad});
            this.DetallesSeccionesSistema.DataSource = this.seccionesBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesSeccionesSistema.DefaultCellStyle = dataGridViewCellStyle10;
            this.DetallesSeccionesSistema.EnableHeadersVisualStyles = false;
            this.DetallesSeccionesSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesSeccionesSistema.Location = new System.Drawing.Point(15, 52);
            this.DetallesSeccionesSistema.Name = "DetallesSeccionesSistema";
            this.DetallesSeccionesSistema.ReadOnly = true;
            this.DetallesSeccionesSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSeccionesSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DetallesSeccionesSistema.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DetallesSeccionesSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesSeccionesSistema.Size = new System.Drawing.Size(832, 238);
            this.DetallesSeccionesSistema.TabIndex = 2;
            // 
            // cod_seccion
            // 
            this.cod_seccion.DataPropertyName = "cod_seccion";
            this.cod_seccion.HeaderText = "cod_seccion";
            this.cod_seccion.Name = "cod_seccion";
            this.cod_seccion.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // seccion
            // 
            this.seccion.DataPropertyName = "seccion";
            this.seccion.HeaderText = "Sección";
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.DataPropertyName = "capacidad";
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
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
            // CerrarVentana
            // 
            this.CerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.CerrarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarVentana.BackgroundImage")));
            this.CerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarVentana.Location = new System.Drawing.Point(840, 12);
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
            this.MinimizarVentana.Location = new System.Drawing.Point(796, 12);
            this.MinimizarVentana.Name = "MinimizarVentana";
            this.MinimizarVentana.Size = new System.Drawing.Size(34, 33);
            this.MinimizarVentana.TabIndex = 91;
            this.MinimizarVentana.TabStop = false;
            this.MinimizarVentana.Click += new System.EventHandler(this.MinimizarVentana_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "Modificar Secciones Registrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "* Por favor seleccione la sección a modificar en la tabla";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(598, 479);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 5);
            this.panel4.TabIndex = 119;
            // 
            // txtCapacidadMod
            // 
            this.txtCapacidadMod.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtCapacidadMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacidadMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidadMod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCapacidadMod.Location = new System.Drawing.Point(598, 446);
            this.txtCapacidadMod.Multiline = true;
            this.txtCapacidadMod.Name = "txtCapacidadMod";
            this.txtCapacidadMod.Size = new System.Drawing.Size(185, 35);
            this.txtCapacidadMod.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(648, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 120;
            this.label7.Text = "Capacidad:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(362, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 5);
            this.panel3.TabIndex = 113;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(598, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 118;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(362, 390);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 5);
            this.panel7.TabIndex = 117;
            // 
            // lblSecc
            // 
            this.lblSecc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecc.AutoSize = true;
            this.lblSecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecc.ForeColor = System.Drawing.Color.White;
            this.lblSecc.Location = new System.Drawing.Point(424, 419);
            this.lblSecc.Name = "lblSecc";
            this.lblSecc.Size = new System.Drawing.Size(60, 16);
            this.lblSecc.TabIndex = 116;
            this.lblSecc.Text = "Seccion:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(658, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "Nombre:";
            // 
            // txtidSeccionMod
            // 
            this.txtidSeccionMod.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtidSeccionMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidSeccionMod.Cursor = System.Windows.Forms.Cursors.No;
            this.txtidSeccionMod.Enabled = false;
            this.txtidSeccionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidSeccionMod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtidSeccionMod.Location = new System.Drawing.Point(362, 360);
            this.txtidSeccionMod.Multiline = true;
            this.txtidSeccionMod.Name = "txtidSeccionMod";
            this.txtidSeccionMod.Size = new System.Drawing.Size(185, 35);
            this.txtidSeccionMod.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(419, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "ID Seccion:";
            // 
            // txtnombreSeccionMod
            // 
            this.txtnombreSeccionMod.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtnombreSeccionMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreSeccionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreSeccionMod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombreSeccionMod.Location = new System.Drawing.Point(598, 360);
            this.txtnombreSeccionMod.Multiline = true;
            this.txtnombreSeccionMod.Name = "txtnombreSeccionMod";
            this.txtnombreSeccionMod.Size = new System.Drawing.Size(185, 35);
            this.txtnombreSeccionMod.TabIndex = 110;
            // 
            // txtSeccionMod
            // 
            this.txtSeccionMod.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtSeccionMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeccionMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccionMod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSeccionMod.Location = new System.Drawing.Point(362, 446);
            this.txtSeccionMod.Multiline = true;
            this.txtSeccionMod.Name = "txtSeccionMod";
            this.txtSeccionMod.Size = new System.Drawing.Size(185, 35);
            this.txtSeccionMod.TabIndex = 111;
            // 
            // btnSeleccionarRegistroSeccion
            // 
            this.btnSeleccionarRegistroSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSeleccionarRegistroSeccion.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarRegistroSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarRegistroSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarRegistroSeccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionarRegistroSeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarRegistroSeccion.Image")));
            this.btnSeleccionarRegistroSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarRegistroSeccion.Location = new System.Drawing.Point(325, 529);
            this.btnSeleccionarRegistroSeccion.Name = "btnSeleccionarRegistroSeccion";
            this.btnSeleccionarRegistroSeccion.Size = new System.Drawing.Size(222, 34);
            this.btnSeleccionarRegistroSeccion.TabIndex = 121;
            this.btnSeleccionarRegistroSeccion.Text = "Seleccionar Sección";
            this.btnSeleccionarRegistroSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarRegistroSeccion.UseVisualStyleBackColor = false;
            this.btnSeleccionarRegistroSeccion.Click += new System.EventHandler(this.btnSeleccionarRegistroSeccion_Click);
            // 
            // btnModificarRegistrosSecciones
            // 
            this.btnModificarRegistrosSecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnModificarRegistrosSecciones.FlatAppearance.BorderSize = 0;
            this.btnModificarRegistrosSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRegistrosSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRegistrosSecciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarRegistrosSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRegistrosSecciones.Image")));
            this.btnModificarRegistrosSecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRegistrosSecciones.Location = new System.Drawing.Point(597, 529);
            this.btnModificarRegistrosSecciones.Name = "btnModificarRegistrosSecciones";
            this.btnModificarRegistrosSecciones.Size = new System.Drawing.Size(222, 34);
            this.btnModificarRegistrosSecciones.TabIndex = 122;
            this.btnModificarRegistrosSecciones.Text = "Modificar Sección";
            this.btnModificarRegistrosSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarRegistrosSecciones.UseVisualStyleBackColor = false;
            this.btnModificarRegistrosSecciones.Click += new System.EventHandler(this.btnModificarRegistrosSecciones_Click);
            // 
            // ModificarSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(884, 593);
            this.Controls.Add(this.btnSeleccionarRegistroSeccion);
            this.Controls.Add(this.btnModificarRegistrosSecciones);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtCapacidadMod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblSecc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidSeccionMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombreSeccionMod);
            this.Controls.Add(this.txtSeccionMod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.DetallesSeccionesSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarSecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarSecciones";
            this.Load += new System.EventHandler(this.ModificarSecciones_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarSecciones_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSeccionesSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetallesSeccionesSistema;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private incoa_systemdbDataSetTableAdapters.SeccionesTableAdapter seccionesTableAdapter;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCapacidadMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblSecc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidSeccionMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombreSeccionMod;
        private System.Windows.Forms.TextBox txtSeccionMod;
        private System.Windows.Forms.Button btnSeleccionarRegistroSeccion;
        private System.Windows.Forms.Button btnModificarRegistrosSecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
    }
}