namespace LoginINCOA
{
    partial class EliminarSecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarSecciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.DetallesSeccionesSistema = new System.Windows.Forms.DataGridView();
            this.cod_seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.seccionesTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.SeccionesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdSeccionEli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombreSeccionEli = new System.Windows.Forms.TextBox();
            this.txtSeccionEli = new System.Windows.Forms.TextBox();
            this.EliminarRegistrosSeccion = new System.Windows.Forms.Button();
            this.SeleccionarRegistroSeccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSeccionesSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarVentana
            // 
            this.CerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.CerrarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarVentana.BackgroundImage")));
            this.CerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarVentana.Location = new System.Drawing.Point(824, 9);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 96;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // DetallesSeccionesSistema
            // 
            this.DetallesSeccionesSistema.AllowUserToAddRows = false;
            this.DetallesSeccionesSistema.AllowUserToDeleteRows = false;
            this.DetallesSeccionesSistema.AutoGenerateColumns = false;
            this.DetallesSeccionesSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesSeccionesSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesSeccionesSistema.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.cod_seccion,
            this.nombre,
            this.seccion,
            this.capacidad});
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
            this.DetallesSeccionesSistema.Location = new System.Drawing.Point(15, 52);
            this.DetallesSeccionesSistema.Name = "DetallesSeccionesSistema";
            this.DetallesSeccionesSistema.ReadOnly = true;
            this.DetallesSeccionesSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSeccionesSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.DetallesSeccionesSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesSeccionesSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesSeccionesSistema.Size = new System.Drawing.Size(838, 246);
            this.DetallesSeccionesSistema.TabIndex = 97;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "Eliminar Secciones Registradas";
            // 
            // MinimizarVentana
            // 
            this.MinimizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.MinimizarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizarVentana.BackgroundImage")));
            this.MinimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarVentana.Location = new System.Drawing.Point(780, 9);
            this.MinimizarVentana.Name = "MinimizarVentana";
            this.MinimizarVentana.Size = new System.Drawing.Size(34, 33);
            this.MinimizarVentana.TabIndex = 99;
            this.MinimizarVentana.TabStop = false;
            this.MinimizarVentana.Click += new System.EventHandler(this.MinimizarVentana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "* Por favor seleccione la sección a eliminar en la tabla";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(352, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 5);
            this.panel4.TabIndex = 112;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.White;
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacidad.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCapacidad.Enabled = false;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.ForeColor = System.Drawing.Color.Black;
            this.txtCapacidad.Location = new System.Drawing.Point(352, 467);
            this.txtCapacidad.Multiline = true;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(185, 35);
            this.txtCapacidad.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(653, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 114;
            this.label7.Text = "Capacidad:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(599, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 5);
            this.panel3.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(599, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 113;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(352, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 5);
            this.panel7.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(410, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 110;
            this.label5.Text = "Seccion:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(630, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "Nombre de Seccion:";
            // 
            // txtIdSeccionEli
            // 
            this.txtIdSeccionEli.BackColor = System.Drawing.Color.White;
            this.txtIdSeccionEli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSeccionEli.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdSeccionEli.Enabled = false;
            this.txtIdSeccionEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSeccionEli.ForeColor = System.Drawing.Color.Black;
            this.txtIdSeccionEli.Location = new System.Drawing.Point(352, 369);
            this.txtIdSeccionEli.Multiline = true;
            this.txtIdSeccionEli.Name = "txtIdSeccionEli";
            this.txtIdSeccionEli.Size = new System.Drawing.Size(185, 35);
            this.txtIdSeccionEli.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 108;
            this.label3.Text = "ID Seccion:";
            // 
            // txtnombreSeccionEli
            // 
            this.txtnombreSeccionEli.BackColor = System.Drawing.Color.White;
            this.txtnombreSeccionEli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreSeccionEli.Cursor = System.Windows.Forms.Cursors.No;
            this.txtnombreSeccionEli.Enabled = false;
            this.txtnombreSeccionEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreSeccionEli.ForeColor = System.Drawing.Color.Black;
            this.txtnombreSeccionEli.Location = new System.Drawing.Point(599, 369);
            this.txtnombreSeccionEli.Multiline = true;
            this.txtnombreSeccionEli.Name = "txtnombreSeccionEli";
            this.txtnombreSeccionEli.Size = new System.Drawing.Size(185, 35);
            this.txtnombreSeccionEli.TabIndex = 104;
            // 
            // txtSeccionEli
            // 
            this.txtSeccionEli.BackColor = System.Drawing.Color.White;
            this.txtSeccionEli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeccionEli.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSeccionEli.Enabled = false;
            this.txtSeccionEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccionEli.ForeColor = System.Drawing.Color.Black;
            this.txtSeccionEli.Location = new System.Drawing.Point(599, 464);
            this.txtSeccionEli.Multiline = true;
            this.txtSeccionEli.Name = "txtSeccionEli";
            this.txtSeccionEli.Size = new System.Drawing.Size(185, 35);
            this.txtSeccionEli.TabIndex = 105;
            // 
            // EliminarRegistrosSeccion
            // 
            this.EliminarRegistrosSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarRegistrosSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.EliminarRegistrosSeccion.FlatAppearance.BorderSize = 0;
            this.EliminarRegistrosSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRegistrosSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarRegistrosSeccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarRegistrosSeccion.Image = ((System.Drawing.Image)(resources.GetObject("EliminarRegistrosSeccion.Image")));
            this.EliminarRegistrosSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarRegistrosSeccion.Location = new System.Drawing.Point(598, 538);
            this.EliminarRegistrosSeccion.Name = "EliminarRegistrosSeccion";
            this.EliminarRegistrosSeccion.Size = new System.Drawing.Size(205, 34);
            this.EliminarRegistrosSeccion.TabIndex = 116;
            this.EliminarRegistrosSeccion.Text = "Eliminar Sección";
            this.EliminarRegistrosSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarRegistrosSeccion.UseVisualStyleBackColor = false;
            this.EliminarRegistrosSeccion.Click += new System.EventHandler(this.EliminarRegistrosSeccion_Click);
            // 
            // SeleccionarRegistroSeccion
            // 
            this.SeleccionarRegistroSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SeleccionarRegistroSeccion.FlatAppearance.BorderSize = 0;
            this.SeleccionarRegistroSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionarRegistroSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarRegistroSeccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeleccionarRegistroSeccion.Image = ((System.Drawing.Image)(resources.GetObject("SeleccionarRegistroSeccion.Image")));
            this.SeleccionarRegistroSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeleccionarRegistroSeccion.Location = new System.Drawing.Point(332, 538);
            this.SeleccionarRegistroSeccion.Name = "SeleccionarRegistroSeccion";
            this.SeleccionarRegistroSeccion.Size = new System.Drawing.Size(222, 34);
            this.SeleccionarRegistroSeccion.TabIndex = 115;
            this.SeleccionarRegistroSeccion.Text = "Seleccionar Sección";
            this.SeleccionarRegistroSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistroSeccion.UseVisualStyleBackColor = false;
            this.SeleccionarRegistroSeccion.Click += new System.EventHandler(this.SeleccionarRegistroSeccion_Click);
            // 
            // EliminarSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(868, 593);
            this.Controls.Add(this.EliminarRegistrosSeccion);
            this.Controls.Add(this.SeleccionarRegistroSeccion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdSeccionEli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombreSeccionEli);
            this.Controls.Add(this.txtSeccionEli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DetallesSeccionesSistema);
            this.Controls.Add(this.CerrarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarSecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarSecciones";
            this.Load += new System.EventHandler(this.EliminarSecciones_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EliminarSecciones_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSeccionesSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.DataGridView DetallesSeccionesSistema;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private incoa_systemdbDataSetTableAdapters.SeccionesTableAdapter seccionesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdSeccionEli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombreSeccionEli;
        private System.Windows.Forms.TextBox txtSeccionEli;
        private System.Windows.Forms.Button EliminarRegistrosSeccion;
        private System.Windows.Forms.Button SeleccionarRegistroSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
    }
}