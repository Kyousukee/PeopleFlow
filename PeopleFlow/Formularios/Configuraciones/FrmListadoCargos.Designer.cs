namespace PeopleFlow.Formularios.Configuraciones
{
    partial class FrmListadoCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCargos));
            DGVCargos = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DGVCargos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // DGVCargos
            // 
            DGVCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCargos.Location = new Point(10, 64);
            DGVCargos.Name = "DGVCargos";
            DGVCargos.ReadOnly = true;
            DGVCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCargos.Size = new Size(466, 137);
            DGVCargos.TabIndex = 47;
            DGVCargos.CellDoubleClick += DGVCargos_CellDoubleClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(57, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 30);
            lblTitulo.TabIndex = 45;
            lblTitulo.Text = "Listado de Cargos";
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(317, 207);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 48;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // FrmListadoCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 248);
            Controls.Add(btnsalir);
            Controls.Add(DGVCargos);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListadoCargos";
            Text = "Listado de Cargos";
            Load += FrmListadoCargos_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCargos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVCargos;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}