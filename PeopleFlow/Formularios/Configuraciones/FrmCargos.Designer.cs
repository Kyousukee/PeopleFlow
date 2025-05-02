namespace PeopleFlow.Formularios.Configuraciones
{
    partial class FrmCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargos));
            txtID = new TextBox();
            cboEstado = new ComboBox();
            label2 = new Label();
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
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(47, 117);
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
            cboEstado.Location = new Point(233, 114);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 23);
            cboEstado.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(153, 115);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 81;
            label2.Text = "Estado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(233, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 78;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(125, 75);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(79, 17);
            lblNombres.TabIndex = 75;
            lblNombres.Text = "Descripcion:";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(472, 57);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(406, 94);
            panelControles.TabIndex = 74;
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
            btnsalir.Location = new Point(204, 53);
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
            btnListadoCargos.Location = new Point(247, 13);
            btnListadoCargos.Name = "btnListadoCargos";
            btnListadoCargos.Size = new Size(177, 31);
            btnListadoCargos.TabIndex = 73;
            btnListadoCargos.Text = "Listado de Cargos";
            btnListadoCargos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoCargos.UseVisualStyleBackColor = true;
            btnListadoCargos.Click += btnListadoCargos_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 13);
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
            lblTitulo.Location = new Point(116, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(125, 30);
            lblTitulo.TabIndex = 71;
            lblTitulo.Text = "Tus Cargos";
            // 
            // FrmCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 182);
            Controls.Add(txtID);
            Controls.Add(cboEstado);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(lblNombres);
            Controls.Add(panelControles);
            Controls.Add(btnListadoCargos);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCargos";
            Text = "FrmCargos";
            Load += FrmCargos_Load;
            panelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtID;
        private ComboBox cboEstado;
        private Label label2;
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
    }
}