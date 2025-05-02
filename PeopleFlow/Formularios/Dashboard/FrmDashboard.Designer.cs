namespace PeopleFlow.Formularios
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            DGVTareas = new DataGridView();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnArchivo = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            totHoy = new Label();
            totIng = new Label();
            label6 = new Label();
            label5 = new Label();
            TotalTrabajadores = new Label();
            trabajadoresActivos = new Label();
            label7 = new Label();
            totalTareas = new Label();
            tareasActivas = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(38, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(300, 355);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(38, 91);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 2;
            label1.Text = "Visor Estado de Contratos";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(DGVTareas);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(btnArchivo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(totHoy);
            panel1.Controls.Add(totIng);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TotalTrabajadores);
            panel1.Controls.Add(trabajadoresActivos);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(totalTareas);
            panel1.Controls.Add(tareasActivas);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(386, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 355);
            panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(440, 125);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // DGVTareas
            // 
            DGVTareas.AllowUserToAddRows = false;
            DGVTareas.AllowUserToDeleteRows = false;
            DGVTareas.AllowUserToOrderColumns = true;
            DGVTareas.AllowUserToResizeColumns = false;
            DGVTareas.AllowUserToResizeRows = false;
            DGVTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGVTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTareas.ColumnHeadersVisible = false;
            DGVTareas.EnableHeadersVisualStyles = false;
            DGVTareas.Location = new Point(56, 169);
            DGVTareas.Name = "DGVTareas";
            DGVTareas.ReadOnly = true;
            DGVTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVTareas.Size = new Size(378, 88);
            DGVTareas.TabIndex = 45;
            DGVTareas.CellClick += DGVTareas_CellClick;
            DGVTareas.CellMouseEnter += DGVTareas_CellMouseEnter;
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightToFile;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 20;
            btnIngresar.ImageAlign = ContentAlignment.MiddleRight;
            btnIngresar.Location = new Point(18, 274);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(470, 31);
            btnIngresar.TabIndex = 35;
            btnIngresar.Text = "Registro Actividades de Trabajador";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnArchivo.IconColor = Color.Black;
            btnArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArchivo.IconSize = 20;
            btnArchivo.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivo.Location = new Point(18, 311);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(470, 31);
            btnArchivo.TabIndex = 34;
            btnArchivo.Text = "Listado General de Actividades";
            btnArchivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(404, 127);
            label8.Name = "label8";
            label8.Size = new Size(16, 21);
            label8.TabIndex = 44;
            label8.Text = "/";
            // 
            // totHoy
            // 
            totHoy.AutoSize = true;
            totHoy.Font = new Font("Segoe UI", 12F);
            totHoy.Location = new Point(415, 127);
            totHoy.Name = "totHoy";
            totHoy.Size = new Size(19, 21);
            totHoy.TabIndex = 43;
            totHoy.Text = "0";
            // 
            // totIng
            // 
            totIng.AutoSize = true;
            totIng.Font = new Font("Segoe UI", 12F);
            totIng.Location = new Point(390, 127);
            totIng.Name = "totIng";
            totIng.Size = new Size(19, 21);
            totIng.TabIndex = 42;
            totIng.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(96, 127);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 41;
            label6.Text = "Actividades Hoy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(404, 61);
            label5.Name = "label5";
            label5.Size = new Size(16, 21);
            label5.TabIndex = 40;
            label5.Text = "/";
            // 
            // TotalTrabajadores
            // 
            TotalTrabajadores.AutoSize = true;
            TotalTrabajadores.Font = new Font("Segoe UI", 12F);
            TotalTrabajadores.Location = new Point(415, 61);
            TotalTrabajadores.Name = "TotalTrabajadores";
            TotalTrabajadores.Size = new Size(19, 21);
            TotalTrabajadores.TabIndex = 39;
            TotalTrabajadores.Text = "0";
            // 
            // trabajadoresActivos
            // 
            trabajadoresActivos.AutoSize = true;
            trabajadoresActivos.Font = new Font("Segoe UI", 12F);
            trabajadoresActivos.Location = new Point(390, 61);
            trabajadoresActivos.Name = "trabajadoresActivos";
            trabajadoresActivos.Size = new Size(19, 21);
            trabajadoresActivos.TabIndex = 38;
            trabajadoresActivos.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(404, 34);
            label7.Name = "label7";
            label7.Size = new Size(16, 21);
            label7.TabIndex = 37;
            label7.Text = "/";
            // 
            // totalTareas
            // 
            totalTareas.AutoSize = true;
            totalTareas.Font = new Font("Segoe UI", 12F);
            totalTareas.Location = new Point(415, 34);
            totalTareas.Name = "totalTareas";
            totalTareas.Size = new Size(19, 21);
            totalTareas.TabIndex = 36;
            totalTareas.Text = "0";
            // 
            // tareasActivas
            // 
            tareasActivas.AutoSize = true;
            tareasActivas.Font = new Font("Segoe UI", 12F);
            tareasActivas.Location = new Point(390, 34);
            tareasActivas.Name = "tareasActivas";
            tareasActivas.Size = new Size(19, 21);
            tareasActivas.TabIndex = 35;
            tareasActivas.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(96, 61);
            label4.Name = "label4";
            label4.Size = new Size(170, 21);
            label4.TabIndex = 12;
            label4.Text = "Trabajadores Activados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(96, 34);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 11;
            label3.Text = "Tareas Activas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(386, 91);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 4;
            label2.Text = "Monitoreo de Actividades";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(112, 23);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(38, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(92, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 30);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Monitoreo de Actividades";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(944, 519);
            Controls.Add(pictureBox5);
            Controls.Add(lblTitulo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label8;
        private Label totHoy;
        private Label totIng;
        private Label label6;
        private Label label5;
        private Label TotalTrabajadores;
        private Label trabajadoresActivos;
        private Label label7;
        private Label totalTareas;
        private Label tareasActivas;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btnArchivo;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private DataGridView DGVTareas;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblTitulo;
    }
}