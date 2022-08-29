
namespace padel_app_21
{
    partial class FormTorneos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.labelTorneos = new System.Windows.Forms.Label();
            this.DtgvTorneos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxParejas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnuncio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTorneos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 796);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(203, 39);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(221, 796);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(203, 39);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(430, 796);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(203, 39);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // labelTorneos
            // 
            this.labelTorneos.AutoSize = true;
            this.labelTorneos.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTorneos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTorneos.Location = new System.Drawing.Point(12, 15);
            this.labelTorneos.Name = "labelTorneos";
            this.labelTorneos.Size = new System.Drawing.Size(230, 59);
            this.labelTorneos.TabIndex = 12;
            this.labelTorneos.Text = "TORNEOS";
            // 
            // DtgvTorneos
            // 
            this.DtgvTorneos.AllowUserToAddRows = false;
            this.DtgvTorneos.AllowUserToDeleteRows = false;
            this.DtgvTorneos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgvTorneos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvTorneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.puntos,
            this.fechaInicio,
            this.Inscripcion,
            this.premio,
            this.Categorias,
            this.maxParejas});
            this.DtgvTorneos.Location = new System.Drawing.Point(12, 94);
            this.DtgvTorneos.Name = "DtgvTorneos";
            this.DtgvTorneos.ReadOnly = true;
            this.DtgvTorneos.RowHeadersWidth = 51;
            this.DtgvTorneos.RowTemplate.Height = 29;
            this.DtgvTorneos.Size = new System.Drawing.Size(1232, 669);
            this.DtgvTorneos.TabIndex = 11;
            this.DtgvTorneos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvTorneos_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del torneo";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // puntos
            // 
            this.puntos.HeaderText = "Puntos";
            this.puntos.MinimumWidth = 6;
            this.puntos.Name = "puntos";
            this.puntos.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha de inicio";
            this.fechaInicio.MinimumWidth = 6;
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // Inscripcion
            // 
            this.Inscripcion.HeaderText = "Precio de Inscripción";
            this.Inscripcion.MinimumWidth = 6;
            this.Inscripcion.Name = "Inscripcion";
            this.Inscripcion.ReadOnly = true;
            // 
            // premio
            // 
            this.premio.HeaderText = "Premio";
            this.premio.MinimumWidth = 6;
            this.premio.Name = "premio";
            this.premio.ReadOnly = true;
            // 
            // Categorias
            // 
            this.Categorias.HeaderText = "Categorias";
            this.Categorias.MinimumWidth = 6;
            this.Categorias.Name = "Categorias";
            this.Categorias.ReadOnly = true;
            // 
            // maxParejas
            // 
            this.maxParejas.HeaderText = "Maximo de Parejas";
            this.maxParejas.MinimumWidth = 6;
            this.maxParejas.Name = "maxParejas";
            this.maxParejas.ReadOnly = true;
            // 
            // btnAnuncio
            // 
            this.btnAnuncio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuncio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnAnuncio.Enabled = false;
            this.btnAnuncio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAnuncio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuncio.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAnuncio.Location = new System.Drawing.Point(1041, 796);
            this.btnAnuncio.Name = "btnAnuncio";
            this.btnAnuncio.Size = new System.Drawing.Size(203, 39);
            this.btnAnuncio.TabIndex = 18;
            this.btnAnuncio.Text = "Generar Anuncio";
            this.btnAnuncio.UseVisualStyleBackColor = false;
            this.btnAnuncio.Click += new System.EventHandler(this.btnAnuncio_Click);
            // 
            // FormTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1256, 847);
            this.Controls.Add(this.btnAnuncio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.labelTorneos);
            this.Controls.Add(this.DtgvTorneos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTorneos";
            this.Text = "FormTorneos";
            this.Load += new System.EventHandler(this.FormTorneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvTorneos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelTorneos;
        private System.Windows.Forms.DataGridView DtgvTorneos;
        private System.Windows.Forms.Button btnAnuncio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxParejas;
    }
}