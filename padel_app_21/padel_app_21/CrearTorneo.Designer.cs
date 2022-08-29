
namespace padel_app_21
{
    partial class CrearTorneo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTorneo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTorneos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.txtPremio = new System.Windows.Forms.TextBox();
            this.cbPrincipiante = new System.Windows.Forms.CheckBox();
            this.cbOctava = new System.Windows.Forms.CheckBox();
            this.cbSeptima = new System.Windows.Forms.CheckBox();
            this.cbSexta = new System.Windows.Forms.CheckBox();
            this.cbCuarta = new System.Windows.Forms.CheckBox();
            this.cbQuinta = new System.Windows.Forms.CheckBox();
            this.cbTercera = new System.Windows.Forms.CheckBox();
            this.cbSegunda = new System.Windows.Forms.CheckBox();
            this.cbPrimera = new System.Windows.Forms.CheckBox();
            this.numericMaxParejas = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxParejas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.labelTorneos);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 69);
            this.panel1.TabIndex = 17;
            // 
            // labelTorneos
            // 
            this.labelTorneos.AutoSize = true;
            this.labelTorneos.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTorneos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTorneos.Location = new System.Drawing.Point(425, 3);
            this.labelTorneos.Name = "labelTorneos";
            this.labelTorneos.Size = new System.Drawing.Size(358, 59);
            this.labelTorneos.TabIndex = 3;
            this.labelTorneos.Text = "CREAR TORNEO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre del Torneo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(176, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 45);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 45);
            this.label3.TabIndex = 20;
            this.label3.Text = "Precio Inscripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(200, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 45);
            this.label4.TabIndex = 21;
            this.label4.Text = "Premio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(143, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 45);
            this.label5.TabIndex = 22;
            this.label5.Text = "Categorias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "Maximo de Parejas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(200, 760);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 45);
            this.label7.TabIndex = 24;
            this.label7.Text = "Puntos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(83, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 45);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha de inicio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(347, 165);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(864, 49);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(347, 250);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(864, 49);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInscripcion.Location = new System.Drawing.Point(347, 420);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(864, 49);
            this.txtInscripcion.TabIndex = 28;
            this.txtInscripcion.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtInscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtPremio
            // 
            this.txtPremio.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPremio.Location = new System.Drawing.Point(347, 505);
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.Size = new System.Drawing.Size(864, 49);
            this.txtPremio.TabIndex = 29;
            this.txtPremio.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtPremio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // cbPrincipiante
            // 
            this.cbPrincipiante.AutoSize = true;
            this.cbPrincipiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPrincipiante.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPrincipiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbPrincipiante.Location = new System.Drawing.Point(347, 593);
            this.cbPrincipiante.Name = "cbPrincipiante";
            this.cbPrincipiante.Size = new System.Drawing.Size(182, 42);
            this.cbPrincipiante.TabIndex = 30;
            this.cbPrincipiante.Text = "Principiante";
            this.cbPrincipiante.UseVisualStyleBackColor = true;
            this.cbPrincipiante.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbOctava
            // 
            this.cbOctava.AutoSize = true;
            this.cbOctava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbOctava.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOctava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbOctava.Location = new System.Drawing.Point(538, 593);
            this.cbOctava.Name = "cbOctava";
            this.cbOctava.Size = new System.Drawing.Size(78, 42);
            this.cbOctava.TabIndex = 31;
            this.cbOctava.Text = "8va";
            this.cbOctava.UseVisualStyleBackColor = true;
            this.cbOctava.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbSeptima
            // 
            this.cbSeptima.AutoSize = true;
            this.cbSeptima.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSeptima.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSeptima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSeptima.Location = new System.Drawing.Point(625, 593);
            this.cbSeptima.Name = "cbSeptima";
            this.cbSeptima.Size = new System.Drawing.Size(89, 42);
            this.cbSeptima.TabIndex = 32;
            this.cbSeptima.Text = "7ma";
            this.cbSeptima.UseVisualStyleBackColor = true;
            this.cbSeptima.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbSexta
            // 
            this.cbSexta.AutoSize = true;
            this.cbSexta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSexta.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSexta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSexta.Location = new System.Drawing.Point(723, 593);
            this.cbSexta.Name = "cbSexta";
            this.cbSexta.Size = new System.Drawing.Size(74, 42);
            this.cbSexta.TabIndex = 33;
            this.cbSexta.Text = "6ta";
            this.cbSexta.UseVisualStyleBackColor = true;
            this.cbSexta.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbCuarta
            // 
            this.cbCuarta.AutoSize = true;
            this.cbCuarta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCuarta.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCuarta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbCuarta.Location = new System.Drawing.Point(889, 593);
            this.cbCuarta.Name = "cbCuarta";
            this.cbCuarta.Size = new System.Drawing.Size(74, 42);
            this.cbCuarta.TabIndex = 34;
            this.cbCuarta.Text = "4ta";
            this.cbCuarta.UseVisualStyleBackColor = true;
            this.cbCuarta.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbQuinta
            // 
            this.cbQuinta.AutoSize = true;
            this.cbQuinta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbQuinta.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbQuinta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbQuinta.Location = new System.Drawing.Point(806, 593);
            this.cbQuinta.Name = "cbQuinta";
            this.cbQuinta.Size = new System.Drawing.Size(74, 42);
            this.cbQuinta.TabIndex = 35;
            this.cbQuinta.Text = "5ta";
            this.cbQuinta.UseVisualStyleBackColor = true;
            this.cbQuinta.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbTercera
            // 
            this.cbTercera.AutoSize = true;
            this.cbTercera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTercera.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTercera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTercera.Location = new System.Drawing.Point(962, 593);
            this.cbTercera.Name = "cbTercera";
            this.cbTercera.Size = new System.Drawing.Size(75, 42);
            this.cbTercera.TabIndex = 36;
            this.cbTercera.Text = "3ra";
            this.cbTercera.UseVisualStyleBackColor = true;
            this.cbTercera.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbSegunda
            // 
            this.cbSegunda.AutoSize = true;
            this.cbSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSegunda.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSegunda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSegunda.Location = new System.Drawing.Point(1046, 593);
            this.cbSegunda.Name = "cbSegunda";
            this.cbSegunda.Size = new System.Drawing.Size(81, 42);
            this.cbSegunda.TabIndex = 37;
            this.cbSegunda.Text = "2da";
            this.cbSegunda.UseVisualStyleBackColor = true;
            this.cbSegunda.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // cbPrimera
            // 
            this.cbPrimera.AutoSize = true;
            this.cbPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPrimera.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPrimera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbPrimera.Location = new System.Drawing.Point(1136, 593);
            this.cbPrimera.Name = "cbPrimera";
            this.cbPrimera.Size = new System.Drawing.Size(75, 42);
            this.cbPrimera.TabIndex = 38;
            this.cbPrimera.Text = "1ra";
            this.cbPrimera.UseVisualStyleBackColor = true;
            this.cbPrimera.CheckedChanged += new System.EventHandler(this.cbPrincipiante_CheckedChanged);
            // 
            // numericMaxParejas
            // 
            this.numericMaxParejas.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericMaxParejas.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericMaxParejas.Location = new System.Drawing.Point(347, 675);
            this.numericMaxParejas.Name = "numericMaxParejas";
            this.numericMaxParejas.Size = new System.Drawing.Size(864, 49);
            this.numericMaxParejas.TabIndex = 39;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Location = new System.Drawing.Point(347, 335);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(864, 49);
            this.dtpFecha.TabIndex = 41;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1219, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(1041, 849);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(203, 39);
            this.btnConfirmar.TabIndex = 43;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPuntos.Location = new System.Drawing.Point(347, 760);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(864, 49);
            this.txtPuntos.TabIndex = 44;
            this.txtPuntos.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtPuntos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // CrearTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1256, 900);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.numericMaxParejas);
            this.Controls.Add(this.cbPrimera);
            this.Controls.Add(this.cbSegunda);
            this.Controls.Add(this.cbTercera);
            this.Controls.Add(this.cbQuinta);
            this.Controls.Add(this.cbCuarta);
            this.Controls.Add(this.cbSexta);
            this.Controls.Add(this.cbSeptima);
            this.Controls.Add(this.cbOctava);
            this.Controls.Add(this.cbPrincipiante);
            this.Controls.Add(this.txtPremio);
            this.Controls.Add(this.txtInscripcion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearTorneo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxParejas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTorneos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.TextBox txtPremio;
        private System.Windows.Forms.CheckBox cbPrincipiante;
        private System.Windows.Forms.CheckBox cbOctava;
        private System.Windows.Forms.CheckBox cbSeptima;
        private System.Windows.Forms.CheckBox cbSexta;
        private System.Windows.Forms.CheckBox cbCuarta;
        private System.Windows.Forms.CheckBox cbQuinta;
        private System.Windows.Forms.CheckBox cbTercera;
        private System.Windows.Forms.CheckBox cbSegunda;
        private System.Windows.Forms.CheckBox cbPrimera;
        private System.Windows.Forms.NumericUpDown numericMaxParejas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPuntos;
    }
}