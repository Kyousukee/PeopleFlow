namespace PeopleFlow.Formularios.Trabajdores
{
    partial class FrmLiquidacionesTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiquidacionesTrabajador));
            btnsalir = new FontAwesome.Sharp.IconButton();
            DGVLiquidacion = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVLiquidacion).BeginInit();
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
            btnsalir.TabIndex = 36;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // DGVLiquidacion
            // 
            DGVLiquidacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLiquidacion.Location = new Point(10, 64);
            DGVLiquidacion.Name = "DGVLiquidacion";
            DGVLiquidacion.ReadOnly = true;
            DGVLiquidacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVLiquidacion.Size = new Size(780, 339);
            DGVLiquidacion.TabIndex = 35;
            DGVLiquidacion.CellDoubleClick += DGVLiquidacion_CellDoubleClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(57, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 30);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "Liquidaciones Trabajadores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 409);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 37;
            label1.Text = "Doble click encima de un registro para generar!!";
            // 
            // FrmLiquidacionesTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnsalir);
            Controls.Add(DGVLiquidacion);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLiquidacionesTrabajador";
            Text = "Liquidaciones Trabajador";
            Load += FrmLiquidacionesTrabajador_Load;
            ((System.ComponentModel.ISupportInitialize)DGVLiquidacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private DataGridView DGVLiquidacion;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Label label1;
    }
}