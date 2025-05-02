namespace PeopleFlow.Formularios.Bonificaciones
{
    partial class FrmListadoBonificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoBonificacion));
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVBonificaciones = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVBonificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(631, 409);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 40;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVBonificaciones
            // 
            DGVBonificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVBonificaciones.Location = new Point(10, 64);
            DGVBonificaciones.Name = "DGVBonificaciones";
            DGVBonificaciones.ReadOnly = true;
            DGVBonificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVBonificaciones.Size = new Size(780, 339);
            DGVBonificaciones.TabIndex = 39;
            DGVBonificaciones.CellDoubleClick += DGVBonificaciones_CellDoubleClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(57, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(242, 30);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "Listado Bonificaciones";
            // 
            // FrmListadoBonificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(DGVBonificaciones);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListadoBonificacion";
            Text = "Listado de Bonificaciones";
            Load += FrmListadoBonificacion_Load;
            ((System.ComponentModel.ISupportInitialize)DGVBonificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVBonificaciones;
        private PictureBox pictureBox6;
        private Label lblTitulo;
    }
}