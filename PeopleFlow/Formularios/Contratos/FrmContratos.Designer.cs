namespace PeopleFlow.Formularios
{
    partial class FrmContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratos));
            btnListadoTrabajadores = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            cboEmpleados = new ComboBox();
            label9 = new Label();
            pContratos = new Panel();
            cboTareas = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            panelControles = new Panel();
            btnArchivo = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btndesvincular = new FontAwesome.Sharp.IconButton();
            btnanexos = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            cboEstado = new ComboBox();
            label6 = new Label();
            txtnumero = new TextBox();
            label5 = new Label();
            cboplazo = new ComboBox();
            label3 = new Label();
            txtdescripcion = new RichTextBox();
            label4 = new Label();
            cbotipocontrato = new ComboBox();
            label2 = new Label();
            dtpFFin = new DateTimePicker();
            label1 = new Label();
            dttFAsignacion = new DateTimePicker();
            label7 = new Label();
            txtID = new TextBox();
            btnsalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pContratos.SuspendLayout();
            panelControles.SuspendLayout();
            SuspendLayout();
            // 
            // btnListadoTrabajadores
            // 
            btnListadoTrabajadores.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoTrabajadores.IconColor = Color.Black;
            btnListadoTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoTrabajadores.IconSize = 20;
            btnListadoTrabajadores.Location = new Point(271, 11);
            btnListadoTrabajadores.Name = "btnListadoTrabajadores";
            btnListadoTrabajadores.Size = new Size(196, 31);
            btnListadoTrabajadores.TabIndex = 34;
            btnListadoTrabajadores.Text = "Listado de Contratos";
            btnListadoTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoTrabajadores.UseVisualStyleBackColor = true;
            btnListadoTrabajadores.Click += btnListadoTrabajadores_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(63, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(110, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(155, 30);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Tus Contratos";
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(246, 70);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(657, 23);
            cboEmpleados.TabIndex = 42;
            cboEmpleados.SelectedValueChanged += cboEmpleados_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(63, 71);
            label9.Name = "label9";
            label9.Size = new Size(164, 17);
            label9.TabIndex = 41;
            label9.Text = "SELECCIONE TRABAJADOR";
            // 
            // pContratos
            // 
            pContratos.Controls.Add(cboTareas);
            pContratos.Controls.Add(label11);
            pContratos.Controls.Add(label10);
            pContratos.Controls.Add(label8);
            pContratos.Controls.Add(panelControles);
            pContratos.Controls.Add(cboEstado);
            pContratos.Controls.Add(label6);
            pContratos.Controls.Add(txtnumero);
            pContratos.Controls.Add(label5);
            pContratos.Controls.Add(cboplazo);
            pContratos.Controls.Add(label3);
            pContratos.Controls.Add(txtdescripcion);
            pContratos.Controls.Add(label4);
            pContratos.Controls.Add(cbotipocontrato);
            pContratos.Controls.Add(label2);
            pContratos.Controls.Add(dtpFFin);
            pContratos.Controls.Add(label1);
            pContratos.Controls.Add(dttFAsignacion);
            pContratos.Controls.Add(label7);
            pContratos.Controls.Add(txtID);
            pContratos.Enabled = false;
            pContratos.Location = new Point(63, 111);
            pContratos.Name = "pContratos";
            pContratos.Size = new Size(840, 292);
            pContratos.TabIndex = 43;
            // 
            // cboTareas
            // 
            cboTareas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTareas.FormattingEnabled = true;
            cboTareas.Location = new Point(183, 164);
            cboTareas.Name = "cboTareas";
            cboTareas.Size = new Size(200, 23);
            cboTareas.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(19, 170);
            label11.Name = "label11";
            label11.Size = new Size(108, 17);
            label11.TabIndex = 66;
            label11.Text = "Tarea Referencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(183, 16);
            label10.Name = "label10";
            label10.Size = new Size(23, 17);
            label10.TabIndex = 65;
            label10.Text = "N°";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(65, 16);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 64;
            label8.Text = "Contrato:";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnArchivo);
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btndesvincular);
            panelControles.Controls.Add(btnanexos);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(420, 36);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(405, 214);
            panelControles.TabIndex = 63;
            // 
            // btnArchivo
            // 
            btnArchivo.Enabled = false;
            btnArchivo.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnArchivo.IconColor = Color.Black;
            btnArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArchivo.IconSize = 20;
            btnArchivo.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivo.Location = new Point(13, 70);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(376, 31);
            btnArchivo.TabIndex = 33;
            btnArchivo.Text = "Ver y Descargar Archivo";
            btnArchivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(13, 162);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 32);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btndesvincular
            // 
            btndesvincular.Enabled = false;
            btndesvincular.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            btndesvincular.IconColor = Color.Black;
            btndesvincular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btndesvincular.IconSize = 20;
            btndesvincular.ImageAlign = ContentAlignment.MiddleLeft;
            btndesvincular.Location = new Point(204, 108);
            btndesvincular.Name = "btndesvincular";
            btndesvincular.Size = new Size(185, 32);
            btndesvincular.TabIndex = 29;
            btndesvincular.Text = "Desvinculacion";
            btndesvincular.UseVisualStyleBackColor = true;
            btndesvincular.Click += btndesvincular_Click;
            // 
            // btnanexos
            // 
            btnanexos.Enabled = false;
            btnanexos.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnanexos.IconColor = Color.Black;
            btnanexos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnanexos.IconSize = 20;
            btnanexos.Location = new Point(13, 108);
            btnanexos.Name = "btnanexos";
            btnanexos.Size = new Size(185, 32);
            btnanexos.TabIndex = 29;
            btnanexos.Text = "Anexos";
            btnanexos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnanexos.UseVisualStyleBackColor = true;
            btnanexos.Click += btnanexos_Click;
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
            btnIngresar.Enabled = false;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(13, 12);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 29;
            btnIngresar.Text = "Ingresar Contrato";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(183, 256);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 23);
            cboEstado.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(76, 257);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 61;
            label6.Text = "Estado:";
            // 
            // txtnumero
            // 
            txtnumero.Enabled = false;
            txtnumero.Location = new Point(319, 135);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(64, 23);
            txtnumero.TabIndex = 60;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(290, 135);
            label5.Name = "label5";
            label5.Size = new Size(23, 17);
            label5.TabIndex = 59;
            label5.Text = "N°";
            // 
            // cboplazo
            // 
            cboplazo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboplazo.Enabled = false;
            cboplazo.FormattingEnabled = true;
            cboplazo.Location = new Point(183, 134);
            cboplazo.Name = "cboplazo";
            cboplazo.Size = new Size(101, 23);
            cboplazo.TabIndex = 58;
            cboplazo.SelectedValueChanged += cboplazo_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(55, 135);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 57;
            label3.Text = "Tipo Plazo:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(183, 200);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(200, 50);
            txtdescripcion.TabIndex = 56;
            txtdescripcion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(48, 201);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 55;
            label4.Text = "Descripcion:";
            // 
            // cbotipocontrato
            // 
            cbotipocontrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipocontrato.FormattingEnabled = true;
            cbotipocontrato.Location = new Point(183, 105);
            cbotipocontrato.Name = "cbotipocontrato";
            cbotipocontrato.Size = new Size(200, 23);
            cbotipocontrato.TabIndex = 54;
            cbotipocontrato.SelectedValueChanged += cbotipocontrato_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(35, 106);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 53;
            label2.Text = "Tipo Contrato:";
            // 
            // dtpFFin
            // 
            dtpFFin.Enabled = false;
            dtpFFin.Format = DateTimePickerFormat.Short;
            dtpFFin.Location = new Point(183, 76);
            dtpFFin.Name = "dtpFFin";
            dtpFFin.Size = new Size(200, 23);
            dtpFFin.TabIndex = 52;
            dtpFFin.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(13, 80);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 51;
            label1.Text = "Fecha Finalizacion:";
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(183, 44);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(200, 23);
            dttFAsignacion.TabIndex = 50;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(49, 48);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 49;
            label7.Text = "Fecha Inicio:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(216, 14);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(85, 23);
            txtID.TabIndex = 48;
            txtID.Text = "0";
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(744, 409);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 31;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // FrmContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 452);
            Controls.Add(pContratos);
            Controls.Add(cboEmpleados);
            Controls.Add(btnsalir);
            Controls.Add(label9);
            Controls.Add(btnListadoTrabajadores);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContratos";
            Text = "Contratos";
            Load += FrmContratos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pContratos.ResumeLayout(false);
            pContratos.PerformLayout();
            panelControles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnListadoTrabajadores;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private ComboBox cboEmpleados;
        private Label label9;
        private Panel pContratos;
        private TextBox txtID;
        private DateTimePicker dttFAsignacion;
        private Label label7;
        private DateTimePicker dtpFFin;
        private Label label1;
        private ComboBox cbotipocontrato;
        private Label label2;
        private ComboBox cboplazo;
        private Label label3;
        private RichTextBox txtdescripcion;
        private Label label4;
        private Label label5;
        private TextBox txtnumero;
        private ComboBox cboEstado;
        private Label label6;
        private Label label10;
        private Label label8;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btndesvincular;
        private FontAwesome.Sharp.IconButton btnanexos;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnArchivo;
        private ComboBox cboTareas;
        private Label label11;
    }
}