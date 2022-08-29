using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace padel_app_21
{
    public partial class Form1 : Form
    {

        //ATRIBUTOS
        FormTorneos formTorneo = new FormTorneos();
        FormJugadores formJugador = new FormJugadores();
        FormInscriptos formInscriptos = new FormInscriptos();

        //CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }

        //BOTON JUGADORES
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            Abrirformhija(formJugador);
        }

        //BOTON TORNEOS
        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Abrirformhija(formTorneo);
        }

        //BOTON INSCRIPTOS
        private void btnIncriptos_Click(object sender, EventArgs e)
        {
            formInscriptos.AbrirArchivo();
            formInscriptos.FormInscriptos_Load();
            Abrirformhija(formInscriptos);
        }

        //BOTON INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Abrirformhija(new FormLogo());
        }

        //PROCEDIMIENTO ABRIR VENTANA HIJA
        private void Abrirformhija(object formhija)
        {
            if (this.panelVentana.Controls.Count > 0)
                this.panelVentana.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelVentana.Controls.Add(fh);
            this.panelVentana.Tag = fh;
            fh.Show();
        }

        //EVENTO FORM CARGA
        private void Form1_Load(object sender, EventArgs e)
        {
            Abrirformhija(new FormLogo());
        }

    }//FIN DE CLASE PRINCIPAL
}
