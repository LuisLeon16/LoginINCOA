namespace LoginINCOA
{
    partial class ModificarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAlumnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimizarVentana = new System.Windows.Forms.PictureBox();
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeleccionarRegistro = new System.Windows.Forms.Button();
            this.ModificarRegistrosAlumnos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.DetallesUsuariosSistema = new System.Windows.Forms.DataGridView();
            this.cod_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incoa_systemdbDataSet = new LoginINCOA.incoa_systemdbDataSet();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.mtxtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.alumnosTableAdapter = new LoginINCOA.incoa_systemdbDataSetTableAdapters.AlumnosTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesUsuariosSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Modificar Alumnos Registrados";
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
            this.MinimizarVentana.TabIndex = 19;
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
            this.CerrarVentana.Location = new System.Drawing.Point(1005, 12);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 20;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "* Seleccione el alumno a modificar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
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
            this.SeleccionarRegistro.Location = new System.Drawing.Point(389, 558);
            this.SeleccionarRegistro.Name = "SeleccionarRegistro";
            this.SeleccionarRegistro.Size = new System.Drawing.Size(222, 34);
            this.SeleccionarRegistro.TabIndex = 10;
            this.SeleccionarRegistro.Text = "Seleccionar Alumno";
            this.SeleccionarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarRegistro.UseVisualStyleBackColor = false;
            this.SeleccionarRegistro.Click += new System.EventHandler(this.SeleccionarRegistro_Click);
            // 
            // ModificarRegistrosAlumnos
            // 
            this.ModificarRegistrosAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ModificarRegistrosAlumnos.FlatAppearance.BorderSize = 0;
            this.ModificarRegistrosAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarRegistrosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarRegistrosAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarRegistrosAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("ModificarRegistrosAlumnos.Image")));
            this.ModificarRegistrosAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarRegistrosAlumnos.Location = new System.Drawing.Point(662, 558);
            this.ModificarRegistrosAlumnos.Name = "ModificarRegistrosAlumnos";
            this.ModificarRegistrosAlumnos.Size = new System.Drawing.Size(222, 34);
            this.ModificarRegistrosAlumnos.TabIndex = 11;
            this.ModificarRegistrosAlumnos.Text = "Modificar Alumno";
            this.ModificarRegistrosAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarRegistrosAlumnos.UseVisualStyleBackColor = false;
            this.ModificarRegistrosAlumnos.Click += new System.EventHandler(this.ModificarRegistrosAlumnos_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(683, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(440, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Cod Alumno:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(796, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 79;
            this.label7.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(436, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(865, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 80;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(915, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "Cod Seccion:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(358, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 5);
            this.panel1.TabIndex = 85;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(358, 374);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(601, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 5);
            this.panel3.TabIndex = 87;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txtApellido.Location = new System.Drawing.Point(601, 375);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 35);
            this.txtApellido.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(790, 512);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(66, 5);
            this.panel5.TabIndex = 91;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(403, 512);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 5);
            this.panel6.TabIndex = 93;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Location = new System.Drawing.Point(403, 482);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 35);
            this.txtTelefono.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(888, 512);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(136, 5);
            this.panel7.TabIndex = 95;
            // 
            // txtSeccion
            // 
            this.txtSeccion.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSeccion.Location = new System.Drawing.Point(888, 482);
            this.txtSeccion.Multiline = true;
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(136, 35);
            this.txtSeccion.TabIndex = 9;
            // 
            // DetallesUsuariosSistema
            // 
            this.DetallesUsuariosSistema.AllowUserToAddRows = false;
            this.DetallesUsuariosSistema.AllowUserToDeleteRows = false;
            this.DetallesUsuariosSistema.AutoGenerateColumns = false;
            this.DetallesUsuariosSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesUsuariosSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesUsuariosSistema.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.DetallesUsuariosSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesUsuariosSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesUsuariosSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesUsuariosSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DetallesUsuariosSistema.ColumnHeadersHeight = 35;
            this.DetallesUsuariosSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetallesUsuariosSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_alumno,
            this.nombre,
            this.apellido,
            this.f_nacimiento,
            this.Direccion,
            this.genero,
            this.especialidad,
            this.año,
            this.telefono,
            this.cod_seccion});
            this.DetallesUsuariosSistema.DataSource = this.alumnosBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesUsuariosSistema.DefaultCellStyle = dataGridViewCellStyle10;
            this.DetallesUsuariosSistema.EnableHeadersVisualStyles = false;
            this.DetallesUsuariosSistema.GridColor = System.Drawing.Color.Black;
            this.DetallesUsuariosSistema.Location = new System.Drawing.Point(13, 51);
            this.DetallesUsuariosSistema.Name = "DetallesUsuariosSistema";
            this.DetallesUsuariosSistema.ReadOnly = true;
            this.DetallesUsuariosSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesUsuariosSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.DetallesUsuariosSistema.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DetallesUsuariosSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesUsuariosSistema.Size = new System.Drawing.Size(1014, 270);
            this.DetallesUsuariosSistema.TabIndex = 96;
            // 
            // cod_alumno
            // 
            this.cod_alumno.DataPropertyName = "cod_alumno";
            this.cod_alumno.HeaderText = "cod_alumno";
            this.cod_alumno.Name = "cod_alumno";
            this.cod_alumno.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // f_nacimiento
            // 
            this.f_nacimiento.DataPropertyName = "f_nacimiento";
            this.f_nacimiento.HeaderText = "Fecha Nacimiento";
            this.f_nacimiento.Name = "f_nacimiento";
            this.f_nacimiento.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // año
            // 
            this.año.DataPropertyName = "año";
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // cod_seccion
            // 
            this.cod_seccion.DataPropertyName = "cod_seccion";
            this.cod_seccion.HeaderText = "cod_seccion";
            this.cod_seccion.Name = "cod_seccion";
            this.cod_seccion.ReadOnly = true;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.incoa_systemdbDataSet;
            // 
            // incoa_systemdbDataSet
            // 
            this.incoa_systemdbDataSet.DataSetName = "incoa_systemdbDataSet";
            this.incoa_systemdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(245, 404);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(97, 5);
            this.panel8.TabIndex = 98;
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcod.Cursor = System.Windows.Forms.Cursors.No;
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcod.Location = new System.Drawing.Point(245, 374);
            this.txtcod.Multiline = true;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(97, 35);
            this.txtcod.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(559, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 5);
            this.panel2.TabIndex = 135;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(581, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 134;
            this.label10.Text = "Especialidad:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(708, 512);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(54, 5);
            this.panel9.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(717, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 131;
            this.label11.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.Color.White;
            this.txtAnio.Location = new System.Drawing.Point(707, 478);
            this.txtAnio.Multiline = true;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(54, 35);
            this.txtAnio.TabIndex = 7;
            // 
            // mtxtNacimiento
            // 
            this.mtxtNacimiento.BackColor = System.Drawing.Color.RoyalBlue;
            this.mtxtNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mtxtNacimiento.ForeColor = System.Drawing.Color.White;
            this.mtxtNacimiento.Location = new System.Drawing.Point(878, 372);
            this.mtxtNacimiento.Mask = "00/00/0000";
            this.mtxtNacimiento.Name = "mtxtNacimiento";
            this.mtxtNacimiento.PromptChar = ' ';
            this.mtxtNacimiento.Size = new System.Drawing.Size(108, 25);
            this.mtxtNacimiento.TabIndex = 3;
            this.mtxtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(878, 405);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(108, 5);
            this.panel12.TabIndex = 138;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(221, 513);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 5);
            this.panel4.TabIndex = 141;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(274, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 140;
            this.label12.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Location = new System.Drawing.Point(221, 480);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 35);
            this.txtDireccion.TabIndex = 4;
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboEspecialidad.ForeColor = System.Drawing.Color.White;
            this.cboEspecialidad.Location = new System.Drawing.Point(559, 478);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(128, 32);
            this.cboEspecialidad.TabIndex = 143;
            // 
            // cboGenero
            // 
            this.cboGenero.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboGenero.ForeColor = System.Drawing.Color.White;
            this.cboGenero.Location = new System.Drawing.Point(791, 478);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(66, 32);
            this.cboGenero.TabIndex = 142;
            // 
            // ModificarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1049, 619);
            this.Controls.Add(this.cboEspecialidad);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.mtxtNacimiento);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.DetallesUsuariosSistema);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModificarRegistrosAlumnos);
            this.Controls.Add(this.SeleccionarRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CerrarVentana);
            this.Controls.Add(this.MinimizarVentana);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarAlumnos";
            this.Load += new System.EventHandler(this.ModificarAlumnos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarAlumnos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesUsuariosSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incoa_systemdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MinimizarVentana;
        private System.Windows.Forms.PictureBox CerrarVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SeleccionarRegistro;
        private System.Windows.Forms.Button ModificarRegistrosAlumnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.DataGridView DetallesUsuariosSistema;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.MaskedTextBox mtxtNacimiento;
        private System.Windows.Forms.Panel panel12;
        private incoa_systemdbDataSet incoa_systemdbDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private incoa_systemdbDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_seccion;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.ComboBox cboGenero;
    }
}