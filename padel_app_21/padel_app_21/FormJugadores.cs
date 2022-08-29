using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace padel_app_21
{
    public partial class FormJugadores : Form
    {
        public FormJugadores()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        Jugador jugador;                            //VARIABLE QUE ME PERMITE CREAR JUGADORES NUEVOS
        Sistema sistema = new Sistema();            //VARIABLE QUE ME PERMTIE LLEVAR LA INSTANCIA DEL SISTEMA
        int n;                                      //VARIABLE QUE ME PERMITE LLEVAR EL NUMERO DE JUGADORES EN EL DTGV
        int indice;                                 //VARIABLE QUE ME PERMITE LLEVAR EL INDICE DE LA CELDA ELEGIDA

        //BOTONES

        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarJugador();
        }

        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarJugador();
        }

        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarJugador();
        }

        //EVENTOS

        //CARGAR EL FORM
        private void FormJugadores_Load(object sender, EventArgs e)
        {
            AbrirArchivo();
                
            if(sistema.Jugadores != null)                                           //EN CASO DE EXISTIR, CARGO TODOS LOS DATOS EN EL DTGV
            {
                foreach (Jugador jugador in sistema.Jugadores)
                {
                    n = DtgvJugadores.Rows.Add();                                   //ADICIONAMOS NUEVO RENGLON

                    //COLOCAMOS LA INFORMACIÓN
                    cargarDatos(n, jugador);
                }
            }
        }
        
        //SELECCION DE CELDA
        private void DtgvJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        //FUNCIONES

        //GUARDAR ARCHIVO
        private void GuardarArchivo()
        {
            if (!Directory.Exists(sistema.Direccion()))
                Directory.CreateDirectory(sistema.Direccion());

            bool result = Archivo.Guardar(sistema.Direccion() + @"\Jugadores.dat", sistema);
        }

        //ABRIR ARCHIVO
        private void AbrirArchivo()
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

        //SETTERS
        public void setJugador(Jugador jugador)
        {
            this.jugador = jugador;
        }
        
        //GETTERS
        public Jugador getJugador()
        {
            return jugador;
        }

        //CARGAR LOS DATOS EN DGV
        private void cargarDatos(int indice, Jugador jugador)
        {
            DtgvJugadores.Rows[indice].Cells[0].Value = jugador.Nombre;
            DtgvJugadores.Rows[indice].Cells[1].Value = jugador.Telefono;
            DtgvJugadores.Rows[indice].Cells[2].Value = jugador.Localidad;
            DtgvJugadores.Rows[indice].Cells[3].Value = jugador.Categoria;
            DtgvJugadores.Rows[indice].Cells[4].Value = jugador.Posicion;
            DtgvJugadores.Rows[indice].Cells[5].Value = jugador.Puntos;
        }




        //OBTENGO EL JUGADOR DE LA FILA SELECCIONADA
        private void seleccionarJugador()
        {
            if (indice != -1)
            {
                string nombre = DtgvJugadores.Rows[indice].Cells[0].Value.ToString();
                if (sistema.Jugadores.Any(item => item.Nombre == nombre))
                {
                    foreach (Jugador jugador in sistema.Jugadores)
                    {
                        if (jugador.Nombre == nombre)
                        {
                            this.jugador = jugador;
                        }
                    }
                }
                else
                {
                    jugador = null;
                }
            }
        }

        //AGREGAR JUGADOR
        private void agregarJugador()
        {
            //CREAMOS VENTANA PARA CREAR JUGADOR
            CrearJugador crear = new CrearJugador();
            AddOwnedForm(crear);
            //MOSTRAMOS LA VENTANA PARA CREAR JUGADOR
            crear.ShowDialog();

            //BANDERA
            bool Existente = false;

            //COLOCAMOS LA INFORMACIÓN
            if (jugador != null)
            {
                //CONSULTAMOS SI EXISTE EL JUGADOR EN LA LISTA
                Existente = sistema.Jugadores.Any(item => item.Dni == jugador.Dni);

                if (!Existente)
                {
                    //MENSAJE DE EXITO
                    MessageBox.Show("El jugador fue registrado");

                    //AGREGAMOS JUGADOR AL DTGV
                    n = DtgvJugadores.Rows.Add(); //ADICIONAMOS NUEVO RENGLON

                    cargarDatos(n, jugador);

                    //AGREGAMOS JUGADOR A LA LISTA EN SISTEMA Y GUARDAMOS EL ARCHIVO
                    sistema.agregar(jugador);
                    GuardarArchivo();

                    //LIMPIAMOS JUGADOR
                    jugador = null;
                }
                else
                {
                    MessageBox.Show("El jugador ya esta registrado en el sistema");
                }
            }
        }

        //MODIFICAR JUGADOR
        private void modificarJugador()
        {
            seleccionarJugador();
            //CREAMOS VENTANA PARA MODIFICAR TORNEO
            CrearJugador crear = new CrearJugador();
            AddOwnedForm(crear);
            //CARGAMOS LOS DATOS DEL TORNEO PREVIO
            crear.cargarJugador();
            //OBTENEMOS EL INDICE DE LA UBICACION DEL TORNEO EN LA LISTA
            int _indice = sistema.Jugadores.IndexOf(jugador);
            //REMOVEMOS EL JUGADOR ANTIGUO
            sistema.Jugadores.RemoveAt(_indice);
            //MOSTRAMOS LA VENTANA PARA MODIFICAR AL JUGADOR
            crear.ShowDialog();
            //CARGAMOS EL JUGADOR MODIFICADO AL DGV
            cargarDatos(indice, jugador);
            //AGREGAMOS EL JUGADOR MODIFICADO A LA LISTA
            sistema.Jugadores.Insert(_indice, jugador);
            //GUARDAMOS CAMBIOS
            GuardarArchivo();
            //LIMPIAMOS LA VARIABLE
            jugador = null;
            //REINICIAMOS EL INDICE
            indice = -1;
        }

        //ELIMINAR JUGADOR
        private void eliminarJugador()
        {
            if (indice != -1)
            {
                string nombre = DtgvJugadores.Rows[indice].Cells[0].Value.ToString();
                if (MessageBox.Show("Estas Seguro que desea eliminar al jugador: " + nombre, "Eliminar Jugador", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    seleccionarJugador();                                   //SELECCIONO EL JUGADOR DEL DGV
                    DtgvJugadores.Rows.RemoveAt(indice);                    //ELIMINO EL JUGADOR DEL DGV
                    sistema.Jugadores.Remove(jugador);                      //ELIMINO EL JUGADOR DE LA LISTA DE JUGADORES
                    n -= 1;                                                 //ACTUALIZO LA CANTIDAD DE FILAS DE DGV
                    GuardarArchivo();                                       //GUARDO CAMBIOS
                    jugador = null;                                         //LIMPIO LA VARIABLE
                    indice = -1;                                            //REINICIAMOS EL INDICE
                }
            }
        }

    }//FIN FormJugadores
}//FIN NAMESPACE
