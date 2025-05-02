namespace PeopleFlow.Formularios.Deducciones
{
    partial class FrmListadoDeduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeduccion));
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVDeducciones = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVDeducciones).BeginInit();
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
            btnsalir.TabIndex = 44;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVDeducciones
            // 
            DGVDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDeducciones.Location = new Point(10, 64);
            DGVDeducciones.Name = "DGVDeducciones";
            DGVDeducciones.ReadOnly = true;
            DGVDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVDeducciones.Size = new Size(780, 339);
            DGVDeducciones.TabIndex = 43;
            DGVDeducciones.CellDoubleClick += DGVDeducciones_CellDoubleClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(57, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 30);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Listado Deducciones";
            // 
            // FrmListadoDeduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(DGVDeducciones);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListadoDeduccion";
            Text = "FrmListadoDeduccion";
            Load += FrmListadoDeduccion_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDeducciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVDeducciones;
        private PictureBox pictureBox6;
        private Label lblTitulo;
    }
}