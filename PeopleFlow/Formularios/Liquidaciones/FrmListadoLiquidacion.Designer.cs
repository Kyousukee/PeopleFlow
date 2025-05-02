namespace PeopleFlow.Formularios.Liquidaciones
{
    partial class FrmListadoLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoLiquidacion));
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVLiquidacion = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            dttMeses = new DateTimePicker();
            label1 = new Label();
            dttYear = new DateTimePicker();
            label7 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DGVLiquidacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(631, 439);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 40;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVLiquidacion
            // 
            DGVLiquidacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLiquidacion.Location = new Point(12, 94);
            DGVLiquidacion.Name = "DGVLiquidacion";
            DGVLiquidacion.ReadOnly = true;
            DGVLiquidacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVLiquidacion.Size = new Size(780, 339);
            DGVLiquidacion.TabIndex = 39;
            DGVLiquidacion.CellDoubleClick += DGVLiquidacion_CellDoubleClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(57, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 30);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "Listado de Liquidacion";
            // 
            // dttMeses
            // 
            dttMeses.Format = DateTimePickerFormat.Short;
            dttMeses.Location = new Point(202, 65);
            dttMeses.Name = "dttMeses";
            dttMeses.Size = new Size(97, 23);
            dttMeses.TabIndex = 80;
            dttMeses.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(160, 69);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 79;
            label1.Text = "Mes:";
            // 
            // dttYear
            // 
            dttYear.Format = DateTimePickerFormat.Short;
            dttYear.Location = new Point(57, 65);
            dttYear.Name = "dttYear";
            dttYear.Size = new Size(97, 23);
            dttYear.TabIndex = 78;
            dttYear.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(16, 69);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 77;
            label7.Text = "AÑO:";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(305, 65);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(102, 23);
            iconButton1.TabIndex = 81;
            iconButton1.Text = "Buscar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(413, 65);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(102, 23);
            iconButton2.TabIndex = 82;
            iconButton2.Text = "Limpiar";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // FrmListadoLiquidacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(dttMeses);
            Controls.Add(label1);
            Controls.Add(dttYear);
            Controls.Add(label7);
            Controls.Add(btnsalir);
            Controls.Add(DGVLiquidacion);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListadoLiquidacion";
            Text = "Listado de Liquidacion";
            Load += FrmListadoLiquidacion_Load;
            ((System.ComponentModel.ISupportInitialize)DGVLiquidacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVLiquidacion;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private DateTimePicker dttMeses;
        private Label label1;
        private DateTimePicker dttYear;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}