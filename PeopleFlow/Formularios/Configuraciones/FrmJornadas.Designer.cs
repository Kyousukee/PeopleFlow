namespace PeopleFlow.Formularios.Configuraciones
{
    partial class FrmJornadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJornadas));
            txtID = new TextBox();
            txtNombre = new TextBox();
            lblNombres = new Label();
            panelControles = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnListadoCargos = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            dtttermino = new DateTimePicker();
            dttinicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dtttermino2 = new DateTimePicker();
            dttinicio2 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboDiaComienzo = new ComboBox();
            label8 = new Label();
            CboDiaFin = new ComboBox();
            label9 = new Label();
            txtHoras = new TextBox();
            label10 = new Label();
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(49, 321);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 97;
            txtID.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(235, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 94;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(127, 65);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(79, 17);
            lblNombres.TabIndex = 93;
            lblNombres.Text = "Descripcion:";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(468, 64);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(404, 95);
            panelControles.TabIndex = 92;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(13, 54);
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
            btnsalir.Location = new Point(204, 54);
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
            btnIngresar.Text = "Ingresar Cargo";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnListadoCargos
            // 
            btnListadoCargos.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoCargos.IconColor = Color.Black;
            btnListadoCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoCargos.IconSize = 20;
            btnListadoCargos.Location = new Point(268, 6);
            btnListadoCargos.Name = "btnListadoCargos";
            btnListadoCargos.Size = new Size(177, 31);
            btnListadoCargos.TabIndex = 91;
            btnListadoCargos.Text = "Listado de Jornadas";
            btnListadoCargos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoCargos.UseVisualStyleBackColor = true;
            btnListadoCargos.Click += btnListadoCargos_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 90;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(116, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 30);
            lblTitulo.TabIndex = 89;
            lblTitulo.Text = "Tus Jornadas";
            // 
            // dtttermino
            // 
            dtttermino.Location = new Point(371, 183);
            dtttermino.Name = "dtttermino";
            dtttermino.Size = new Size(60, 23);
            dtttermino.TabIndex = 102;
            // 
            // dttinicio
            // 
            dttinicio.Location = new Point(258, 183);
            dttinicio.Name = "dttinicio";
            dttinicio.Size = new Size(60, 23);
            dttinicio.TabIndex = 101;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(324, 187);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 100;
            label4.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(235, 187);
            label3.Name = "label3";
            label3.Size = new Size(24, 17);
            label3.TabIndex = 99;
            label3.Text = "De";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(116, 187);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 98;
            label1.Text = "Hora Semana:";
            // 
            // dtttermino2
            // 
            dtttermino2.Enabled = false;
            dtttermino2.Location = new Point(371, 226);
            dtttermino2.Name = "dtttermino2";
            dtttermino2.Size = new Size(60, 23);
            dtttermino2.TabIndex = 107;
            // 
            // dttinicio2
            // 
            dttinicio2.Enabled = false;
            dttinicio2.Location = new Point(258, 226);
            dttinicio2.Name = "dttinicio2";
            dttinicio2.Size = new Size(60, 23);
            dttinicio2.TabIndex = 106;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(324, 230);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 105;
            label5.Text = "Hasta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(235, 230);
            label6.Name = "label6";
            label6.Size = new Size(24, 17);
            label6.TabIndex = 104;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(81, 230);
            label7.Name = "label7";
            label7.Size = new Size(125, 17);
            label7.TabIndex = 103;
            label7.Text = "Hora Finde Semana:";
            // 
            // cboDiaComienzo
            // 
            cboDiaComienzo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiaComienzo.FormattingEnabled = true;
            cboDiaComienzo.Location = new Point(235, 107);
            cboDiaComienzo.Name = "cboDiaComienzo";
            cboDiaComienzo.Size = new Size(200, 23);
            cboDiaComienzo.TabIndex = 109;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(113, 108);
            label8.Name = "label8";
            label8.Size = new Size(92, 17);
            label8.TabIndex = 108;
            label8.Text = "Dia Comienzo:";
            // 
            // CboDiaFin
            // 
            CboDiaFin.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDiaFin.FormattingEnabled = true;
            CboDiaFin.Location = new Point(235, 145);
            CboDiaFin.Name = "CboDiaFin";
            CboDiaFin.Size = new Size(200, 23);
            CboDiaFin.TabIndex = 111;
            CboDiaFin.SelectedValueChanged += CboDiaFin_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(124, 146);
            label9.Name = "label9";
            label9.Size = new Size(81, 17);
            label9.TabIndex = 110;
            label9.Text = "Dia Termino:";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(235, 265);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(83, 23);
            txtHoras.TabIndex = 113;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(94, 266);
            label10.Name = "label10";
            label10.Size = new Size(112, 17);
            label10.TabIndex = 112;
            label10.Text = "Horas Semanales:";
            // 
            // FrmJornadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 356);
            Controls.Add(txtHoras);
            Controls.Add(label10);
            Controls.Add(CboDiaFin);
            Controls.Add(label9);
            Controls.Add(cboDiaComienzo);
            Controls.Add(label8);
            Controls.Add(dtttermino2);
            Controls.Add(dttinicio2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(dtttermino);
            Controls.Add(dttinicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(txtNombre);
            Controls.Add(lblNombres);
            Controls.Add(panelControles);
            Controls.Add(btnListadoCargos);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmJornadas";
            Text = "FrmJornadas";
            Load += FrmJornadas_Load;
            panelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNombre;
        private Label lblNombres;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnListadoCargos;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private DateTimePicker dtttermino;
        private DateTimePicker dttinicio;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dtttermino2;
        private DateTimePicker dttinicio2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboDiaComienzo;
        private Label label8;
        private ComboBox CboDiaFin;
        private Label label9;
        private TextBox txtHoras;
        private Label label10;
    }
}