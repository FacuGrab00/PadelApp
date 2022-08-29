using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace padel_app_21
{
    public partial class CrearJugador : Form
    {
        //CONSTRUCTOR
        public CrearJugador()
        {
            InitializeComponent();
        }

        //BOTONES

        //CONFIRMAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //ATRIBUTOS
            bool bandera = true;

            //VALIDACIÓN DE LOS PARAMETROS
            bandera = validarCampos(bandera);

            if (bandera == true)
            {
                crearJugador();
            }
        }

        //CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //FUNCIONES

        //CREACIÓN DEL JUGADOR
        private void crearJugador()
        {
            //ATRIBUTOS
            Jugador jugador;

            string nombre = txtNombre.Text;
            long telefono = Convert.ToInt64(txtTelefono.Text);
            int dni = Convert.ToInt32(txtDni.Text);
            string localidad = txtLocalidad.Text;
            string categoria = cboxCategoria.SelectedItem.ToString();
            string posicion = cboxPosicion.SelectedItem.ToString();
            double puntos = Convert.ToInt32(txtPuntos.Text);
            int edad = Convert.ToInt32(txtEdad.Text);

            //CREAMOS JUGADOR
            jugador = new Jugador(nombre, telefono, dni, posicion, localidad, categoria, puntos, edad);

            //COMUNICACION CON VENTANA CREADORA
            FormJugadores formJugadores = Owner as FormJugadores;

            //PASAJE DEL NUEVO JUGADOR
            formJugadores.setJugador(jugador);

            //LIMPIAMOS LA VARIABLE
            jugador = null;

            //CERRAMOS VENTANA
            this.Close();
        }

        //VALIDACIÓN DE LOS CAMPOS
        private bool validarCampos(bool bandera)
        {
            //Nombre
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "ERROR! campo vacio");
                bandera = false;
            }

            //Telefono
            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "ERROR! campo vacio");
                bandera = false;
            }

            //Dni
            if(txtDni.Text == "")
            {
                errorProvider1.SetError(txtDni, "ERROR! campo vacio");
                bandera = false;
            }

            //Localidad
            if (txtLocalidad.Text == "")
            {
                errorProvider1.SetError(txtLocalidad, "ERROR! campo vacio");
                bandera = false;
            }

            //Categoria
            if (cboxCategoria.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboxCategoria, "ERROR! campo vacio");
                bandera = false;
            }

            //Posición
            if (cboxPosicion.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboxPosicion, "ERROR! campo vacio");
                bandera = false;
            }

            //Puntos
            if (txtPuntos.Text == "")
            {
                errorProvider1.SetError(txtPuntos, "ERROR! campo vacio");
                bandera = false;
            }

            //Edad
            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "ERROR! campo vacio");
                bandera = false;
            }

            return bandera;
        }

        //CARGO LOS DATOS DEL JUGADOR PREVIO PARA MODIFICAR
        public void cargarJugador()
        {
            FormJugadores formJugadores = Owner as FormJugadores;
            Jugador jugador = formJugadores.getJugador();
            txtNombre.Text = jugador.Nombre;
            txtTelefono.Text = jugador.Telefono.ToString();
            txtDni.Text = jugador.Dni.ToString();
            txtLocalidad.Text = jugador.Localidad;
            cboxCategoria.SelectedItem = jugador.Categoria;
            cboxPosicion.SelectedItem = jugador.Posicion;
            txtPuntos.Text = jugador.Puntos.ToString();
            txtEdad.Text = jugador.Edad.ToString();
        }

        //EVENTOS

        //PRESIONAR TECLAS | IMPIDO EL INGRESO DE LETRAS A LOS TEXTBOXS NUMERICOS
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //MODIFICAR TEXTO | LIMPIO EL ERROR EN CASO DE EXISTIR
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        //PRESIONAR TECLAS | IMPIDO EL INGRESO DE NUMEROS A LOS TEXTBOXS
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

    }//FIN CrearJugador
}//FIN NAMESPACE
