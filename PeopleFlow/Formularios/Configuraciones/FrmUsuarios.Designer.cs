namespace PeopleFlow.Formularios.Configuraciones
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            cboCargo = new ComboBox();
            label11 = new Label();
            txtID = new TextBox();
            cboEstado = new ComboBox();
            label2 = new Label();
            txtnombres = new TextBox();
            tztusuario = new TextBox();
            label3 = new Label();
            lblNombres = new Label();
            panelControles = new Panel();
            btnArchivo = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnListadoTrabajadores = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            txtApellidos = new TextBox();
            label1 = new Label();
            txtcorreo = new TextBox();
            label4 = new Label();
            label8 = new Label();
            txtdv = new TextBox();
            txtRut = new TextBox();
            label6 = new Label();
            txtpass = new TextBox();
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(238, 232);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(200, 23);
            cboCargo.TabIndex = 90;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(157, 238);
            label11.Name = "label11";
            label11.Size = new Size(47, 17);
            label11.TabIndex = 89;
            label11.Text = "Cargo:";
            // 
            // txtID
            // 
            txtID.Location = new Point(69, 311);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 88;
            txtID.Visible = false;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(238, 311);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 23);
            cboEstado.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(150, 312);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 81;
            label2.Text = "Estado:";
            // 
            // txtnombres
            // 
            txtnombres.Location = new Point(238, 152);
            txtnombres.MaxLength = 9;
            txtnombres.Name = "txtnombres";
            txtnombres.Size = new Size(200, 23);
            txtnombres.TabIndex = 79;
            // 
            // tztusuario
            // 
            tztusuario.Location = new Point(238, 73);
            tztusuario.Name = "tztusuario";
            tztusuario.Size = new Size(200, 23);
            tztusuario.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(139, 158);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 76;
            label3.Text = "Nombres:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(149, 74);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 17);
            lblNombres.TabIndex = 75;
            lblNombres.Text = "Usuario:";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnArchivo);
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(461, 74);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(401, 153);
            panelControles.TabIndex = 74;
            // 
            // btnArchivo
            // 
            btnArchivo.Enabled = false;
            btnArchivo.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnArchivo.IconColor = Color.Black;
            btnArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArchivo.IconSize = 20;
            btnArchivo.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivo.Location = new Point(9, 60);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(380, 31);
            btnArchivo.TabIndex = 34;
            btnArchivo.Text = "Resetear Contraseña";
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
            btnLimpiar.Location = new Point(13, 108);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 32);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
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
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnListadoTrabajadores
            // 
            btnListadoTrabajadores.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoTrabajadores.IconColor = Color.Black;
            btnListadoTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoTrabajadores.IconSize = 20;
            btnListadoTrabajadores.Location = new Point(224, 12);
            btnListadoTrabajadores.Name = "btnListadoTrabajadores";
            btnListadoTrabajadores.Size = new Size(177, 31);
            btnListadoTrabajadores.TabIndex = 73;
            btnListadoTrabajadores.Text = "Listado de Usuarios";
            btnListadoTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoTrabajadores.UseVisualStyleBackColor = true;
            btnListadoTrabajadores.Click += btnListadoTrabajadores_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 72;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(116, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(102, 30);
            lblTitulo.TabIndex = 71;
            lblTitulo.Text = "Usuarios";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(238, 192);
            txtApellidos.MaxLength = 9;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(200, 23);
            txtApellidos.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(139, 198);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 91;
            label1.Text = "Apellidos:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(238, 271);
            txtcorreo.MaxLength = 500;
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(200, 23);
            txtcorreo.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(149, 277);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 93;
            label4.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(380, 118);
            label8.Name = "label8";
            label8.Size = new Size(13, 17);
            label8.TabIndex = 100;
            label8.Text = "-";
            // 
            // txtdv
            // 
            txtdv.Location = new Point(393, 114);
            txtdv.MaxLength = 1;
            txtdv.Name = "txtdv";
            txtdv.Size = new Size(45, 23);
            txtdv.TabIndex = 99;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(238, 114);
            txtRut.MaxLength = 8;
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(140, 23);
            txtRut.TabIndex = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(180, 115);
            label6.Name = "label6";
            label6.Size = new Size(30, 17);
            label6.TabIndex = 97;
            label6.Text = "Rut:";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(69, 282);
            txtpass.MaxLength = 1;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(45, 23);
            txtpass.TabIndex = 101;
            txtpass.Visible = false;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 377);
            Controls.Add(txtpass);
            Controls.Add(label8);
            Controls.Add(txtdv);
            Controls.Add(txtRut);
            Controls.Add(label6);
            Controls.Add(txtcorreo);
            Controls.Add(label4);
            Controls.Add(txtApellidos);
            Controls.Add(label1);
            Controls.Add(cboCargo);
            Controls.Add(label11);
            Controls.Add(txtID);
            Controls.Add(cboEstado);
            Controls.Add(label2);
            Controls.Add(txtnombres);
            Controls.Add(tztusuario);
            Controls.Add(label3);
            Controls.Add(lblNombres);
            Controls.Add(panelControles);
            Controls.Add(btnListadoTrabajadores);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            panelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private ComboBox cboCargo;
        private Label label11;
        private TextBox txtID;
        private Button button1;
        private ListView listView1;
        private ComboBox cboEmpleados;
        private Label label9;
        private ComboBox cboEstado;
        private Label label2;
        private TextBox txtnombres;
        private TextBox tztusuario;
        private Label label3;
        private Label lblNombres;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnListadoTrabajadores;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtcorreo;
        private Label label4;
        private Label label8;
        private TextBox txtdv;
        private TextBox txtRut;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnArchivo;
        private TextBox txtpass;
    }
}