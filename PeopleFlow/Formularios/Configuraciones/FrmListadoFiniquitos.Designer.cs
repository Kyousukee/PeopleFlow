namespace PeopleFlow.Formularios.Configuraciones
{
    partial class FrmListadoFiniquitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoFiniquitos));
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVFiniquitos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVFiniquitos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 30);
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
            lblTitulo.Location = new Point(116, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(195, 30);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "Listado Finiquitos";
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(735, 363);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 39;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVFiniquitos
            // 
            DGVFiniquitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFiniquitos.Location = new Point(42, 77);
            DGVFiniquitos.Name = "DGVFiniquitos";
            DGVFiniquitos.ReadOnly = true;
            DGVFiniquitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVFiniquitos.Size = new Size(852, 280);
            DGVFiniquitos.TabIndex = 38;
            DGVFiniquitos.CellDoubleClick += DGVFiniquitos_CellDoubleClick;
            // 
            // FrmListadoFiniquitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 413);
            Controls.Add(btnsalir);
            Controls.Add(DGVFiniquitos);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListadoFiniquitos";
            Text = "Listado Finiquitos";
            Load += FrmListadoFiniquitos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVFiniquitos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVFiniquitos;
    }
}