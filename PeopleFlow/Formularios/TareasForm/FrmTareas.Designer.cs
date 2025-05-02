namespace PeopleFlow.Formularios
{
    partial class FrmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            btnListadoTrabajadores = new FontAwesome.Sharp.IconButton();
            panelControles = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnasignar = new FontAwesome.Sharp.IconButton();
            btnControl = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            Cbotipopago = new ComboBox();
            label9 = new Label();
            dttFAsignacion = new DateTimePicker();
            txtvalor = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label3 = new Label();
            lblNombres = new Label();
            dtpFFin = new DateTimePicker();
            label1 = new Label();
            cboEstado = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            txtdescripcion = new RichTextBox();
            txtID = new TextBox();
            cbojornada = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelControles.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(116, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 30);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Tus Tareas";
            // 
            // btnListadoTrabajadores
            // 
            btnListadoTrabajadores.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoTrabajadores.IconColor = Color.Black;
            btnListadoTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoTrabajadores.IconSize = 20;
            btnListadoTrabajadores.Location = new Point(241, 9);
            btnListadoTrabajadores.Name = "btnListadoTrabajadores";
            btnListadoTrabajadores.Size = new Size(159, 31);
            btnListadoTrabajadores.TabIndex = 31;
            btnListadoTrabajadores.Text = "Listado de Tareas";
            btnListadoTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoTrabajadores.UseVisualStyleBackColor = true;
            btnListadoTrabajadores.Click += btnListadoTrabajadores_Click;
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnasignar);
            panelControles.Controls.Add(btnControl);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(441, 168);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(395, 153);
            panelControles.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(13, 108);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 32);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(204, 108);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(185, 32);
            btnsalir.TabIndex = 31;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnasignar
            // 
            btnasignar.Enabled = false;
            btnasignar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btnasignar.IconColor = Color.Black;
            btnasignar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnasignar.IconSize = 20;
            btnasignar.ImageAlign = ContentAlignment.MiddleLeft;
            btnasignar.Location = new Point(204, 61);
            btnasignar.Name = "btnasignar";
            btnasignar.Size = new Size(185, 32);
            btnasignar.TabIndex = 29;
            btnasignar.Text = "Asignar Trabajador";
            btnasignar.UseVisualStyleBackColor = true;
            btnasignar.Click += btnasignar_Click;
            // 
            // btnControl
            // 
            btnControl.Enabled = false;
            btnControl.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnControl.IconColor = Color.Black;
            btnControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnControl.IconSize = 20;
            btnControl.Location = new Point(13, 61);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(185, 32);
            btnControl.TabIndex = 29;
            btnControl.Text = "Control de Cambios";
            btnControl.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.IconSize = 20;
            btnActualizar.Location = new Point(204, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(185, 32);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar Informacion";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(13, 12);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 29;
            btnIngresar.Text = "Ingresar Tarea";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnRegistrar_Click;
            // 
            // Cbotipopago
            // 
            Cbotipopago.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbotipopago.FormattingEnabled = true;
            Cbotipopago.Location = new Point(598, 89);
            Cbotipopago.Name = "Cbotipopago";
            Cbotipopago.Size = new Size(200, 23);
            Cbotipopago.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(478, 90);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 39;
            label9.Text = "Tipo Pago:";
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(201, 191);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(200, 23);
            dttFAsignacion.TabIndex = 38;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(598, 125);
            txtvalor.MaxLength = 9;
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(200, 23);
            txtvalor.TabIndex = 37;
            txtvalor.KeyPress += txtvalor_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(201, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(67, 195);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 35;
            label7.Text = "Fecha Asignacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(508, 129);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 34;
            label3.Text = "Valor:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(112, 89);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(60, 17);
            lblNombres.TabIndex = 33;
            lblNombres.Text = "Nombre:";
            // 
            // dtpFFin
            // 
            dtpFFin.Format = DateTimePickerFormat.Short;
            dtpFFin.Location = new Point(201, 230);
            dtpFFin.Name = "dtpFFin";
            dtpFFin.Size = new Size(200, 23);
            dtpFFin.TabIndex = 42;
            dtpFFin.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(64, 234);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 41;
            label1.Text = "Fecha Finalizacion:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(201, 298);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 23);
            cboEstado.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(91, 299);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 43;
            label2.Text = "Estado Tarea:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(93, 125);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 45;
            label4.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(201, 125);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(200, 50);
            txtdescripcion.TabIndex = 46;
            txtdescripcion.Text = "";
            // 
            // txtID
            // 
            txtID.Location = new Point(1, 327);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 47;
            txtID.Visible = false;
            // 
            // cbojornada
            // 
            cbojornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbojornada.FormattingEnabled = true;
            cbojornada.Location = new Point(201, 269);
            cbojornada.Name = "cbojornada";
            cbojornada.Size = new Size(200, 23);
            cbojornada.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(67, 275);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 48;
            label5.Text = "Jornada Laboral:";
            // 
            // FrmTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 369);
            Controls.Add(cbojornada);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(txtdescripcion);
            Controls.Add(label4);
            Controls.Add(cboEstado);
            Controls.Add(label2);
            Controls.Add(dtpFFin);
            Controls.Add(label1);
            Controls.Add(Cbotipopago);
            Controls.Add(label9);
            Controls.Add(dttFAsignacion);
            Controls.Add(txtvalor);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(lblNombres);
            Controls.Add(panelControles);
            Controls.Add(btnListadoTrabajadores);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTareas";
            Text = "FrmTareas";
            Load += FrmTareas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelControles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnListadoTrabajadores;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnControl;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnasignar;
        private ComboBox Cbotipopago;
        private Label label9;
        private DateTimePicker dttFAsignacion;
        private TextBox txtvalor;
        private TextBox txtNombre;
        private Label label7;
        private Label label3;
        private Label lblNombres;
        private DateTimePicker dtpFFin;
        private Label label1;
        private ComboBox cboEstado;
        private Label label2;
        private Label label4;
        private RichTextBox txtdescripcion;
        private TextBox txtID;
        private ComboBox cbojornada;
        private Label label5;
    }
}