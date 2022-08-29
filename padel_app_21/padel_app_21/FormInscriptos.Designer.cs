
namespace padel_app_21
{
    partial class FormInscriptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscriptos));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DtgvInscriptos = new System.Windows.Forms.DataGridView();
            this.Jugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInscriptos = new System.Windows.Forms.Label();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvInscriptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 796);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(203, 39);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Inscribir Pareja";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(221, 796);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(203, 39);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar Pareja";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DtgvInscriptos
            // 
            this.DtgvInscriptos.AllowUserToAddRows = false;
            this.DtgvInscriptos.AllowUserToDeleteRows = false;
            this.DtgvInscriptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgvInscriptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvInscriptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jugador1,
            this.Jugador2,
            this.Localidades,
            this.Categoria});
            this.DtgvInscriptos.Location = new System.Drawing.Point(12, 89);
            this.DtgvInscriptos.Name = "DtgvInscriptos";
            this.DtgvInscriptos.ReadOnly = true;
            this.DtgvInscriptos.RowHeadersWidth = 51;
            this.DtgvInscriptos.RowTemplate.Height = 29;
            this.DtgvInscriptos.Size = new System.Drawing.Size(1232, 669);
            this.DtgvInscriptos.TabIndex = 23;
            this.DtgvInscriptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvInscriptos_CellClick);
            // 
            // Jugador1
            // 
            this.Jugador1.HeaderText = "Jugador 1";
            this.Jugador1.MinimumWidth = 6;
            this.Jugador1.Name = "Jugador1";
            this.Jugador1.ReadOnly = true;
            // 
            // Jugador2
            // 
            this.Jugador2.HeaderText = "Jugador 2";
            this.Jugador2.MinimumWidth = 6;
            this.Jugador2.Name = "Jugador2";
            this.Jugador2.ReadOnly = true;
            // 
            // Localidades
            // 
            this.Localidades.HeaderText = "Localidades";
            this.Localidades.MinimumWidth = 6;
            this.Localidades.Name = "Localidades";
            this.Localidades.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // labelInscriptos
            // 
            this.labelInscriptos.AutoSize = true;
            this.labelInscriptos.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelInscriptos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInscriptos.Location = new System.Drawing.Point(12, 9);
            this.labelInscriptos.Name = "labelInscriptos";
            this.labelInscriptos.Size = new System.Drawing.Size(284, 59);
            this.labelInscriptos.TabIndex = 24;
            this.labelInscriptos.Text = "INSCRIPTOS";
            // 
            // lblTorneo
            // 
            this.lblTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTorneo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTorneo.Location = new System.Drawing.Point(532, 15);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(643, 59);
            this.lblTorneo.TabIndex = 25;
            this.lblTorneo.Text = "TORNEO PALABRA PALABRA";
            this.lblTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(1181, 12);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(63, 62);
            this.btnSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSiguiente.TabIndex = 26;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(463, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(63, 62);
            this.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // FormInscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1256, 847);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.labelInscriptos);
            this.Controls.Add(this.DtgvInscriptos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInscriptos";
            this.Text = "FormInscriptos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgvInscriptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DtgvInscriptos;
        private System.Windows.Forms.Label labelInscriptos;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.PictureBox btnSiguiente;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}