namespace PeopleFlow.Formularios.Dashboard
{
    partial class FrmVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacaciones));
            btnListadoLiquidacion = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            pLiquidacion = new Panel();
            label4 = new Label();
            txtsaldo = new TextBox();
            label3 = new Label();
            txtdias = new TextBox();
            dttRetorno = new DateTimePicker();
            label2 = new Label();
            dttTermino = new DateTimePicker();
            label10 = new Label();
            Liquidacion = new Label();
            panel1 = new Panel();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnArchivo = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btningreso = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dttInicio = new DateTimePicker();
            label7 = new Label();
            txtID = new TextBox();
            btnupdate = new FontAwesome.Sharp.IconButton();
            cboEmpleados = new ComboBox();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            pLiquidacion.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnListadoLiquidacion
            // 
            btnListadoLiquidacion.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnListadoLiquidacion.IconColor = Color.Black;
            btnListadoLiquidacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoLiquidacion.IconSize = 20;
            btnListadoLiquidacion.Location = new Point(179, 27);
            btnListadoLiquidacion.Name = "btnListadoLiquidacion";
            btnListadoLiquidacion.Size = new Size(159, 31);
            btnListadoLiquidacion.TabIndex = 67;
            btnListadoLiquidacion.Text = "Listado de Vacaciones";
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
            btnsalir.Location = new Point(641, 347);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 73;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // pLiquidacion
            // 
            pLiquidacion.Controls.Add(label4);
            pLiquidacion.Controls.Add(txtsaldo);
            pLiquidacion.Controls.Add(label3);
            pLiquidacion.Controls.Add(txtdias);
            pLiquidacion.Controls.Add(dttRetorno);
            pLiquidacion.Controls.Add(label2);
            pLiquidacion.Controls.Add(dttTermino);
            pLiquidacion.Controls.Add(label10);
            pLiquidacion.Controls.Add(Liquidacion);
            pLiquidacion.Controls.Add(panel1);
            pLiquidacion.Controls.Add(label1);
            pLiquidacion.Controls.Add(dttInicio);
            pLiquidacion.Controls.Add(label7);
            pLiquidacion.Controls.Add(txtID);
            pLiquidacion.Enabled = false;
            pLiquidacion.Location = new Point(1, 108);
            pLiquidacion.Name = "pLiquidacion";
            pLiquidacion.Size = new Size(799, 233);
            pLiquidacion.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(84, 194);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 82;
            label4.Text = "Saldo:";
            // 
            // txtsaldo
            // 
            txtsaldo.Enabled = false;
            txtsaldo.Location = new Point(183, 193);
            txtsaldo.MaxLength = 1;
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(85, 23);
            txtsaldo.TabIndex = 81;
            txtsaldo.KeyPress += txtsaldo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(92, 156);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 80;
            label3.Text = "Dias:";
            // 
            // txtdias
            // 
            txtdias.Location = new Point(183, 155);
            txtdias.MaxLength = 1;
            txtdias.Name = "txtdias";
            txtdias.ReadOnly = true;
            txtdias.Size = new Size(85, 23);
            txtdias.TabIndex = 79;
            txtdias.KeyPress += txtdias_KeyPress;
            // 
            // dttRetorno
            // 
            dttRetorno.Enabled = false;
            dttRetorno.Format = DateTimePickerFormat.Short;
            dttRetorno.Location = new Point(183, 117);
            dttRetorno.Name = "dttRetorno";
            dttRetorno.Size = new Size(200, 23);
            dttRetorno.TabIndex = 78;
            dttRetorno.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(33, 121);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 77;
            label2.Text = "Fecha Retorno:";
            // 
            // dttTermino
            // 
            dttTermino.Format = DateTimePickerFormat.Short;
            dttTermino.Location = new Point(183, 78);
            dttTermino.Name = "dttTermino";
            dttTermino.Size = new Size(200, 23);
            dttTermino.TabIndex = 76;
            dttTermino.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            dttTermino.ValueChanged += dttTermino_ValueChanged;
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
            Liquidacion.Location = new Point(66, 16);
            Liquidacion.Name = "Liquidacion";
            Liquidacion.Size = new Size(62, 17);
            Liquidacion.TabIndex = 64;
            Liquidacion.Text = "Vacacion:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnArchivo);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(btningreso);
            panel1.Location = new Point(400, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 140);
            panel1.TabIndex = 63;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(188, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(185, 32);
            btnEliminar.TabIndex = 67;
            btnEliminar.Text = "Eliminar Vacaciones";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.Enabled = false;
            btnArchivo.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnArchivo.IconColor = Color.Black;
            btnArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArchivo.IconSize = 20;
            btnArchivo.ImageAlign = ContentAlignment.MiddleRight;
            btnArchivo.Location = new Point(3, 55);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(370, 31);
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
            iconButton2.Location = new Point(3, 92);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(185, 32);
            iconButton2.TabIndex = 32;
            iconButton2.Text = "Limpiar";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // btningreso
            // 
            btningreso.IconChar = FontAwesome.Sharp.IconChar.Save;
            btningreso.IconColor = Color.Black;
            btningreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningreso.IconSize = 30;
            btningreso.ImageAlign = ContentAlignment.MiddleLeft;
            btningreso.Location = new Point(3, 12);
            btningreso.Name = "btningreso";
            btningreso.Size = new Size(185, 32);
            btningreso.TabIndex = 29;
            btningreso.Text = "Ingresar Vacaciones";
            btningreso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningreso.UseVisualStyleBackColor = true;
            btningreso.Click += btningreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(33, 82);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 51;
            label1.Text = "Fecha Termino:";
            // 
            // dttInicio
            // 
            dttInicio.Format = DateTimePickerFormat.Short;
            dttInicio.Location = new Point(183, 44);
            dttInicio.Name = "dttInicio";
            dttInicio.Size = new Size(200, 23);
            dttInicio.TabIndex = 50;
            dttInicio.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            dttInicio.ValueChanged += dttTermino_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(50, 44);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 49;
            label7.Text = "Fecha Inicio:";
            // 
            // txtID
            // 
            txtID.Location = new Point(216, 14);
            txtID.MaxLength = 1;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(85, 23);
            txtID.TabIndex = 48;
            txtID.Text = "0";
            // 
            // btnupdate
            // 
            btnupdate.Enabled = false;
            btnupdate.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnupdate.IconColor = Color.Black;
            btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnupdate.IconSize = 20;
            btnupdate.Location = new Point(476, 347);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(159, 32);
            btnupdate.TabIndex = 29;
            btnupdate.Text = "Actualizar Informacion";
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Visible = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // cboEmpleados
            // 
            cboEmpleados.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEmpleados.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(321, 79);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(479, 23);
            cboEmpleados.TabIndex = 71;
            cboEmpleados.SelectedValueChanged += cboEmpleados_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(1, 80);
            label9.Name = "label9";
            label9.Size = new Size(314, 17);
            label9.TabIndex = 70;
            label9.Text = "SELECCIONE TRABAJADOR CON CONTRATO ACTIVO";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1, 23);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 69;
            pictureBox6.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(47, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 30);
            lblTitulo.TabIndex = 68;
            lblTitulo.Text = "Vacaciones";
            // 
            // FrmVacaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 387);
            Controls.Add(btnListadoLiquidacion);
            Controls.Add(btnsalir);
            Controls.Add(btnupdate);
            Controls.Add(pLiquidacion);
            Controls.Add(cboEmpleados);
            Controls.Add(label9);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVacaciones";
            Text = "Registro de Vacaciones";
            Load += FrmVacaciones_Load;
            pLiquidacion.ResumeLayout(false);
            pLiquidacion.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnListadoLiquidacion;
        private FontAwesome.Sharp.IconButton btnsalir;
        private Panel pLiquidacion;
        private DateTimePicker dttTermino;
        private Label label10;
        private Label Liquidacion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnArchivo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnupdate;
        private FontAwesome.Sharp.IconButton btningreso;
        private Label label1;
        private DateTimePicker dttInicio;
        private Label label7;
        private TextBox txtID;
        private ComboBox cboEmpleados;
        private Label label9;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private DateTimePicker dttRetorno;
        private Label label2;
        private Label label3;
        private TextBox txtdias;
        private Label label4;
        private TextBox txtsaldo;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}