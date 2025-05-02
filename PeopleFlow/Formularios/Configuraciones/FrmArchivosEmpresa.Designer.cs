namespace PeopleFlow.Formularios.Configuraciones
{
    partial class FrmArchivosEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivosEmpresa));
            lblSinAnexos = new Label();
            panelControles = new Panel();
            label1 = new Label();
            txtNombreArchivo = new TextBox();
            label17 = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            txtDetallenombre = new TextBox();
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVArchivos = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVArchivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblSinAnexos
            // 
            lblSinAnexos.AutoSize = true;
            lblSinAnexos.Location = new Point(383, 133);
            lblSinAnexos.Name = "lblSinAnexos";
            lblSinAnexos.Size = new Size(147, 15);
            lblSinAnexos.TabIndex = 107;
            lblSinAnexos.Text = "No hay anexos disponibles";
            lblSinAnexos.TextAlign = ContentAlignment.MiddleCenter;
            lblSinAnexos.Visible = false;
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(label1);
            panelControles.Controls.Add(txtNombreArchivo);
            panelControles.Controls.Add(label17);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Controls.Add(txtDetallenombre);
            panelControles.Location = new Point(205, 276);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(507, 126);
            panelControles.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 53);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 105;
            label1.Text = "Seleccionar Archivo:";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(129, 49);
            txtNombreArchivo.MaxLength = 156;
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(354, 23);
            txtNombreArchivo.TabIndex = 104;
            txtNombreArchivo.Click += btnSubirArchivo_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F);
            label17.Location = new Point(9, 17);
            label17.Name = "label17";
            label17.Size = new Size(43, 17);
            label17.TabIndex = 101;
            label17.Text = "Titulo:";
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(324, 76);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 32);
            btnIngresar.TabIndex = 40;
            btnIngresar.Text = "Guardar Anexo";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDetallenombre
            // 
            txtDetallenombre.Location = new Point(129, 16);
            txtDetallenombre.MaxLength = 156;
            txtDetallenombre.Name = "txtDetallenombre";
            txtDetallenombre.Size = new Size(354, 23);
            txtDetallenombre.TabIndex = 100;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(587, 409);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 105;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVArchivos
            // 
            DGVArchivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVArchivos.Location = new Point(183, 45);
            DGVArchivos.Name = "DGVArchivos";
            DGVArchivos.ReadOnly = true;
            DGVArchivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVArchivos.Size = new Size(563, 225);
            DGVArchivos.TabIndex = 104;
            DGVArchivos.CellClick += DGVArchivos_CellClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 103;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(110, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 30);
            lblTitulo.TabIndex = 102;
            lblTitulo.Text = "Archivos Empresas";
            // 
            // FrmArchivosEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 452);
            Controls.Add(lblSinAnexos);
            Controls.Add(panelControles);
            Controls.Add(btnsalir);
            Controls.Add(DGVArchivos);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmArchivosEmpresa";
            Text = "Archivos Empresas";
            Load += FrmArchivosEmpresa_Load;
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVArchivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSinAnexos;
        private Panel panelControles;
        private Label label1;
        private TextBox txtNombreArchivo;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private TextBox txtDetallenombre;
        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVArchivos;
        private PictureBox pictureBox6;
        private Label lblTitulo;
    }
}