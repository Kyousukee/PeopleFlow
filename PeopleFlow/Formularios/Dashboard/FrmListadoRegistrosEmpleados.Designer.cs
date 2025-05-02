namespace PeopleFlow.Formularios.Dashboard
{
    partial class FrmListadoRegistrosEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoRegistrosEmpleados));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVPlanilla = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            btnexport = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            dttFFin = new DateTimePicker();
            dttFIni = new DateTimePicker();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            cboTareas = new ComboBox();
            cboEmpleados = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DGVPlanilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(631, 528);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 40;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVPlanilla
            // 
            DGVPlanilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPlanilla.Location = new Point(8, 213);
            DGVPlanilla.Name = "DGVPlanilla";
            DGVPlanilla.ReadOnly = true;
            DGVPlanilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVPlanilla.Size = new Size(780, 309);
            DGVPlanilla.TabIndex = 39;
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
            lblTitulo.Size = new Size(222, 30);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "Listado de Registros";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnexport);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(dttFFin);
            panel1.Controls.Add(dttFIni);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(cboTareas);
            panel1.Controls.Add(cboEmpleados);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 137);
            panel1.TabIndex = 41;
            // 
            // btnexport
            // 
            btnexport.Enabled = false;
            btnexport.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnexport.IconColor = Color.Black;
            btnexport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexport.IconSize = 30;
            btnexport.ImageAlign = ContentAlignment.MiddleLeft;
            btnexport.Location = new Point(562, 88);
            btnexport.Name = "btnexport";
            btnexport.Size = new Size(159, 32);
            btnexport.TabIndex = 75;
            btnexport.Text = "Exportar Excel";
            btnexport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexport.UseVisualStyleBackColor = true;
            btnexport.Click += btnexport_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(562, 18);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 64);
            btnIngresar.TabIndex = 74;
            btnIngresar.Text = "Cargar Planilla";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // dttFFin
            // 
            dttFFin.Format = DateTimePickerFormat.Short;
            dttFFin.Location = new Point(373, 97);
            dttFFin.Name = "dttFFin";
            dttFFin.Size = new Size(131, 23);
            dttFFin.TabIndex = 73;
            dttFFin.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // dttFIni
            // 
            dttFIni.Format = DateTimePickerFormat.Short;
            dttFIni.Location = new Point(230, 97);
            dttFIni.Name = "dttFIni";
            dttFIni.Size = new Size(119, 23);
            dttFIni.TabIndex = 72;
            dttFIni.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 99);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 71;
            label1.Text = "Seleccionar Fechas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // cboTareas
            // 
            cboTareas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTareas.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTareas.FormattingEnabled = true;
            cboTareas.Location = new Point(230, 18);
            cboTareas.Name = "cboTareas";
            cboTareas.Size = new Size(274, 23);
            cboTareas.TabIndex = 46;
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(230, 45);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(274, 23);
            cboEmpleados.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(61, 47);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 12;
            label4.Text = "Seleccionar Trabajador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(61, 20);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 11;
            label3.Text = "Seleccionar Tarea";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 525);
            label2.Name = "label2";
            label2.Size = new Size(364, 15);
            label2.TabIndex = 42;
            label2.Text = "Para una informacion mas detallada se recomienda exportar a excel.";
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(466, 528);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 31);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmListadoRegistrosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnsalir);
            Controls.Add(DGVPlanilla);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmListadoRegistrosEmpleados";
            Load += FrmListadoRegistrosEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)DGVPlanilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVPlanilla;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private ComboBox cboTareas;
        private ComboBox cboEmpleados;
        private Label label1;
        private DateTimePicker dttFFin;
        private DateTimePicker dttFIni;
        private FontAwesome.Sharp.IconButton btnexport;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}