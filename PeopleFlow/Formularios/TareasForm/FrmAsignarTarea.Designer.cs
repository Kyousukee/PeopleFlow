namespace PeopleFlow.Formularios.TareasForm
{
    partial class FrmAsignarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarTarea));
            DGVTrabajadores = new DataGridView();
            pictureBox6 = new PictureBox();
            lblTitulo = new Label();
            label1 = new Label();
            dtpFFin = new DateTimePicker();
            label2 = new Label();
            dttFAsignacion = new DateTimePicker();
            label7 = new Label();
            label3 = new Label();
            DGVAsignados = new DataGridView();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            chkFechaFin = new CheckBox();
            btnsalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DGVTrabajadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVAsignados).BeginInit();
            SuspendLayout();
            // 
            // DGVTrabajadores
            // 
            DGVTrabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTrabajadores.Location = new Point(8, 88);
            DGVTrabajadores.Name = "DGVTrabajadores";
            DGVTrabajadores.ReadOnly = true;
            DGVTrabajadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVTrabajadores.Size = new Size(344, 350);
            DGVTrabajadores.TabIndex = 40;
            DGVTrabajadores.CellClick += DGVTrabajadores_CellClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(8, 9);
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
            lblTitulo.Location = new Point(55, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 30);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Asignar Empleado a Tarea";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(8, 64);
            label1.Name = "label1";
            label1.Size = new Size(247, 19);
            label1.TabIndex = 43;
            label1.Text = "Seleccionar Empleado para Asignar";
            // 
            // dtpFFin
            // 
            dtpFFin.Enabled = false;
            dtpFFin.Format = DateTimePickerFormat.Short;
            dtpFFin.Location = new Point(358, 171);
            dtpFFin.Name = "dtpFFin";
            dtpFFin.Size = new Size(185, 23);
            dtpFFin.TabIndex = 47;
            dtpFFin.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(358, 151);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 46;
            label2.Text = "Fecha Finalizacion:";
            // 
            // dttFAsignacion
            // 
            dttFAsignacion.Enabled = false;
            dttFAsignacion.Format = DateTimePickerFormat.Short;
            dttFAsignacion.Location = new Point(358, 125);
            dttFAsignacion.Name = "dttFAsignacion";
            dttFAsignacion.Size = new Size(185, 23);
            dttFAsignacion.TabIndex = 45;
            dttFAsignacion.Value = new DateTime(2025, 3, 4, 14, 13, 6, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(358, 105);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 44;
            label7.Text = "Fecha Asignacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(583, 64);
            label3.Name = "label3";
            label3.Size = new Size(238, 19);
            label3.TabIndex = 49;
            label3.Text = "Seleccione Empleado ya Asignado";
            // 
            // DGVAsignados
            // 
            DGVAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAsignados.Location = new Point(549, 84);
            DGVAsignados.Name = "DGVAsignados";
            DGVAsignados.ReadOnly = true;
            DGVAsignados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAsignados.Size = new Size(337, 350);
            DGVAsignados.TabIndex = 48;
            DGVAsignados.CellClick += DGVAsignados_CellClick;
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(358, 285);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 32);
            btnIngresar.TabIndex = 50;
            btnIngresar.Text = "Agregar Asignacion";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Enabled = false;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            btnQuitar.IconColor = Color.Black;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 30;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(358, 332);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(185, 32);
            btnQuitar.TabIndex = 51;
            btnQuitar.Text = "Quitar Asignacion";
            btnQuitar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // chkFechaFin
            // 
            chkFechaFin.AutoSize = true;
            chkFechaFin.Enabled = false;
            chkFechaFin.Location = new Point(358, 200);
            chkFechaFin.Name = "chkFechaFin";
            chkFechaFin.Size = new Size(63, 19);
            chkFechaFin.TabIndex = 53;
            chkFechaFin.Text = "Aplicar";
            chkFechaFin.UseVisualStyleBackColor = true;
            chkFechaFin.CheckedChanged += chkFechaFin_CheckedChanged;
            // 
            // btnsalir
            // 
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 20;
            btnsalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsalir.Location = new Point(727, 440);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(159, 31);
            btnsalir.TabIndex = 54;
            btnsalir.Text = "Volver";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // FrmAsignarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 488);
            Controls.Add(btnsalir);
            Controls.Add(chkFechaFin);
            Controls.Add(btnQuitar);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(DGVAsignados);
            Controls.Add(dtpFFin);
            Controls.Add(label2);
            Controls.Add(dttFAsignacion);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(lblTitulo);
            Controls.Add(DGVTrabajadores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAsignarTarea";
            Text = "Asignacion de Tareas";
            Load += FrmAsignarTarea_Load;
            ((System.ComponentModel.ISupportInitialize)DGVTrabajadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVAsignados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVTrabajadores;
        private PictureBox pictureBox6;
        private Label lblTitulo;
        private Label label1;
        private DateTimePicker dtpFFin;
        private Label label2;
        private DateTimePicker dttFAsignacion;
        private Label label7;
        private Label label3;
        private DataGridView DGVAsignados;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private CheckBox chkFechaFin;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}