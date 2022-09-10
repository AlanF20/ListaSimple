namespace ListaSimple19100179
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.dtgDeportistasOlimpicos = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.grpDeportista = new System.Windows.Forms.GroupBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.grpPresea = new System.Windows.Forms.GroupBox();
            this.radBronce = new System.Windows.Forms.RadioButton();
            this.radPlata = new System.Windows.Forms.RadioButton();
            this.radOro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeportistasOlimpicos)).BeginInit();
            this.grpDeportista.SuspendLayout();
            this.grpPresea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(683, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 37);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(138, 172);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(97, 17);
            this.chkActivo.TabIndex = 1;
            this.chkActivo.Text = "¿Sigue activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Ajedrez",
            "Animación",
            "Automovilismo",
            "Baile deportivo",
            "Billar",
            "Bridge",
            "Deportes de bolas",
            "Deportes subacuáticos",
            "Esquí acuático",
            "Esquí de travesía",
            "Floorball",
            "Fútbol americano",
            "Levantamiento de potencia",
            "Motociclismo",
            "Motonáutica ",
            "Muay Thai",
            "Patinaje",
            "Futbol",
            "Baseball"});
            this.cboCategoria.Location = new System.Drawing.Point(138, 136);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 2;
            // 
            // dtgDeportistasOlimpicos
            // 
            this.dtgDeportistasOlimpicos.AllowUserToAddRows = false;
            this.dtgDeportistasOlimpicos.AllowUserToDeleteRows = false;
            this.dtgDeportistasOlimpicos.AllowUserToResizeColumns = false;
            this.dtgDeportistasOlimpicos.AllowUserToResizeRows = false;
            this.dtgDeportistasOlimpicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeportistasOlimpicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.nombre,
            this.fecha,
            this.dinero,
            this.categoria,
            this.activo,
            this.presea,
            this.imagen});
            this.dtgDeportistasOlimpicos.Location = new System.Drawing.Point(12, 277);
            this.dtgDeportistasOlimpicos.MultiSelect = false;
            this.dtgDeportistasOlimpicos.Name = "dtgDeportistasOlimpicos";
            this.dtgDeportistasOlimpicos.ReadOnly = true;
            this.dtgDeportistasOlimpicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgDeportistasOlimpicos.Size = new System.Drawing.Size(776, 261);
            this.dtgDeportistasOlimpicos.TabIndex = 3;
            this.dtgDeportistasOlimpicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDeportistasOlimpicos_CellClick);
            this.dtgDeportistasOlimpicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDeportistasOlimpicos_CellContentClick);
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre:";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de nacimiento";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // dinero
            // 
            this.dinero.HeaderText = "Dinero generado";
            this.dinero.Name = "dinero";
            this.dinero.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.HeaderText = "¿Sigue activo?";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // presea
            // 
            this.presea.HeaderText = "Presea obtenida";
            this.presea.Name = "presea";
            this.presea.ReadOnly = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(138, 82);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // grpDeportista
            // 
            this.grpDeportista.Controls.Add(this.btnImagen);
            this.grpDeportista.Controls.Add(this.grpPresea);
            this.grpDeportista.Controls.Add(this.label5);
            this.grpDeportista.Controls.Add(this.label4);
            this.grpDeportista.Controls.Add(this.label3);
            this.grpDeportista.Controls.Add(this.txtNombre);
            this.grpDeportista.Controls.Add(this.label2);
            this.grpDeportista.Controls.Add(this.txtClave);
            this.grpDeportista.Controls.Add(this.picImagen);
            this.grpDeportista.Controls.Add(this.label1);
            this.grpDeportista.Controls.Add(this.dtpFechaNacimiento);
            this.grpDeportista.Controls.Add(this.chkActivo);
            this.grpDeportista.Controls.Add(this.txtDinero);
            this.grpDeportista.Controls.Add(this.cboCategoria);
            this.grpDeportista.Location = new System.Drawing.Point(12, 12);
            this.grpDeportista.Name = "grpDeportista";
            this.grpDeportista.Size = new System.Drawing.Size(645, 259);
            this.grpDeportista.TabIndex = 5;
            this.grpDeportista.TabStop = false;
            this.grpDeportista.Text = "Datos del deportista";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(471, 161);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(149, 28);
            this.btnImagen.TabIndex = 7;
            this.btnImagen.Text = "Cargar foto";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // grpPresea
            // 
            this.grpPresea.Controls.Add(this.radBronce);
            this.grpPresea.Controls.Add(this.radPlata);
            this.grpPresea.Controls.Add(this.radOro);
            this.grpPresea.Location = new System.Drawing.Point(35, 195);
            this.grpPresea.Name = "grpPresea";
            this.grpPresea.Size = new System.Drawing.Size(303, 45);
            this.grpPresea.TabIndex = 11;
            this.grpPresea.TabStop = false;
            this.grpPresea.Text = "Presea obtenida";
            // 
            // radBronce
            // 
            this.radBronce.AutoSize = true;
            this.radBronce.Location = new System.Drawing.Point(207, 19);
            this.radBronce.Name = "radBronce";
            this.radBronce.Size = new System.Drawing.Size(59, 17);
            this.radBronce.TabIndex = 2;
            this.radBronce.TabStop = true;
            this.radBronce.Text = "Bronce";
            this.radBronce.UseVisualStyleBackColor = true;
            // 
            // radPlata
            // 
            this.radPlata.AutoSize = true;
            this.radPlata.Location = new System.Drawing.Point(116, 19);
            this.radPlata.Name = "radPlata";
            this.radPlata.Size = new System.Drawing.Size(49, 17);
            this.radPlata.TabIndex = 1;
            this.radPlata.TabStop = true;
            this.radPlata.Text = "Plata";
            this.radPlata.UseVisualStyleBackColor = true;
            // 
            // radOro
            // 
            this.radOro.AutoSize = true;
            this.radOro.Location = new System.Drawing.Point(23, 19);
            this.radOro.Name = "radOro";
            this.radOro.Size = new System.Drawing.Size(42, 17);
            this.radOro.TabIndex = 0;
            this.radOro.TabStop = true;
            this.radOro.Text = "Oro";
            this.radOro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dinero generado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(138, 27);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(51, 20);
            this.txtClave.TabIndex = 5;
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(471, 19);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(149, 134);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 1;
            this.picImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(138, 108);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(100, 20);
            this.txtDinero.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(683, 18);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 37);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar datos aleatorios";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(683, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 37);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(683, 226);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(105, 37);
            this.btnVaciar.TabIndex = 8;
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Imagen";
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grpDeportista);
            this.Controls.Add(this.dtgDeportistasOlimpicos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Deportistas olimpicos famosos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeportistasOlimpicos)).EndInit();
            this.grpDeportista.ResumeLayout(false);
            this.grpDeportista.PerformLayout();
            this.grpPresea.ResumeLayout(false);
            this.grpPresea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DataGridView dtgDeportistasOlimpicos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox grpDeportista;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.GroupBox grpPresea;
        private System.Windows.Forms.RadioButton radBronce;
        private System.Windows.Forms.RadioButton radPlata;
        private System.Windows.Forms.RadioButton radOro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn presea;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
    }
}

