namespace PeopleFlow.Formularios
{
    partial class FrmLiquidaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiquidaciones));
            cboEmpleados = new ComboBox();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            pLiquidacion = new Panel();
            dttMeses = new DateTimePicker();
            txtsueldoliquido = new TextBox();
            label6 = new Label();
            txtdeducciones = new TextBox();
            label5 = new Label();
            txtbonos = new TextBox();
            txtsueldobase = new TextBox();
            label2 = new Label();
            label8 = new Label();
            txtcontrato = new TextBox();
            label11 = new Label();
            label10 = new Label();
            Liquidacion = new Label();
            panel1 = new Panel();
            btnArchivo = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnupdate = new FontAwesome.Sharp.IconButton();
            btningreso = new FontAwesome.Sharp.IconButton();
            txtperiodo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            dttYear = new DateTimePicker();
            label7 = new Label();
            txtID = new TextBox();
            btnListadoLiquidacion = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            txtdescdedu = new TextBox();
            txtdescbono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pLiquidacion.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(389, 65);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(479, 23);
            cboEmpleados.TabIndex = 47;
            cboEmpleados.SelectedValueChanged += cboEmpleados_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(69, 66);
            label9.Name = "label9";
            label9.Size = new Size(314, 17);
            label9.TabIndex = 46;
            label9.Text = "SELECCIONE TRABAJADOR CON CONTRATO ACTIVO";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 44;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(115, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(194, 30);
            lblTitulo.TabIndex = 43;
            lblTitulo.Text = "Tus Liquidaciones";
            // 
            // pLiquidacion
            // 
            pLiquidacion.Controls.Add(dttMeses);
            pLiquidacion.Controls.Add(txtsueldoliquido);
            pLiquidacion.Controls.Add(label6);
            pLiquidacion.Controls.Add(txtdeducciones);
            pLiquidacion.Controls.Add(label5);
            pLiquidacion.Controls.Add(txtbonos);
            pLiquidacion.Controls.Add(txtsueldobase);
            pLiquidacion.Controls.Add(label2);
            pLiquidacion.Controls.Add(label8);
            pLiquidacion.Controls.Add(txtcontrato);
            pLiquidacion.Controls.Add(label11);
            pLiquidacion.Controls.Add(label10);
            pLiquidacion.Controls.Add(Liquidacion);
            pLiquidacion.Controls.Add(panel1);
            pLiquidacion.Controls.Add(txtperiodo);
            pLiquidacion.Controls.Add(label3);
            pLiquidacion.Controls.Add(label4);
            pLiquidacion.Controls.Add(label1);
            pLiquidacion.Controls.Add(dttYear);
            pLiquidacion.Controls.Add(label7);
            pLiquidacion.Controls.Add(txtID);
            pLiquidacion.Enabled = false;
            pLiquidacion.Location = new Point(69, 94);
            pLiquidacion.Name = "pLiquidacion";
            pLiquidacion.Size = new Size(799, 283);
            pLiquidacion.TabIndex = 65;
            // 
            // dttMeses
            // 
            dttMeses.Format = DateTimePickerFormat.Short;
            dttMeses.Location = new Point(183, 78);
            dttMeses.Name = "dttMeses";
            dttMeses.Size = new Size(200, 23);
            dttMeses.TabIndex = 76;
            dttMeses.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // txtsueldoliquido
            // 
            txtsueldoliquido.Location = new Point(568, 218);
            txtsueldoliquido.Name = "txtsueldoliquido";
            txtsueldoliquido.ReadOnly = true;
            txtsueldoliquido.Size = new Size(200, 23);
            txtsueldoliquido.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(419, 218);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 74;
            label6.Text = "Sueldo Liquido:";
            // 
            // txtdeducciones
            // 
            txtdeducciones.Location = new Point(568, 186);
            txtdeducciones.Name = "txtdeducciones";
            txtdeducciones.ReadOnly = true;
            txtdeducciones.Size = new Size(200, 23);
            txtdeducciones.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(432, 187);
            label5.Name = "label5";
            label5.Size = new Size(85, 17);
            label5.TabIndex = 72;
            label5.Text = "Deducciones:";
            // 
            // txtbonos
            // 
            txtbonos.Location = new Point(568, 150);
            txtbonos.Name = "txtbonos";
            txtbonos.ReadOnly = true;
            txtbonos.Size = new Size(200, 23);
            txtbonos.TabIndex = 71;
            // 
            // txtsueldobase
            // 
            txtsueldobase.Location = new Point(568, 114);
            txtsueldobase.Name = "txtsueldobase";
            txtsueldobase.ReadOnly = true;
            txtsueldobase.Size = new Size(200, 23);
            txtsueldobase.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(568, 44);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 68;
            label2.Text = "N°";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(455, 44);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 67;
            label8.Text = "Contrato:";
            // 
            // txtcontrato
            // 
            txtcontrato.Location = new Point(597, 43);
            txtcontrato.MaxLength = 1;
            txtcontrato.Name = "txtcontrato";
            txtcontrato.ReadOnly = true;
            txtcontrato.Size = new Size(85, 23);
            txtcontrato.TabIndex = 66;
            txtcontrato.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(435, 115);
            label11.Name = "label11";
            label11.Size = new Size(82, 17);
            label11.TabIndex = 66;
            label11.Text = "Salario Base:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(183, 16);
            label10.Name = "label10";
            label10.Size = new Size(23, 17);
            label10.TabIndex = 65;
            label10.Text = "N°";
            // 
            // Liquidacion
            // 
            Liquidacion.AutoSize = true;
            Liquidacion.Font = new Font("Segoe UI", 9.75F);
            Liquidacion.Location = new Point(50, 16);
            Liquidacion.Name = "Liquidacion";
            Liquidacion.Size = new Size(77, 17);
            Liquidacion.TabIndex = 64;
            Liquidacion.Text = "Liquidacion:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnArchivo);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(btnupdate);
            panel1.Controls.Add(btningreso);
            panel1.Location = new Point(13, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 141);
            panel1.TabIndex = 63;
            // 
            // btnArchivo
            // 
            btnArchivo.Enabled = false;
            btnArchivo.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnArchivo.IconColor = Color.Black;
            btnArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArchivo.IconSize = 20;
            btnArchivo.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivo.Location = new Point(4, 55);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(375, 31);
            btnArchivo.TabIndex = 36;
            btnArchivo.Text = "Ver y Descargar Archivo";
            btnArchivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(4, 92);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(185, 32);
            iconButton2.TabIndex = 32;
            iconButton2.Text = "Limpiar";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // btnupdate
            // 
            btnupdate.Enabled = false;
            btnupdate.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnupdate.IconColor = Color.Black;
            btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnupdate.IconSize = 20;
            btnupdate.Location = new Point(195, 13);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(185, 32);
            btnupdate.TabIndex = 29;
            btnupdate.Text = "Actualizar Informacion";
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btningreso
            // 
            btningreso.IconChar = FontAwesome.Sharp.IconChar.Save;
            btningreso.IconColor = Color.Black;
            btningreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningreso.IconSize = 30;
            btningreso.ImageAlign = ContentAlignment.MiddleLeft;
            btningreso.Location = new Point(4, 13);
            btningreso.Name = "btningreso";
            btningreso.Size = new Size(185, 32);
            btningreso.TabIndex = 29;
            btningreso.Text = "Ingresar Liquidacion";
            btningreso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningreso.UseVisualStyleBackColor = true;
            btningreso.Click += iconButton4_Click;
            // 
            // txtperiodo
            // 
            txtperiodo.Location = new Point(568, 76);
            txtperiodo.Name = "txtperiodo";
            txtperiodo.ReadOnly = true;
            txtperiodo.Size = new Size(200, 23);
            txtperiodo.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(458, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 57;
            label3.Text = "Periodo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(437, 150);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 55;
            label4.Text = "Bonificacion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(91, 82);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 51;
            label1.Text = "Mes:";
            // 
            // dttYear
            // 
            dttYear.Format = DateTimePickerFormat.Short;
            dttYear.Location = new Point(183, 44);
            dttYear.Name = "dttYear";
            dttYear.Size = new Size(200, 23);
            dttYear.TabIndex = 50;
            dttYear.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(88, 48);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 49;
            label7.Text = "AÑO:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(216, 14);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.Size = new Size(85, 23);
            txtID.TabIndex = 48;
            txtID.Text = "0";
            // 
            // btnListadoLiquidacion
            // 
            btnListadoLiquidacion.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoLiquidacion.IconColor = Color.Black;
            btnListadoLiquidacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoLiquidacion.IconSize = 20;
            btnListadoLiquidacion.Location = new Point(315, 12);
            btnListadoLiquidacion.Name = "btnListadoLiquidacion";
            btnListadoLiquidacion.Size = new Size(195, 31);
            btnListadoLiquidacion.TabIndex = 35;
            btnListadoLiquidacion.Text = "Listado de Liquidacion";
            btnListadoLiquidacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoLiquidacion.UseVisualStyleBackColor = true;
            btnListadoLiquidacion.Click += btnListadoLiquidacion_Click;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(709, 383);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 66;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // txtdescdedu
            // 
            txtdescdedu.Location = new Point(69, 417);
            txtdescdedu.MaxLength = 1;
            txtdescdedu.Name = "txtdescdedu";
            txtdescdedu.Size = new Size(45, 23);
            txtdescdedu.TabIndex = 67;
            txtdescdedu.Visible = false;
            // 
            // txtdescbono
            // 
            txtdescbono.Location = new Point(12, 417);
            txtdescbono.MaxLength = 1;
            txtdescbono.Name = "txtdescbono";
            txtdescbono.Size = new Size(45, 23);
            txtdescbono.TabIndex = 68;
            txtdescbono.Visible = false;
            // 
            // FrmLiquidaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 452);
            Controls.Add(txtdescbono);
            Controls.Add(btnListadoLiquidacion);
            Controls.Add(txtdescdedu);
            Controls.Add(btnsalir);
            Controls.Add(pLiquidacion);
            Controls.Add(cboEmpleados);
            Controls.Add(label9);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLiquidaciones";
            Text = "FrmLiquidaciones";
            Load += FrmLiquidaciones_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pLiquidacion.ResumeLayout(false);
            pLiquidacion.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEmpleados;
        private Label label9;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Panel pLiquidacion;
        private Label label11;
        private Label label10;
        private Label Liquidacion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnupdate;
        private FontAwesome.Sharp.IconButton btningreso;
        private TextBox txtperiodo;
        private Label label3;
        private Label label4;
        private Label label1;
        private DateTimePicker dttYear;
        private Label label7;
        private TextBox txtID;
        private FontAwesome.Sharp.IconButton btnListadoLiquidacion;
        private TextBox txtbonos;
        private TextBox txtsueldobase;
        private Label label2;
        private Label label8;
        private TextBox txtcontrato;
        private TextBox txtdeducciones;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnsalir;
        private TextBox txtsueldoliquido;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnArchivo;
        private DateTimePicker dttMeses;
        private TextBox txtdescdedu;
        private TextBox txtdescbono;
    }
}