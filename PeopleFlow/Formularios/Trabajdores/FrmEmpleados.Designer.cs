namespace PeopleFlow.Formularios
{
    partial class FrmEmpleados
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            lblTitulo = new Label();
            pictureBox6 = new PictureBox();
            lblNombres = new Label();
            lblApellidos = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtRut = new TextBox();
            txtdv = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtfono = new TextBox();
            txtcorreo = new TextBox();
            fontDialog1 = new FontDialog();
            txtdireccion = new RichTextBox();
            dttFIngreso = new DateTimePicker();
            cboEstado = new ComboBox();
            DttFNacimiento = new DateTimePicker();
            panelControles = new Panel();
            btnCarga = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnLiquidaciones = new FontAwesome.Sharp.IconButton();
            btnContrato = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnListadoTrabajadores = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            btnListado2 = new FontAwesome.Sharp.IconButton();
            btnExit2 = new FontAwesome.Sharp.IconButton();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            CboCargos = new ComboBox();
            label9 = new Label();
            txtID = new TextBox();
            cboCivil = new ComboBox();
            label10 = new Label();
            txtnacionalidad = new TextBox();
            label11 = new Label();
            txtprofesion = new TextBox();
            label12 = new Label();
            txtBanco = new TextBox();
            label13 = new Label();
            txtcuenta = new TextBox();
            label14 = new Label();
            txtnumeroC = new TextBox();
            label15 = new Label();
            cboSalud = new ComboBox();
            label16 = new Label();
            cboAFP = new ComboBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(116, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(187, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Tus Trabajadores";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(109, 126);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(66, 17);
            lblNombres.TabIndex = 7;
            lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9.75F);
            lblApellidos.Location = new Point(109, 165);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(65, 17);
            lblApellidos.TabIndex = 8;
            lblApellidos.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(140, 84);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 9;
            label1.Text = "Rut:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(122, 245);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 10;
            label2.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(112, 205);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 11;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(460, 84);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 12;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(105, 414);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 13;
            label5.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(521, 245);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 14;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(483, 126);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 15;
            label7.Text = "Fecha Ingreso:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(198, 83);
            txtRut.MaxLength = 8;
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(140, 23);
            txtRut.TabIndex = 16;
            txtRut.KeyPress += txtRut_KeyPress;
            // 
            // txtdv
            // 
            txtdv.Location = new Point(353, 83);
            txtdv.MaxLength = 1;
            txtdv.Name = "txtdv";
            txtdv.Size = new Size(45, 23);
            txtdv.TabIndex = 17;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(198, 125);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(200, 23);
            txtNombres.TabIndex = 18;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(198, 164);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(200, 23);
            txtApellidos.TabIndex = 19;
            // 
            // txtfono
            // 
            txtfono.Location = new Point(198, 204);
            txtfono.MaxLength = 9;
            txtfono.Name = "txtfono";
            txtfono.Size = new Size(200, 23);
            txtfono.TabIndex = 20;
            txtfono.KeyPress += txtfono_KeyPress;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(198, 244);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(200, 23);
            txtcorreo.TabIndex = 21;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(198, 414);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(200, 124);
            txtdireccion.TabIndex = 22;
            txtdireccion.Text = "";
            // 
            // dttFIngreso
            // 
            dttFIngreso.Format = DateTimePickerFormat.Short;
            dttFIngreso.Location = new Point(617, 125);
            dttFIngreso.Name = "dttFIngreso";
            dttFIngreso.Size = new Size(211, 23);
            dttFIngreso.TabIndex = 23;
            dttFIngreso.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(617, 244);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(211, 23);
            cboEstado.TabIndex = 25;
            // 
            // DttFNacimiento
            // 
            DttFNacimiento.Format = DateTimePickerFormat.Short;
            DttFNacimiento.Location = new Point(617, 80);
            DttFNacimiento.Name = "DttFNacimiento";
            DttFNacimiento.Size = new Size(211, 23);
            DttFNacimiento.TabIndex = 26;
            DttFNacimiento.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnCarga);
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnLiquidaciones);
            panelControles.Controls.Add(btnContrato);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(460, 352);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(388, 186);
            panelControles.TabIndex = 27;
            // 
            // btnCarga
            // 
            btnCarga.Enabled = false;
            btnCarga.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnCarga.IconColor = Color.Black;
            btnCarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCarga.IconSize = 20;
            btnCarga.ImageAlign = ContentAlignment.MiddleRight;
            btnCarga.Location = new Point(3, 98);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(376, 31);
            btnCarga.TabIndex = 34;
            btnCarga.Text = "Asignacion Carga Familiar";
            btnCarga.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(3, 136);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 32);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += iconButton1_Click;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(194, 136);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(185, 32);
            btnsalir.TabIndex = 31;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnLiquidaciones
            // 
            btnLiquidaciones.Enabled = false;
            btnLiquidaciones.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnLiquidaciones.IconColor = Color.Black;
            btnLiquidaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLiquidaciones.IconSize = 20;
            btnLiquidaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnLiquidaciones.Location = new Point(194, 60);
            btnLiquidaciones.Name = "btnLiquidaciones";
            btnLiquidaciones.Size = new Size(185, 32);
            btnLiquidaciones.TabIndex = 29;
            btnLiquidaciones.Text = "Liquidaciones";
            btnLiquidaciones.UseVisualStyleBackColor = true;
            btnLiquidaciones.Click += btnLiquidaciones_Click;
            // 
            // btnContrato
            // 
            btnContrato.Enabled = false;
            btnContrato.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnContrato.IconColor = Color.Black;
            btnContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContrato.IconSize = 20;
            btnContrato.Location = new Point(3, 60);
            btnContrato.Name = "btnContrato";
            btnContrato.Size = new Size(185, 32);
            btnContrato.TabIndex = 29;
            btnContrato.Text = "Contrato de Trabajo";
            btnContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContrato.UseVisualStyleBackColor = true;
            btnContrato.Click += btnContrato_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.IconSize = 20;
            btnActualizar.Location = new Point(194, 12);
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
            btnIngresar.Location = new Point(3, 12);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 29;
            btnIngresar.Text = "Ingresar Trabajador";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnListadoTrabajadores
            // 
            btnListadoTrabajadores.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoTrabajadores.IconColor = Color.Black;
            btnListadoTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoTrabajadores.IconSize = 20;
            btnListadoTrabajadores.Location = new Point(309, 8);
            btnListadoTrabajadores.Name = "btnListadoTrabajadores";
            btnListadoTrabajadores.Size = new Size(184, 31);
            btnListadoTrabajadores.TabIndex = 30;
            btnListadoTrabajadores.Text = "Listado de Trabajores";
            btnListadoTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoTrabajadores.UseVisualStyleBackColor = true;
            btnListadoTrabajadores.Click += btnListadoTrabajadores_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(340, 87);
            label8.Name = "label8";
            label8.Size = new Size(13, 17);
            label8.TabIndex = 28;
            label8.Text = "-";
            // 
            // btnListado2
            // 
            btnListado2.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnListado2.IconColor = Color.Black;
            btnListado2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListado2.IconSize = 20;
            btnListado2.Location = new Point(0, 0);
            btnListado2.Name = "btnListado2";
            btnListado2.Size = new Size(75, 23);
            btnListado2.TabIndex = 0;
            // 
            // btnExit2
            // 
            btnExit2.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnExit2.IconColor = Color.Black;
            btnExit2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit2.IconSize = 30;
            btnExit2.Location = new Point(0, 0);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(75, 23);
            btnExit2.TabIndex = 0;
            // 
            // CboCargos
            // 
            CboCargos.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCargos.FormattingEnabled = true;
            CboCargos.Location = new Point(617, 165);
            CboCargos.Name = "CboCargos";
            CboCargos.Size = new Size(211, 23);
            CboCargos.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(521, 166);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 29;
            label9.Text = "Cargo:";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 435);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 31;
            txtID.Visible = false;
            // 
            // cboCivil
            // 
            cboCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCivil.FormattingEnabled = true;
            cboCivil.Location = new Point(617, 204);
            cboCivil.Name = "cboCivil";
            cboCivil.Size = new Size(211, 23);
            cboCivil.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(490, 205);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 32;
            label10.Text = "Estado Civil:";
            // 
            // txtnacionalidad
            // 
            txtnacionalidad.Location = new Point(198, 283);
            txtnacionalidad.Name = "txtnacionalidad";
            txtnacionalidad.Size = new Size(200, 23);
            txtnacionalidad.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(87, 284);
            label11.Name = "label11";
            label11.Size = new Size(88, 17);
            label11.TabIndex = 34;
            label11.Text = "Nacionalidad:";
            // 
            // txtprofesion
            // 
            txtprofesion.Location = new Point(198, 318);
            txtprofesion.Name = "txtprofesion";
            txtprofesion.Size = new Size(200, 23);
            txtprofesion.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.Location = new Point(107, 319);
            label12.Name = "label12";
            label12.Size = new Size(66, 17);
            label12.TabIndex = 36;
            label12.Text = "Profesion:";
            // 
            // txtBanco
            // 
            txtBanco.Location = new Point(617, 278);
            txtBanco.Name = "txtBanco";
            txtBanco.Size = new Size(211, 23);
            txtBanco.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(525, 278);
            label13.Name = "label13";
            label13.Size = new Size(46, 17);
            label13.TabIndex = 38;
            label13.Text = "Banco:";
            // 
            // txtcuenta
            // 
            txtcuenta.Location = new Point(617, 313);
            txtcuenta.Name = "txtcuenta";
            txtcuenta.Size = new Size(78, 23);
            txtcuenta.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F);
            label14.Location = new Point(490, 314);
            label14.Name = "label14";
            label14.Size = new Size(81, 17);
            label14.TabIndex = 40;
            label14.Text = "Tipo Cuenta:";
            // 
            // txtnumeroC
            // 
            txtnumeroC.Location = new Point(728, 314);
            txtnumeroC.Name = "txtnumeroC";
            txtnumeroC.Size = new Size(100, 23);
            txtnumeroC.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F);
            label15.Location = new Point(701, 315);
            label15.Name = "label15";
            label15.Size = new Size(23, 17);
            label15.TabIndex = 43;
            label15.Text = "N°";
            // 
            // cboSalud
            // 
            cboSalud.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSalud.FormattingEnabled = true;
            cboSalud.Location = new Point(198, 352);
            cboSalud.Name = "cboSalud";
            cboSalud.Size = new Size(200, 23);
            cboSalud.TabIndex = 45;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F);
            label16.Location = new Point(127, 353);
            label16.Name = "label16";
            label16.Size = new Size(43, 17);
            label16.TabIndex = 44;
            label16.Text = "Salud:";
            // 
            // cboAFP
            // 
            cboAFP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAFP.FormattingEnabled = true;
            cboAFP.Location = new Point(198, 385);
            cboAFP.Name = "cboAFP";
            cboAFP.Size = new Size(200, 23);
            cboAFP.TabIndex = 47;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F);
            label17.Location = new Point(138, 386);
            label17.Name = "label17";
            label17.Size = new Size(32, 17);
            label17.TabIndex = 46;
            label17.Text = "AFP:";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 566);
            Controls.Add(cboAFP);
            Controls.Add(label17);
            Controls.Add(cboSalud);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(txtnumeroC);
            Controls.Add(txtcuenta);
            Controls.Add(label14);
            Controls.Add(txtBanco);
            Controls.Add(label13);
            Controls.Add(txtprofesion);
            Controls.Add(label12);
            Controls.Add(txtnacionalidad);
            Controls.Add(label11);
            Controls.Add(cboCivil);
            Controls.Add(label10);
            Controls.Add(txtID);
            Controls.Add(btnListadoTrabajadores);
            Controls.Add(CboCargos);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panelControles);
            Controls.Add(DttFNacimiento);
            Controls.Add(cboEstado);
            Controls.Add(dttFIngreso);
            Controls.Add(txtdireccion);
            Controls.Add(txtcorreo);
            Controls.Add(txtfono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtdv);
            Controls.Add(txtRut);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombres);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Load += FrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label lblTitulo;
        private PictureBox pictureBox6;
        private Label lblNombres;
        private Label lblApellidos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRut;
        private TextBox txtdv;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtfono;
        private TextBox txtcorreo;
        private FontDialog fontDialog1;
        private RichTextBox txtdireccion;
        private DateTimePicker dttFIngreso;
        private ComboBox cboEstado;
        private DateTimePicker DttFNacimiento;
        private Panel panelControles;
        private Button btnListado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnLiquidaciones;
        private FontAwesome.Sharp.IconButton btnContrato;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnListado2;
        private FontAwesome.Sharp.IconButton btnExit2;
        private BindingSource bindingSource1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnListadoTrabajadores;
        private BindingSource bindingSource2;
        private ComboBox CboCargos;
        private Label label9;
        private TextBox txtID;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private ComboBox cboCivil;
        private Label label10;
        private TextBox txtnacionalidad;
        private Label label11;
        private TextBox txtprofesion;
        private Label label12;
        private TextBox txtBanco;
        private Label label13;
        private TextBox txtcuenta;
        private Label label14;
        private TextBox txtnumeroC;
        private Label label15;
        private ComboBox cboSalud;
        private Label label16;
        private ComboBox cboAFP;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnCarga;
    }
}