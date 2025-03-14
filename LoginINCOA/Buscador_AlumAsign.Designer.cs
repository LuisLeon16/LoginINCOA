namespace LoginINCOA
{
    partial class Buscador_AlumAsign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador_AlumAsign));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumAsignSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBuscador.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBuscador.Location = new System.Drawing.Point(15, 42);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(927, 31);
            this.txtBuscador.TabIndex = 27;
            this.txtBuscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscador_KeyUp);
            // 
            // CerrarVentana
            // 
            this.CerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.CerrarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarVentana.BackgroundImage")));
            this.CerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarVentana.Location = new System.Drawing.Point(1005, 12);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 26;
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
            this.MinimizarVentana.Location = new System.Drawing.Point(961, 12);
            this.MinimizarVentana.Name = "MinimizarVentana";
            this.MinimizarVentana.Size = new System.Drawing.Size(34, 33);
            this.MinimizarVentana.TabIndex = 25;
            this.MinimizarVentana.TabStop = false;
            this.MinimizarVentana.Click += new System.EventHandler(this.MinimizarVentana_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(12, 12);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(234, 17);
            this.lblMensaje.TabIndex = 24;
            this.lblMensaje.Text = "Buscador de Alumnos - Asignaturas";
            // 
            // DetallesAlumAsignSistema
            // 
            this.DetallesAlumAsignSistema.AllowUserToAddRows = false;
            this.DetallesAlumAsignSistema.AllowUserToDeleteRows = false;
            this.DetallesAlumAsignSistema.AutoGenerateColumns = false;
            this.DetallesAlumAsignSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesAlumAsignSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesAlumAsignSistema.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            this.DetallesAlumAsignSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesAlumAsignSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesAlumAsignSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumAsignSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesAlumAsignSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesAlumAsignSistema.EnableHeadersVisualStyles = false;
            this.DetallesAlumAsignSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesAlumAsignSistema.Location = new System.Drawing.Point(15, 90);
            this.DetallesAlumAsignSistema.Name = "DetallesAlumAsignSistema";
            this.DetallesAlumAsignSistema.ReadOnly = true;
            this.DetallesAlumAsignSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(152)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAlumAsignSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallesAlumAsignSistema.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(152)))), ((int)(((byte)(98)))));
            this.DetallesAlumAsignSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesAlumAsignSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesAlumAsignSistema.Size = new System.Drawing.Size(1022, 517);
            this.DetallesAlumAsignSistema.TabIndex = 28;
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
            // Buscador_AlumAsign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(93)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1049, 619);
            this.Controls.Add(this.DetallesAlumAsignSistema);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscador_AlumAsign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador_AlumAsign";
            this.Load += new System.EventHandler(this.Buscador_AlumAsign_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buscador_AlumAsign_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAlumAsignSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView DetallesAlumAsignSistema;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasAlumnosBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasAlumnosTableAdapter asignaturasAlumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsAlumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codalumnoDataGridViewTextBoxColumn;
    }
}