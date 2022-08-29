
namespace padel_app_21
{
    partial class Inscribir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscribir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTorneos = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxJugador1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxJugador2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.labelTorneos);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 69);
            this.panel1.TabIndex = 18;
            // 
            // labelTorneos
            // 
            this.labelTorneos.AutoSize = true;
            this.labelTorneos.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTorneos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTorneos.Location = new System.Drawing.Point(425, 3);
            this.labelTorneos.Name = "labelTorneos";
            this.labelTorneos.Size = new System.Drawing.Size(424, 59);
            this.labelTorneos.TabIndex = 3;
            this.labelTorneos.Text = "INSCRIBIR PAREJA";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(207, 165);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(864, 50);
            this.cboxCategoria.TabIndex = 21;
            this.cboxCategoria.SelectedIndexChanged += new System.EventHandler(this.cboxCategoria_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "Categoría:";
            // 
            // cboxJugador1
            // 
            this.cboxJugador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxJugador1.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxJugador1.FormattingEnabled = true;
            this.cboxJugador1.Location = new System.Drawing.Point(207, 250);
            this.cboxJugador1.Name = "cboxJugador1";
            this.cboxJugador1.Size = new System.Drawing.Size(864, 50);
            this.cboxJugador1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Jugador 1:";
            // 
            // cboxJugador2
            // 
            this.cboxJugador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxJugador2.Font = new System.Drawing.Font("Segoe UI", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxJugador2.FormattingEnabled = true;
            this.cboxJugador2.Location = new System.Drawing.Point(207, 335);
            this.cboxJugador2.Name = "cboxJugador2";
            this.cboxJugador2.Size = new System.Drawing.Size(864, 50);
            this.cboxJugador2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 45);
            this.label2.TabIndex = 24;
            this.label2.Text = "Jugador 2:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(1023, 498);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(203, 39);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1201, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Inscribir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1238, 549);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cboxJugador2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxJugador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscribir";
            this.Text = "Inscribir";
            this.Load += new System.EventHandler(this.Inscribir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTorneos;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxJugador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxJugador2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}