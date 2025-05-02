namespace PeopleFlow.Formularios.Trabajdores
{
    partial class FrmAsignacionFamiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionFamiliar));
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            numerichijos = new NumericUpDown();
            numericConyuge = new NumericUpDown();
            numericInvalidez = new NumericUpDown();
            lblNombres = new Label();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerichijos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericConyuge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericInvalidez).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(230, 179);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(107, 31);
            btnsalir.TabIndex = 58;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(12, 179);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 32);
            btnIngresar.TabIndex = 57;
            btnIngresar.Text = "Guardar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 56;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(59, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(278, 30);
            lblTitulo.TabIndex = 55;
            lblTitulo.Text = "Asignar de Carga Familiar";
            // 
            // numerichijos
            // 
            numerichijos.Location = new Point(217, 66);
            numerichijos.Name = "numerichijos";
            numerichijos.Size = new Size(120, 23);
            numerichijos.TabIndex = 59;
            // 
            // numericConyuge
            // 
            numericConyuge.Location = new Point(217, 95);
            numericConyuge.Name = "numericConyuge";
            numericConyuge.Size = new Size(120, 23);
            numericConyuge.TabIndex = 60;
            // 
            // numericInvalidez
            // 
            numericInvalidez.Location = new Point(217, 124);
            numericInvalidez.Name = "numericInvalidez";
            numericInvalidez.Size = new Size(120, 23);
            numericInvalidez.TabIndex = 61;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(12, 66);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(40, 17);
            lblNombres.TabIndex = 62;
            lblNombres.Text = "Hijos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 63;
            label1.Text = "Conyuge:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 64;
            label2.Text = "Invalidez:";
            // 
            // txtID
            // 
            txtID.Location = new Point(292, 150);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 65;
            txtID.Text = "0";
            txtID.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(129, 180);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(90, 31);
            iconButton1.TabIndex = 66;
            iconButton1.Text = "Quitar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // FrmAsignacionFamiliar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 232);
            Controls.Add(iconButton1);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombres);
            Controls.Add(numericInvalidez);
            Controls.Add(numericConyuge);
            Controls.Add(numerichijos);
            Controls.Add(btnsalir);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAsignacionFamiliar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignacion de Carga Familiar";
            Load += FrmAsignacionFamiliar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerichijos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericConyuge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericInvalidez).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private NumericUpDown numerichijos;
        private NumericUpDown numericConyuge;
        private NumericUpDown numericInvalidez;
        private Label lblNombres;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}