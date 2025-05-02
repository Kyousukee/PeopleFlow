namespace PeopleFlow.Formularios.Contratos
{
    partial class FrmAnexos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnexos));
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVAnexos = new DataGridView();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            panelControles = new Panel();
            label1 = new Label();
            txtNombreArchivo = new TextBox();
            label17 = new Label();
            txtDetallenombre = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            lblSinAnexos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVAnexos).BeginInit();
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
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(68, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 30);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "Anexos de Contratos";
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(382, 438);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 39;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVAnexos
            // 
            DGVAnexos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAnexos.Location = new Point(12, 60);
            DGVAnexos.Name = "DGVAnexos";
            DGVAnexos.ReadOnly = true;
            DGVAnexos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAnexos.Size = new Size(563, 225);
            DGVAnexos.TabIndex = 38;
            DGVAnexos.CellClick += DGVAnexos_CellClick;
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
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(label1);
            panelControles.Controls.Add(txtNombreArchivo);
            panelControles.Controls.Add(label17);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Controls.Add(txtDetallenombre);
            panelControles.Location = new Point(34, 306);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(507, 126);
            panelControles.TabIndex = 100;
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
            // txtDetallenombre
            // 
            txtDetallenombre.Location = new Point(129, 16);
            txtDetallenombre.MaxLength = 156;
            txtDetallenombre.Name = "txtDetallenombre";
            txtDetallenombre.Size = new Size(354, 23);
            txtDetallenombre.TabIndex = 100;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // lblSinAnexos
            // 
            lblSinAnexos.AutoSize = true;
            lblSinAnexos.Location = new Point(222, 160);
            lblSinAnexos.Name = "lblSinAnexos";
            lblSinAnexos.Size = new Size(147, 15);
            lblSinAnexos.TabIndex = 101;
            lblSinAnexos.Text = "No hay anexos disponibles";
            lblSinAnexos.TextAlign = ContentAlignment.MiddleCenter;
            lblSinAnexos.Visible = false;
            // 
            // FrmAnexos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 481);
            Controls.Add(lblSinAnexos);
            Controls.Add(panelControles);
            Controls.Add(btnsalir);
            Controls.Add(DGVAnexos);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAnexos";
            Text = "Anexos";
            Load += FrmAnexos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVAnexos).EndInit();
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVAnexos;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private Panel panelControles;
        private Label label17;
        private TextBox txtDetallenombre;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtNombreArchivo;
        private Label lblSinAnexos;
        private Label label1;
    }
}