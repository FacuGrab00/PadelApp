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
    public partial class FormTorneos : Form
    {
        //CONSTRUCTOR
        public FormTorneos()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        Torneo torneo;                                                  //VARIABLE QUE ME PERMITE CREAR TORNEOS NUEVOS
        Sistema sistema = new Sistema();                                //VARIABLE QUE ME PERMTIE LLEVAR LA INSTANCIA DEL SISTEMA
        int n;                                                          //VARIABLE QUE ME PERMITE LLEVAR EL NUMERO DE TORNEOS EN EL DTGV
        int indice = 0;                                                 //VARIABLE QUE ME PERMITE LLEVAR EL INDICE DE LA CELDA ELEGIDA

        //BOTONES

        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarTorneo();
        }

        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTorneo();
        }

        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarTorneo();
        }

        //ANUNCIO
        private void btnAnuncio_Click(object sender, EventArgs e)
        {
            generarAnuncio();
        }

        //GUARDAR ARCHIVO
        public void GuardarArchivo()
        {
            if (!Directory.Exists(sistema.Direccion()))
                Directory.CreateDirectory(sistema.Direccion());

            bool result = Archivo.Guardar(sistema.Direccion() + @"\Torneo.dat", sistema);
        }

        //ABRIR ARCHIVO
        private void AbrirArchivo()
        {
            try
            {
                sistema = Archivo.Abrir(sistema.Direccion() + @"\Torneo.dat");      //RECIBO EL ARCHIVO GUARDADO DE SISTEMAS
            }
            catch (Exception ex)
            {
                sistema = null;
            }
        }

        //SETTERS
        public void setTorneo(Torneo torneo)
        {
            this.torneo = torneo;
        }

        //GETTERS
        public Torneo getTorneo()
        {
            return torneo;
        }

        //EVENTOS

        //CARGA DE FORMULARIO
        private void FormTorneos_Load(object sender, EventArgs e)
        {
            //ABRIMOS EL ARCHIVO SI EXISTE
            AbrirArchivo();

            if (sistema.Torneos != null)                                            //EN CASO DE EXISTIR, CARGO TODOS LOS DATOS EN EL DTGV
            {
                foreach (Torneo torneo in sistema.Torneos)
                {
                    n = DtgvTorneos.Rows.Add();                                     //ADICIONAMOS NUEVO RENGLON

                    //COLOCAMOS LA INFORMACIÓN
                    cargarDatos(n, torneo);
                }
            }
        }

        //SELECCION DE CELDA
        private void DtgvTorneos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if(indice != -1)
            {
                btnAnuncio.Enabled = true;
            }
            
        }

        //FUNCIONES
        private void cargarDatos(int indice, Torneo torneo)
        {
            DtgvTorneos.Rows[indice].Cells[0].Value = torneo.Nombre;
            DtgvTorneos.Rows[indice].Cells[1].Value = torneo.Puntos;
            DtgvTorneos.Rows[indice].Cells[2].Value = torneo.FechaInicio.ToString().Split(" ")[0];
            DtgvTorneos.Rows[indice].Cells[3].Value = torneo.Inscripcion;
            DtgvTorneos.Rows[indice].Cells[4].Value = torneo.Premio;
            DtgvTorneos.Rows[indice].Cells[5].Value = torneo.stringCategorias();
            DtgvTorneos.Rows[indice].Cells[6].Value = torneo.MaxParejas;
        }

        //OBTENEMOS EL TORNEO SELECCIONADO POR EL USUARIO
        private void seleccionarTorneo()
        {
            if(indice != -1)
            {
                string nombre = DtgvTorneos.Rows[indice].Cells[0].Value.ToString();
                if(sistema.Torneos.Any(item => item.Nombre == nombre))
                {
                    foreach (Torneo torneo in sistema.Torneos)
                    {
                        if(torneo.Nombre == nombre)
                        {
                            this.torneo = torneo;
                        }
                    }
                }
                else
                {
                    torneo = null;
                }
            }
        }

        //AGREGAR TORNEO
        private void agregarTorneo()
        {
            //CREAMOS VENTANA PARA CREAR TORNEOS
            CrearTorneo crear = new CrearTorneo();
            AddOwnedForm(crear);
            //MOSTRAMOS AL VENTANA PARA CREAR EL TORNEO
            crear.ShowDialog();

            //COLOCAMOS LA INFORMACIÓN
            if (torneo != null)
            {
                //ADICIONAMOS NUEVO RENGLON
                n = DtgvTorneos.Rows.Add();
                //CARGARMOS LOS DATOS DEL TORNEO AL DGV
                cargarDatos(n, torneo);
                //AGREGAMOS TORNEO A LA LISTA
                sistema.agregar(torneo);
                //GUARDAMOS EL ARCHIVO
                GuardarArchivo();
                //MENSAJE DE EXITO
                MessageBox.Show("El Torneo fue registrado!");
                //LIMPIAMOS LA VARIABLE
                torneo = null;
            }
        }

        //MODIFICAR TORNEO
        private void modificarTorneo()
        {
            //MENSAJES
            string advertencia = "Si Modifica un torneo las inscripciones se perderan, ¿esta seguro que desea modificar el torneo?";
            string titulo = "Modificar Torneo";

            //ADVERTENCIA
            if (MessageBox.Show(advertencia, titulo, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //SELECCIONAMOS EL TORNEO A MODIFICAR
                seleccionarTorneo();
                //CREAMOS VENTANA PARA MODIFICAR TORNEO
                CrearTorneo crear = new CrearTorneo();
                AddOwnedForm(crear);
                //CARGAMOS LOS DATOS DEL TORNEO PREVIO
                crear.cargarTorneo();
                //OBTENEMOS EL INDICE DE LA UBICACION DEL TORNEO EN LA LISTA
                int _indice = sistema.Torneos.IndexOf(torneo);
                //REMOVEMOS EL TORNEO ANTIGUO DE LA LISTA
                sistema.Torneos.RemoveAt(_indice);
                //ABRIMOS LA VENTANA PARA REALIZAR LOS CAMBIOS
                crear.ShowDialog();
                //CARGAMOS EL TORNEO MODIFICADO AL DGV
                cargarDatos(indice, torneo);
                //AGREGAMOS EL TORNEO MODIFICADO A LA LISTA
                sistema.Torneos.Insert(_indice, torneo);
                //GUARDAMOS CAMBIOS
                GuardarArchivo();
                //LIMPIAMOS LA VARIABLE
                torneo = null;
            }
        }

        //ELIMINAR TORNEO
        private void eliminarTorneo()
        {
            //CONDICION: DEBE HABER UNA FILA SELECCIONADA QUE NO SEA LA CABECERA!
            if (indice != -1)
            {
                //TOMAMOS EL NOMBRE DEL TORNEO DE LA FILA SELECCIONADA POR EL USUARIO
                string nombre = DtgvTorneos.Rows[indice].Cells[0].Value.ToString();

                //MENSAJES
                string advertencia = "Estas Seguro que desea eliminar el Torneo: " + nombre;
                string titulo = "Eliminar Torneo";

                //ADVERTENCIA
                if (MessageBox.Show(advertencia, titulo, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    seleccionarTorneo();                                    //SELECCIONO EL TORNEO DEL DGV
                    DtgvTorneos.Rows.RemoveAt(indice);                      //ELIMINO EL TORNEO DEL DGV
                    sistema.Torneos.Remove(torneo);                         //ELIMINO EL TORNOE DE LA LISTA DE TORNEOS
                    n -= 1;                                                 //ACTUALIZO LA CANTIDAD DE FILAS DE DGV
                    GuardarArchivo();                                       //GUARDO CAMBIOS
                    torneo = null;                                          //LIMPIO LA VARIABLE
                }
            }
        }

        //GENERAR ANUNCIO
        private void generarAnuncio()
        {
            seleccionarTorneo();
            //SI EL TORNEO EXISTE
            if (torneo != null)
            {
                //CREAMOS LA VENTANA QUE CONTENDRA EL ANUNCIO
                Anuncio anuncio = new Anuncio();
                //ENVIAMOS LOS DATOS DEL TORNEO
                anuncio.setTorneo(torneo);
                //MOSTRAMOS LA VENTANA
                anuncio.ShowDialog();
                //LIMPIAMOS LA VARIABLE
                torneo = null;
            }
        }

    }//FIN FormTorneos
}//FIN NAMESPACE
