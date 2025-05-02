namespace PeopleFlow.Formularios
{
    partial class FrmBonificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBonificaciones));
            btnListadoTrabajadores = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            panelControles = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            cboEstado = new ComboBox();
            label2 = new Label();
            dttFAsignacion = new DateTimePicker();
            txtvalor = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label3 = new Label();
            lblNombres = new Label();
            cboEmpleados = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            txtID = new TextBox();
            cboTareas = new ComboBox();
            label11 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelControles.SuspendLayout();
            SuspendLayout();
            // 
            // btnListadoTrabajadores
            // 
            btnListadoTrabajadores.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoTrabajadores.IconColor = Color.Black;
            btnListadoTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoTrabajadores.IconSize = 20;
            btnListadoTrabajadores.Location = new Point(323, 9);
            btnListadoTrabajadores.Name = "btnListadoTrabajadores";
            btnListadoTrabajadores.Size = new Size(213, 31);
            btnListadoTrabajadores.TabIndex = 34;
            btnListadoTrabajadores.Text = "Listado de bonificaciones";
            btnListadoTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoTrabajadores.UseVisualStyleBackColor = true;
            btnListadoTrabajadores.Click += btnListadoTrabajadores_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(116, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 30);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Tus Bonificaciones";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(491, 260);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(380, 153);
            panelControles.TabIndex = 35;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(3, 108);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(185, 32);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(190, 108);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(185, 32);
            btnsalir.TabIndex = 31;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnActualizar.IconColor = Color.Black;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.IconSize = 20;
            btnActualizar.Location = new Point(190, 13);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(185, 32);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar Informacion";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(3, 13);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 29;
            btnIngresar.Text = "Ingresar Tarea";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(635, 129);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 23);
            cboEstado.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(561, 130);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 53;
            label2.Text = "Estado:";
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(635, 87);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(200, 23);
            dttFAsignacion.TabIndex = 50;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(238, 129);
            txtvalor.MaxLength = 9;
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(200, 23);
            txtvalor.TabIndex = 49;
            txtvalor.KeyPress += txtvalor_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(501, 91);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 47;
            label7.Text = "Fecha Asignacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(168, 135);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 46;
            label3.Text = "Valor:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(149, 93);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(60, 17);
            lblNombres.TabIndex = 45;
            lblNombres.Text = "Nombre:";
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(238, 241);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(200, 23);
            cboEmpleados.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(134, 242);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 55;
            label9.Text = "Trabajador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(134, 213);
            label1.Name = "label1";
            label1.Size = new Size(241, 15);
            label1.TabIndex = 57;
            label1.Text = "Asignacion Beneficio Especial Trabajadores";
            // 
            // listView1
            // 
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(134, 287);
            listView1.Name = "listView1";
            listView1.Size = new Size(304, 126);
            listView1.TabIndex = 58;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(444, 240);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 59;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(81, 413);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 60;
            txtID.Visible = false;
            // 
            // cboTareas
            // 
            cboTareas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTareas.FormattingEnabled = true;
            cboTareas.Location = new Point(238, 167);
            cboTareas.Name = "cboTareas";
            cboTareas.Size = new Size(200, 23);
            cboTareas.TabIndex = 69;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(101, 168);
            label11.Name = "label11";
            label11.Size = new Size(108, 17);
            label11.TabIndex = 68;
            label11.Text = "Tarea Referencia:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(444, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 19);
            checkBox1.TabIndex = 70;
            checkBox1.Text = "Imponible";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmBonificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 452);
            Controls.Add(checkBox1);
            Controls.Add(cboTareas);
            Controls.Add(label11);
            Controls.Add(txtID);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(cboEmpleados);
            Controls.Add(label9);
            Controls.Add(cboEstado);
            Controls.Add(label2);
            Controls.Add(dttFAsignacion);
            Controls.Add(txtvalor);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(lblNombres);
            Controls.Add(panelControles);
            Controls.Add(btnListadoTrabajadores);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBonificaciones";
            Text = "FrmBonificaciones";
            Load += FrmBonificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelControles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnListadoTrabajadores;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private ComboBox cboEstado;
        private Label label2;
        private DateTimePicker dttFAsignacion;
        private TextBox txtvalor;
        private TextBox txtNombre;
        private Label label7;
        private Label label3;
        private Label lblNombres;
        private ComboBox cboEmpleados;
        private Label label9;
        private Label label1;
        private ListView listView1;
        private Button button1;
        private TextBox txtID;
        private ComboBox cboTareas;
        private Label label11;
        private CheckBox checkBox1;
    }
}