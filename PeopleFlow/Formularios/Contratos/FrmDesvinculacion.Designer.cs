namespace PeopleFlow.Formularios.Contratos
{
    partial class FrmDesvinculacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesvinculacion));
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            label10 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtTrabajador = new TextBox();
            label2 = new Label();
            txttipocontrato = new TextBox();
            panelControles = new Panel();
            btnArchivo = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtfechaInicio = new TextBox();
            label4 = new Label();
            txtcargo = new TextBox();
            label5 = new Label();
            txtrut = new TextBox();
            txtdv = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            dtpFFin = new DateTimePicker();
            label11 = new Label();
            cboTipoFiniquito = new ComboBox();
            label12 = new Label();
            cboEstado = new ComboBox();
            label13 = new Label();
            txtdescripcion = new RichTextBox();
            label14 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            cboTipoDetalle = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            txtMonto = new TextBox();
            label17 = new Label();
            txtDetallenombre = new TextBox();
            textBox1 = new TextBox();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelControles.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(21, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(68, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 30);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Finiquito";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(195, 82);
            label10.Name = "label10";
            label10.Size = new Size(23, 17);
            label10.TabIndex = 68;
            label10.Text = "N°";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(89, 82);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 67;
            label8.Text = "Contrato:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(240, 80);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(127, 23);
            txtID.TabIndex = 66;
            txtID.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(76, 160);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 70;
            label1.Text = "Trabajador:";
            // 
            // txtTrabajador
            // 
            txtTrabajador.Enabled = false;
            txtTrabajador.Location = new Point(195, 159);
            txtTrabajador.MaxLength = 1;
            txtTrabajador.Name = "txtTrabajador";
            txtTrabajador.Size = new Size(172, 23);
            txtTrabajador.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(59, 199);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 72;
            label2.Text = "Tipo Contrato:";
            // 
            // txttipocontrato
            // 
            txttipocontrato.Enabled = false;
            txttipocontrato.Location = new Point(195, 198);
            txttipocontrato.MaxLength = 1;
            txttipocontrato.Name = "txttipocontrato";
            txttipocontrato.Size = new Size(172, 23);
            txttipocontrato.TabIndex = 71;
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnArchivo);
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(389, 344);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(394, 166);
            panelControles.TabIndex = 73;
            // 
            // btnArchivo
            // 
            btnArchivo.Enabled = false;
            btnArchivo.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnArchivo.IconColor = Color.Black;
            btnArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArchivo.IconSize = 20;
            btnArchivo.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivo.Location = new Point(10, 63);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(373, 31);
            btnArchivo.TabIndex = 34;
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
            btnLimpiar.Location = new Point(10, 116);
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
            btnsalir.Location = new Point(198, 116);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(185, 32);
            btnsalir.TabIndex = 31;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.IconSize = 20;
            btnActualizar.Location = new Point(198, 9);
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
            btnIngresar.Location = new Point(10, 9);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 29;
            btnIngresar.Text = "Ingresar Liquidacion";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(73, 278);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 75;
            label3.Text = "Fecha Inicio:";
            // 
            // txtfechaInicio
            // 
            txtfechaInicio.Enabled = false;
            txtfechaInicio.Location = new Point(195, 277);
            txtfechaInicio.MaxLength = 1;
            txtfechaInicio.Name = "txtfechaInicio";
            txtfechaInicio.Size = new Size(172, 23);
            txtfechaInicio.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(104, 240);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 77;
            label4.Text = "Cargo:";
            // 
            // txtcargo
            // 
            txtcargo.Enabled = false;
            txtcargo.Location = new Point(195, 239);
            txtcargo.MaxLength = 1;
            txtcargo.Name = "txtcargo";
            txtcargo.Size = new Size(172, 23);
            txtcargo.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(121, 119);
            label5.Name = "label5";
            label5.Size = new Size(30, 17);
            label5.TabIndex = 79;
            label5.Text = "Rut:";
            // 
            // txtrut
            // 
            txtrut.Enabled = false;
            txtrut.Location = new Point(195, 118);
            txtrut.MaxLength = 1;
            txtrut.Name = "txtrut";
            txtrut.Size = new Size(125, 23);
            txtrut.TabIndex = 78;
            // 
            // txtdv
            // 
            txtdv.Enabled = false;
            txtdv.Location = new Point(326, 118);
            txtdv.MaxLength = 1;
            txtdv.Name = "txtdv";
            txtdv.Size = new Size(41, 23);
            txtdv.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(59, 58);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 81;
            label6.Text = "Informacion Contrato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(389, 58);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 82;
            label7.Text = "Valores Finiquito";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(59, 318);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 83;
            label9.Text = "Informacion Finiquito";
            // 
            // dtpFFin
            // 
            dtpFFin.Format = DateTimePickerFormat.Short;
            dtpFFin.Location = new Point(195, 340);
            dtpFFin.Name = "dtpFFin";
            dtpFFin.Size = new Size(172, 23);
            dtpFFin.TabIndex = 85;
            dtpFFin.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(24, 344);
            label11.Name = "label11";
            label11.Size = new Size(133, 17);
            label11.TabIndex = 84;
            label11.Text = "Fecha Desvinculacion:";
            // 
            // cboTipoFiniquito
            // 
            cboTipoFiniquito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoFiniquito.FormattingEnabled = true;
            cboTipoFiniquito.Location = new Point(195, 378);
            cboTipoFiniquito.Name = "cboTipoFiniquito";
            cboTipoFiniquito.Size = new Size(172, 23);
            cboTipoFiniquito.TabIndex = 89;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.Location = new Point(67, 379);
            label12.Name = "label12";
            label12.Size = new Size(90, 17);
            label12.TabIndex = 88;
            label12.Text = "Tipo Finiquito:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(195, 422);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(172, 23);
            cboEstado.TabIndex = 87;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(100, 422);
            label13.Name = "label13";
            label13.Size = new Size(51, 17);
            label13.TabIndex = 86;
            label13.Text = "Estado:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(195, 460);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(172, 50);
            txtdescripcion.TabIndex = 91;
            txtdescripcion.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F);
            label14.Location = new Point(67, 461);
            label14.Name = "label14";
            label14.Size = new Size(84, 17);
            label14.TabIndex = 90;
            label14.Text = "Observacion:";
            // 
            // button1
            // 
            button1.Location = new Point(746, 156);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 95;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(389, 206);
            listView1.Name = "listView1";
            listView1.Size = new Size(394, 126);
            listView1.TabIndex = 94;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // cboTipoDetalle
            // 
            cboTipoDetalle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDetalle.FormattingEnabled = true;
            cboTipoDetalle.Location = new Point(493, 82);
            cboTipoDetalle.Name = "cboTipoDetalle";
            cboTipoDetalle.Size = new Size(247, 23);
            cboTipoDetalle.TabIndex = 93;
            cboTipoDetalle.SelectedValueChanged += cboTipoDetalle_SelectedValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F);
            label15.Location = new Point(379, 83);
            label15.Name = "label15";
            label15.Size = new Size(104, 17);
            label15.TabIndex = 92;
            label15.Text = "Detalle Finiquito:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F);
            label16.Location = new Point(442, 160);
            label16.Name = "label16";
            label16.Size = new Size(41, 17);
            label16.TabIndex = 99;
            label16.Text = "Valor:";
            // 
            // txtMonto
            // 
            txtMonto.Enabled = false;
            txtMonto.Location = new Point(493, 158);
            txtMonto.MaxLength = 49;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(247, 23);
            txtMonto.TabIndex = 98;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F);
            label17.Location = new Point(389, 120);
            label17.Name = "label17";
            label17.Size = new Size(94, 17);
            label17.TabIndex = 97;
            label17.Text = "Nombre Valor:";
            // 
            // txtDetallenombre
            // 
            txtDetallenombre.Enabled = false;
            txtDetallenombre.Location = new Point(493, 119);
            txtDetallenombre.MaxLength = 156;
            txtDetallenombre.Name = "txtDetallenombre";
            txtDetallenombre.Size = new Size(247, 23);
            txtDetallenombre.TabIndex = 96;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-12, 513);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 23);
            textBox1.TabIndex = 100;
            textBox1.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(496, 182);
            label18.Name = "label18";
            label18.Size = new Size(133, 15);
            label18.TabIndex = 101;
            label18.Text = "Valor puede ser editado.";
            // 
            // FrmDesvinculacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(label18);
            Controls.Add(textBox1);
            Controls.Add(label16);
            Controls.Add(txtMonto);
            Controls.Add(label17);
            Controls.Add(txtDetallenombre);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(cboTipoDetalle);
            Controls.Add(label15);
            Controls.Add(txtdescripcion);
            Controls.Add(label14);
            Controls.Add(cboTipoFiniquito);
            Controls.Add(label12);
            Controls.Add(cboEstado);
            Controls.Add(label13);
            Controls.Add(dtpFFin);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtdv);
            Controls.Add(label5);
            Controls.Add(txtrut);
            Controls.Add(label4);
            Controls.Add(txtcargo);
            Controls.Add(label3);
            Controls.Add(txtfechaInicio);
            Controls.Add(panelControles);
            Controls.Add(label2);
            Controls.Add(txttipocontrato);
            Controls.Add(label1);
            Controls.Add(txtTrabajador);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(txtID);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDesvinculacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desvinculacion";
            Load += FrmDesvinculacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelControles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Label label10;
        private Label label8;
        private TextBox txtID;
        private Label label1;
        private TextBox txtTrabajador;
        private Label label2;
        private TextBox txttipocontrato;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private Label label3;
        private TextBox txtfechaInicio;
        private Label label4;
        private TextBox txtcargo;
        private Label label5;
        private TextBox txtrut;
        private TextBox txtdv;
        private Label label6;
        private Label label7;
        private Label label9;
        private DateTimePicker dtpFFin;
        private Label label11;
        private ComboBox cboTipoFiniquito;
        private Label label12;
        private ComboBox cboEstado;
        private Label label13;
        private RichTextBox txtdescripcion;
        private Label label14;
        private Button button1;
        private ListView listView1;
        private ComboBox cboTipoDetalle;
        private Label label15;
        private Label label16;
        private TextBox txtMonto;
        private Label label17;
        private TextBox txtDetallenombre;
        private FontAwesome.Sharp.IconButton btnArchivo;
        private TextBox textBox1;
        private Label label18;
    }
}