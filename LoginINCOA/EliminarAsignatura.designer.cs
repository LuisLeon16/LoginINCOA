namespace LoginINCOA
{
    partial class EliminarAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAsignatura));
            this.label2 = new System.Windows.Forms.Label();
            this.DetalleAsignaturasSistema = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.EliminarRegistrosAsignatura = new System.Windows.Forms.Button();
            this.SeleccionarRegistro = new System.Windows.Forms.Button();
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AsignaturasTableAdapter();
            this.cod_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAsignaturasSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Eliminar Asignaturas Registradas";
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
            this.DetalleAsignaturasSistema.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.cod_asignatura,
            this.n_asignatura});
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
            this.DetalleAsignaturasSistema.Location = new System.Drawing.Point(15, 52);
            this.DetalleAsignaturasSistema.MultiSelect = false;
            this.DetalleAsignaturasSistema.Name = "DetalleAsignaturasSistema";
            this.DetalleAsignaturasSistema.ReadOnly = true;
            this.DetalleAsignaturasSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleAsignaturasSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.DetalleAsignaturasSistema.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetalleAsignaturasSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleAsignaturasSistema.Size = new System.Drawing.Size(838, 246);
            this.DetalleAsignaturasSistema.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "* Por favor seleccione la asignatura a eliminar en la tabla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(605, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 93;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(358, 422);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 5);
            this.panel7.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(664, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Nombre:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Cursor = System.Windows.Forms.Cursors.No;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(358, 392);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(185, 35);
            this.txtid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Cod. Asignatura:";
            // 
            // txtnombres
            // 
            this.txtnombres.BackColor = System.Drawing.Color.White;
            this.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombres.Cursor = System.Windows.Forms.Cursors.No;
            this.txtnombres.Enabled = false;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.ForeColor = System.Drawing.Color.Black;
            this.txtnombres.Location = new System.Drawing.Point(605, 392);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(185, 35);
            this.txtnombres.TabIndex = 81;
            // 
            // MinimizarVentana
            // 
            this.MinimizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.MinimizarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizarVentana.BackgroundImage")));
            this.MinimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarVentana.Location = new System.Drawing.Point(780, 13);
            this.MinimizarVentana.Name = "MinimizarVentana";
            this.MinimizarVentana.Size = new System.Drawing.Size(34, 33);
            this.MinimizarVentana.TabIndex = 96;
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
            this.CerrarVentana.Location = new System.Drawing.Point(824, 13);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 95;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // EliminarRegistrosAsignatura
            // 
            this.EliminarRegistrosAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarRegistrosAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.EliminarRegistrosAsignatura.FlatAppearance.BorderSize = 0;
            this.EliminarRegistrosAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRegistrosAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarRegistrosAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarRegistrosAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("EliminarRegistrosAsignatura.Image")));
            this.EliminarRegistrosAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarRegistrosAsignatura.Location = new System.Drawing.Point(605, 483);
            this.EliminarRegistrosAsignatura.Name = "EliminarRegistrosAsignatura";
            this.EliminarRegistrosAsignatura.Size = new System.Drawing.Size(205, 34);
            this.EliminarRegistrosAsignatura.TabIndex = 98;
            this.EliminarRegistrosAsignatura.Text = "Eliminar Asignatura";
            this.EliminarRegistrosAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarRegistrosAsignatura.UseVisualStyleBackColor = false;
            this.EliminarRegistrosAsignatura.Click += new System.EventHandler(this.EliminarRegistrosAsignatura_Click);
            // 
            // SeleccionarRegistro
            // 
            this.SeleccionarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SeleccionarRegistro.FlatAppearance.BorderSize = 0;
            this.SeleccionarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeleccionarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("SeleccionarRegistro.Image")));
            this.SeleccionarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeleccionarRegistro.Location = new System.Drawing.Point(339, 483);
            this.SeleccionarRegistro.Name = "SeleccionarRegistro";
            this.SeleccionarRegistro.Size = new System.Drawing.Size(222, 34);
            this.SeleccionarRegistro.TabIndex = 5;
            this.SeleccionarRegistro.Text = "Seleccionar Asignatura";
            this.SeleccionarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistro.UseVisualStyleBackColor = false;
            this.SeleccionarRegistro.Click += new System.EventHandler(this.SeleccionarRegistro_Click);
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
            // EliminarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(868, 568);
            this.Controls.Add(this.EliminarRegistrosAsignatura);
            this.Controls.Add(this.SeleccionarRegistro);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalleAsignaturasSistema);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarAsignatura";
            this.Load += new System.EventHandler(this.EliminarAsignatura_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EliminarAsignatura_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAsignaturasSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DetalleAsignaturasSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.Button EliminarRegistrosAsignatura;
        private System.Windows.Forms.Button SeleccionarRegistro;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private incoa_systemdbDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_asignatura;
    }
}