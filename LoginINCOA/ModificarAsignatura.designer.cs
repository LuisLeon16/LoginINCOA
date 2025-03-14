namespace LoginINCOA
{
    partial class ModificarAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAsignatura));
            this.DetallesAsignaturasSistema = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeleccionarRegistroAsignatura = new System.Windows.Forms.Button();
            this.ModificarRegistrosAsignatura = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AsignaturasTableAdapter();
            this.cod_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAsignaturasSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallesAsignaturasSistema
            // 
            this.DetallesAsignaturasSistema.AllowUserToAddRows = false;
            this.DetallesAsignaturasSistema.AllowUserToDeleteRows = false;
            this.DetallesAsignaturasSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesAsignaturasSistema.AutoGenerateColumns = false;
            this.DetallesAsignaturasSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesAsignaturasSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesAsignaturasSistema.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DetallesAsignaturasSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesAsignaturasSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesAsignaturasSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAsignaturasSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesAsignaturasSistema.ColumnHeadersHeight = 35;
            this.DetallesAsignaturasSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesAsignaturasSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_asignatura,
            this.n_asignatura});
            this.DetallesAsignaturasSistema.DataSource = this.asignaturasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesAsignaturasSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesAsignaturasSistema.EnableHeadersVisualStyles = false;
            this.DetallesAsignaturasSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesAsignaturasSistema.Location = new System.Drawing.Point(13, 51);
            this.DetallesAsignaturasSistema.MultiSelect = false;
            this.DetallesAsignaturasSistema.Name = "DetallesAsignaturasSistema";
            this.DetallesAsignaturasSistema.ReadOnly = true;
            this.DetallesAsignaturasSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesAsignaturasSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DetallesAsignaturasSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesAsignaturasSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesAsignaturasSistema.Size = new System.Drawing.Size(857, 239);
            this.DetallesAsignaturasSistema.TabIndex = 106;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "* Por favor seleccione la asignatura a modificar en la tabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 18);
            this.label2.TabIndex = 93;
            this.label2.Text = "Modificar Asignaturas Registradas";
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
            this.MinimizarVentana.TabIndex = 92;
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
            this.CerrarVentana.Location = new System.Drawing.Point(840, 12);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 91;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(634, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 117;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(311, 417);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 5);
            this.panel7.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(692, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(350, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Cod. Asignatura:";
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
            this.SeleccionarRegistroAsignatura.Location = new System.Drawing.Point(325, 473);
            this.SeleccionarRegistroAsignatura.Name = "SeleccionarRegistroAsignatura";
            this.SeleccionarRegistroAsignatura.Size = new System.Drawing.Size(222, 34);
            this.SeleccionarRegistroAsignatura.TabIndex = 119;
            this.SeleccionarRegistroAsignatura.Text = "Seleccionar Asignatura";
            this.SeleccionarRegistroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistroAsignatura.UseVisualStyleBackColor = false;
            this.SeleccionarRegistroAsignatura.Click += new System.EventHandler(this.SeleccionarRegistroAsignatura_Click);
            // 
            // ModificarRegistrosAsignatura
            // 
            this.ModificarRegistrosAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ModificarRegistrosAsignatura.FlatAppearance.BorderSize = 0;
            this.ModificarRegistrosAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarRegistrosAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarRegistrosAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarRegistrosAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("ModificarRegistrosAsignatura.Image")));
            this.ModificarRegistrosAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarRegistrosAsignatura.Location = new System.Drawing.Point(597, 473);
            this.ModificarRegistrosAsignatura.Name = "ModificarRegistrosAsignatura";
            this.ModificarRegistrosAsignatura.Size = new System.Drawing.Size(222, 34);
            this.ModificarRegistrosAsignatura.TabIndex = 120;
            this.ModificarRegistrosAsignatura.Text = "Modificar Asignatura";
            this.ModificarRegistrosAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarRegistrosAsignatura.UseVisualStyleBackColor = false;
            this.ModificarRegistrosAsignatura.Click += new System.EventHandler(this.ModificarRegistrosAsignatura_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(311, 384);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(185, 35);
            this.txtid.TabIndex = 121;
            // 
            // txtnombres
            // 
            this.txtnombres.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnombres.Location = new System.Drawing.Point(634, 384);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(185, 35);
            this.txtnombres.TabIndex = 123;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
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
            this.n_asignatura.HeaderText = "Nombre Asignatura";
            this.n_asignatura.Name = "n_asignatura";
            this.n_asignatura.ReadOnly = true;
            // 
            // ModificarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(884, 557);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.SeleccionarRegistroAsignatura);
            this.Controls.Add(this.ModificarRegistrosAsignatura);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DetallesAsignaturasSistema);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.CerrarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarAsignatura";
            this.Load += new System.EventHandler(this.ModificarAsignatura_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarAsignatura_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesAsignaturasSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetallesAsignaturasSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SeleccionarRegistroAsignatura;
        private System.Windows.Forms.Button ModificarRegistrosAsignatura;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombres;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_asignatura;
    }
}