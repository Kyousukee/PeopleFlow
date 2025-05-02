namespace PeopleFlow.Formularios.Dashboard
{
    partial class FrmIngresoAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoAsistencia));
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            label2 = new Label();
            dttFAsignacion = new DateTimePicker();
            label7 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            cboEmpleados = new ComboBox();
            label9 = new Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label4 = new Label();
            dttinicio = new DateTimePicker();
            dtttermino = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(59, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 30);
            lblTitulo.TabIndex = 39;
            lblTitulo.Text = "Ingresa Asistencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(13, 220);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 74;
            label2.Text = "HORA";
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(194, 175);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(274, 23);
            dttFAsignacion.TabIndex = 73;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            dttFAsignacion.ValueChanged += dttFAsignacion_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(11, 179);
            label7.Name = "label7";
            label7.Size = new Size(146, 17);
            label7.TabIndex = 72;
            label7.Text = "FECHA DE ASIGNACION";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(194, 86);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(274, 23);
            txtTitulo.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(11, 87);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 70;
            label1.Text = "DESCRIPCION TAREA";
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(144, 271);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 32);
            btnIngresar.TabIndex = 69;
            btnIngresar.Text = "Ingresar Actividad";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(194, 132);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(274, 23);
            cboEmpleados.TabIndex = 68;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(11, 133);
            label9.Name = "label9";
            label9.Size = new Size(164, 17);
            label9.TabIndex = 67;
            label9.Text = "SELECCIONE TRABAJADOR";
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(309, 272);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 66;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(194, 226);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 78;
            label3.Text = "Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(333, 226);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 79;
            label4.Text = "Termino";
            // 
            // dttinicio
            // 
            dttinicio.Location = new Point(239, 222);
            dttinicio.Name = "dttinicio";
            dttinicio.Size = new Size(77, 23);
            dttinicio.TabIndex = 80;
            // 
            // dtttermino
            // 
            dtttermino.Location = new Point(391, 222);
            dtttermino.Name = "dtttermino";
            dtttermino.Size = new Size(77, 23);
            dtttermino.TabIndex = 81;
            // 
            // FrmIngresoAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 333);
            Controls.Add(dtttermino);
            Controls.Add(dttinicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dttFAsignacion);
            Controls.Add(label7);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(cboEmpleados);
            Controls.Add(label9);
            Controls.Add(btnsalir);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmIngresoAsistencia";
            Load += FrmIngresoAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Label label2;
        private DateTimePicker dttFAsignacion;
        private Label label7;
        private TextBox txtTitulo;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private ComboBox cboEmpleados;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnsalir;
        private Label label3;
        private Label label4;
        private DateTimePicker dttinicio;
        private DateTimePicker dtttermino;
    }
}