using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace padel_app_21
{
    public partial class Anuncio : Form
    {
        //CONSTRUCTOR
        public Anuncio()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        Torneo torneo;

        //BOTONES

        //GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarAnuncio();
        }

        //CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SETTERS
        public void setTorneo(Torneo torneo)
        {
            this.torneo = torneo;
        }

        //FUNCIONES
        private void guardarAnuncio()
        {
            //CREO UN SAVEFILEDIALOG
            SaveFileDialog guardar = new SaveFileDialog();
            //ESTABLESCO FILTRO
            guardar.Filter = "Imagen jpg|*.jpg";
            //MUESTRO EL DIALOGO
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                bool resultado = Archivo.Guardar(guardar.FileName, panelAnuncio);
                if (resultado == false)
                {
                    MessageBox.Show("No se puedo guardar la imagen");
                }
                this.Close();
            }
        }

        //CARGA LOS LBL
        public void cargarLbl()
        {
            lblTorneo.Text = torneo.Nombre;
            lblCategoria.Text = "Categorias: " + torneo.stringCategorias();
            lblPremio.Text = "Premio: " + torneo.Premio.ToString();
            lblPuntos.Text = "Puntos: " + torneo.Inscripcion.ToString();
            lblInscripcion.Text = "Precio: " + torneo.Inscripcion.ToString();
            lblFecha.Text = "Fecha: " + torneo.FechaInicio.ToString().Split(" ")[0];
        }

        //CARGA EL FORM
        private void Anuncio_Load(object sender, EventArgs e)
        {
            cargarLbl();
        }

    }//FIN Anuncio
}//FIN NAMESPACE
