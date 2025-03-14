namespace LoginINCOA
{
    partial class CalendarioINCOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioINCOA));
            this.CerrarVentana = new System.Windows.Forms.PictureBox();
            this.Calendario_INCOA = new WindowsFormsCalendar.MonthView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarVentana
            // 
            this.CerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.CerrarVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarVentana.BackgroundImage")));
            this.CerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarVentana.Location = new System.Drawing.Point(658, 8);
            this.CerrarVentana.Name = "CerrarVentana";
            this.CerrarVentana.Size = new System.Drawing.Size(32, 33);
            this.CerrarVentana.TabIndex = 49;
            this.CerrarVentana.TabStop = false;
            this.CerrarVentana.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // Calendario_INCOA
            // 
            this.Calendario_INCOA.ArrowsColor = System.Drawing.Color.Maroon;
            this.Calendario_INCOA.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.Calendario_INCOA.BackColor = System.Drawing.Color.Black;
            this.Calendario_INCOA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Calendario_INCOA.DayBackgroundColor = System.Drawing.Color.Empty;
            this.Calendario_INCOA.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.Calendario_INCOA.DayNamesLength = 3;
            this.Calendario_INCOA.DaySelectedBackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.Calendario_INCOA.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.Calendario_INCOA.DaySelectedTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calendario_INCOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario_INCOA.ItemPadding = new System.Windows.Forms.Padding(2);
            this.Calendario_INCOA.Location = new System.Drawing.Point(0, 47);
            this.Calendario_INCOA.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calendario_INCOA.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.Calendario_INCOA.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calendario_INCOA.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.Calendario_INCOA.Name = "Calendario_INCOA";
            this.Calendario_INCOA.SelectionMode = WindowsFormsCalendar.MonthViewSelection.Day;
            this.Calendario_INCOA.Size = new System.Drawing.Size(700, 353);
            this.Calendario_INCOA.TabIndex = 50;
            this.Calendario_INCOA.Text = "Calendario INCOA";
            this.Calendario_INCOA.TodayBorderColor = System.Drawing.Color.DarkRed;
            this.Calendario_INCOA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calendario_INCOA_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Calendario Instituto Nacional de la Colonia Cuidad Obrera de Apopa";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // CalendarioINCOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calendario_INCOA);
            this.Controls.Add(this.CerrarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarioINCOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarioINCOA";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalendarioINCOA_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CerrarVentana;
        private WindowsFormsCalendar.MonthView Calendario_INCOA;
        private System.Windows.Forms.Label label2;
    }
}