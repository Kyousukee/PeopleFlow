namespace PeopleFlow
{
    partial class PeopleFlow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleFlow));
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            cboEmpresas = new ComboBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 315);
            button1.Name = "button1";
            button1.Size = new Size(198, 23);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 165);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 223);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(68, 183);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(198, 23);
            txtuser.TabIndex = 3;
            txtuser.KeyPress += txtpass_KeyPress;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(68, 251);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(198, 23);
            txtpass.TabIndex = 4;
            txtpass.KeyPress += txtpass_KeyPress;
            // 
            // cboEmpresas
            // 
            cboEmpresas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresas.FormattingEnabled = true;
            cboEmpresas.Location = new Point(68, 280);
            cboEmpresas.Name = "cboEmpresas";
            cboEmpresas.Size = new Size(198, 23);
            cboEmpresas.TabIndex = 5;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(98, 315);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(128, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Iniciar Sesion";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(115, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // PeopleFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 490);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(materialButton1);
            Controls.Add(cboEmpresas);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PeopleFlow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                        Inicio Sesion";
            Load += PeopleFlow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
        protected ComboBox cboEmpresas;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
