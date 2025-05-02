namespace PeopleFlow.Formularios
{
    partial class FrmDeducciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeducciones));
            btnListadoTrabajadores = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            button1 = new Button();
            listView1 = new ListView();
            label1 = new Label();
            cboEmpleados = new ComboBox();
            label9 = new Label();
            cboEstado = new ComboBox();
            label2 = new Label();
            dttFAsignacion = new DateTimePicker();
            txtvalor = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label3 = new Label();
            lblNombres = new Label();
            panelControles = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            txtID = new TextBox();
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
            btnListadoTrabajadores.Location = new Point(303, 8);
            btnListadoTrabajadores.Name = "btnListadoTrabajadores";
            btnListadoTrabajadores.Size = new Size(213, 31);
            btnListadoTrabajadores.TabIndex = 37;
            btnListadoTrabajadores.Text = "Listado de Deducciones";
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
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(116, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 30);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Tus Deducciones";
            // 
            // button1
            // 
            button1.Location = new Point(429, 248);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 83;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(119, 295);
            listView1.Name = "listView1";
            listView1.Size = new Size(304, 126);
            listView1.TabIndex = 82;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(119, 221);
            label1.Name = "label1";
            label1.Size = new Size(241, 15);
            label1.TabIndex = 81;
            label1.Text = "Asignacion Beneficio Especial Trabajadores";
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(223, 249);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(200, 23);
            cboEmpleados.TabIndex = 80;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(119, 250);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 79;
            label9.Text = "Trabajador:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(620, 164);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 23);
            cboEstado.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(546, 165);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 77;
            label2.Text = "Estado:";
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(620, 122);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(200, 23);
            dttFAsignacion.TabIndex = 76;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(223, 164);
            txtvalor.MaxLength = 9;
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(200, 23);
            txtvalor.TabIndex = 75;
            txtvalor.KeyPress += txtvalor_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(223, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(486, 126);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 73;
            label7.Text = "Fecha Asignacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(153, 170);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 72;
            label3.Text = "Valor:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9.75F);
            lblNombres.Location = new Point(134, 128);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(60, 17);
            lblNombres.TabIndex = 71;
            lblNombres.Text = "Nombre:";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnsalir);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(btnIngresar);
            panelControles.Location = new Point(462, 268);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(398, 153);
            panelControles.TabIndex = 70;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 20;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(9, 108);
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
            btnsalir.Location = new Point(204, 108);
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
            btnActualizar.Location = new Point(204, 12);
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
            btnIngresar.Location = new Point(13, 12);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 29;
            btnIngresar.Text = "Ingresar Deduccion";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(213, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 85;
            textBox1.Text = "10% del sueldo imponible + comisión de la AFP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(175, 74);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 84;
            label4.Text = "AFP:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(543, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(32, 23);
            textBox2.TabIndex = 87;
            textBox2.Text = "7%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(491, 75);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 86;
            label5.Text = "Fonasa:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(647, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(32, 23);
            textBox3.TabIndex = 89;
            textBox3.Text = "3%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(581, 75);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 88;
            label6.Text = "Cesantia:";
            // 
            // txtID
            // 
            txtID.Location = new Point(3, 424);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 90;
            txtID.Visible = false;
            // 
            // FrmDeducciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 452);
            Controls.Add(txtID);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
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
            Name = "FrmDeducciones";
            Text = "FrmDeducciones";
            Load += FrmDeducciones_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelControles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnListadoTrabajadores;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Button button1;
        private ListView listView1;
        private Label label1;
        private ComboBox cboEmpleados;
        private Label label9;
        private ComboBox cboEstado;
        private Label label2;
        private DateTimePicker dttFAsignacion;
        private TextBox txtvalor;
        private TextBox txtNombre;
        private Label label7;
        private Label label3;
        private Label lblNombres;
        private Panel panelControles;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox txtID;
    }
}