namespace PeopleFlow.Formularios.Dashboard
{
    partial class FrmIngresoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoActividad));
            btnsalir = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            cboEmpleados = new ComboBox();
            label9 = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtTitulo = new TextBox();
            dttFAsignacion = new DateTimePicker();
            label7 = new Label();
            txtcantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPagoIndividual = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
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
            btnsalir.Location = new Point(306, 389);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 39;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
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
            lblTitulo.Size = new Size(195, 30);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "Ingresa Actividad";
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(191, 129);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(274, 23);
            cboEmpleados.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(8, 130);
            label9.Name = "label9";
            label9.Size = new Size(164, 17);
            label9.TabIndex = 43;
            label9.Text = "SELECCIONE TRABAJADOR";
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(141, 388);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 32);
            btnIngresar.TabIndex = 45;
            btnIngresar.Text = "Ingresar Actividad";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(8, 84);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 46;
            label1.Text = "DESCRIPCION TAREA";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(191, 83);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(274, 23);
            txtTitulo.TabIndex = 61;
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(191, 172);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(274, 23);
            dttFAsignacion.TabIndex = 63;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(8, 176);
            label7.Name = "label7";
            label7.Size = new Size(146, 17);
            label7.TabIndex = 62;
            label7.Text = "FECHA DE ASIGNACION";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(191, 216);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(274, 23);
            txtcantidad.TabIndex = 65;
            txtcantidad.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(10, 217);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 64;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 242);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 66;
            label3.Text = "Horas, tareas, trato, etc...";
            // 
            // txtPagoIndividual
            // 
            txtPagoIndividual.Enabled = false;
            txtPagoIndividual.Location = new Point(191, 291);
            txtPagoIndividual.Name = "txtPagoIndividual";
            txtPagoIndividual.Size = new Size(274, 23);
            txtPagoIndividual.TabIndex = 68;
            txtPagoIndividual.KeyPress += txtPagoIndividual_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(10, 292);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 67;
            label4.Text = "PAGO INDIVIDUAL";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(194, 271);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 69;
            checkBox1.Text = "Aplica";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmIngresoActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 432);
            Controls.Add(checkBox1);
            Controls.Add(txtPagoIndividual);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtcantidad);
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
            Name = "FrmIngresoActividad";
            Load += FrmIngresoActividad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private ComboBox cboEmpleados;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private Label label1;
        private TextBox txtTitulo;
        private DateTimePicker dttFAsignacion;
        private Label label7;
        private TextBox txtcantidad;
        private Label label2;
        private Label label3;
        private TextBox txtPagoIndividual;
        private Label label4;
        private CheckBox checkBox1;
    }
}