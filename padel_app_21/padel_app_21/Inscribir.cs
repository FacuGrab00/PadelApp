using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace padel_app_21
{
    public partial class Inscribir : Form
    {
        //CONSTRUCTOR
        public Inscribir()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        Sistema sistema = new Sistema();                                //VARIABLE QUE ME PERMITE LLEVAR LA INSTANCIA DE SISTEMA
        Torneo torneo;

        //BOTONES

        //CONFIRMAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            agregarPareja();
        }

        //CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCIONES

        //CARGAR LOS DATOS DEL FORM
        private void Inscribir_Load(object sender, EventArgs e)
        {
            AbrirArchivo();
            CargarComboBox();
        }

        //CARGA COMBOBOX
        private void CargarComboBox()
        {
            //OBTENEMOS EL TORNEO SELECCIONADO DEL FORM INSCRIPTOS
            FormInscriptos formInscriptos = Owner as FormInscriptos;
            torneo = formInscriptos.getTorneo();

            //AGREGAMOS LAS CATEGORIAS QUE PERMITE EL TORNEO SELECCIONADO
            foreach (var categoria in torneo.getCategorias())
            {
                cboxCategoria.Items.Add(categoria.Nivel);
            }
        }

        //ABRIMOS EL ARCHIVO DE LOS JUGADORES PARA CARGARLOS EN LOS COMBOBOXS
        public void AbrirArchivo()
        {
            try
            {
                sistema = Archivo.Abrir(sistema.Direccion() + @"\Jugadores.dat");   //RECIBO EL ARCHIVO GUARDADO DE SISTEMAS
            }
            catch (Exception ex)
            {
                sistema = null;
            }
        }

        //AGREGA LOS JUGADORES A LOS COMBOBOX
        private void agregarJugador(string categoria)
        {
            //ANTES DE CARGAR JUGADORES, ELIMINAMOS LOS ANTERIORES PARA EVITAR CRUCES DE CATEGORIAS
            cboxJugador1.Items.Clear();
            cboxJugador2.Items.Clear();

            //BUSCAMOS LOS JUGADORES QUE PERTENEZCAN A LA CATEGORIA SELECCIONADA
            foreach (var Jugador in sistema.Jugadores)
            {
                if (Jugador.Categoria == categoria)
                {
                    cboxJugador1.Items.Add(Jugador);
                    cboxJugador2.Items.Add(Jugador);
                }
            }
        }

        //CONTROL DE CATEGORIAS
        private void ControlCategoria(string categoria)
        {
            if (cboxCategoria.SelectedItem.ToString() == categoria)
            {
                agregarJugador(categoria);
            }
        }

        //TOMA EL ELEMENTO SELECCIONADO DEL CHECKBOX
        private void cboxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BUSCAMOS LA CATEGORIA QUE CORRESPONDE A LA DEL ITEM SELECCIONADO PARA FILTRAR LOS JUGADORES
            foreach (var categoria in torneo.getCategorias())
            {
                ControlCategoria(categoria.Nivel);
            }
        }

        //AGREGAR PAREJA
        private void agregarPareja()
        {
            //ATRIBUTOS
            bool bandJugador = false;
            bool bandMaxJug = false;
            bool Existente = false;
            Jugador jugador1 = cboxJugador1.SelectedItem as Jugador;
            Jugador jugador2 = cboxJugador2.SelectedItem as Jugador;
            Pareja pareja = null;

            //OBTENGO LA CATEGORIA CON LA QUE VAMOS A TRABAJAR
            string categoria = cboxCategoria.SelectedItem.ToString();
            //COMPRUEBO QUE NO SE EXCEDA EL MAXIMO DE PAREJAS
            if (torneo.obtenerCategoria(categoria).Inscripciones.Count < torneo.MaxParejas) bandMaxJug = true;
            else
            {
                bandMaxJug = false;
                MessageBox.Show("ya no existen cupos en el torneo, No se pueden inscribir mas parejas");
            }

            try
            {
                pareja = new Pareja(jugador1, jugador2);
                bandJugador = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                bandJugador = false;
            }


            //COMPROBAMOS QUE LA PAREJA NO EXISTA EN LA LISTA
            List<Pareja> parejas = torneo.obtenerCategoria(categoria).Inscripciones;

            //COMPRUEBO QUE LA PAREJA CREADA NO EXISTA EN EL SISTEMA
            if (bandJugador)
            {
                Existente = parejas.Any(item =>
                item.getJugador1().Nombre == pareja.getJugador1().Nombre ||
                item.getJugador2().Nombre == pareja.getJugador2().Nombre ||
                item.getJugador1().Nombre == pareja.getJugador2().Nombre ||
                item.getJugador2().Nombre == pareja.getJugador1().Nombre);
            }

            //SI LA PAREJA YA EXISTE
            if (Existente)
            {
                bandJugador = false;
                MessageBox.Show("La pareja ya esta inscripta");
            }

            if (bandJugador == true && bandMaxJug == true)
            {
                torneo.obtenerCategoria(categoria).Inscripciones.Add(pareja);
                FormInscriptos formInscriptos = Owner as FormInscriptos;
                formInscriptos.setTorneo(torneo);
                formInscriptos.limpiarGrid();
                formInscriptos.cargarGrid();
                formInscriptos.GuardarArchivo();
                this.Close();
            }
        }

    }//FIN Inscribir
}//FIN NAMESPACE
