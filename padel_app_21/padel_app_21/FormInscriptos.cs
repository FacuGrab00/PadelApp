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
    public partial class FormInscriptos : Form
    {
        //CONSTRUCTOR
        public FormInscriptos()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        Pareja pareja;
        int indice = 0;                         //INDICE QUE ME PERMITE CAMBIAR LOS LABELS
        Sistema sistema = new Sistema();        //VARIABLE QUE ME PERMTIE LLEVAR LA INSTANCIA DEL SISTEMA
        Torneo torneo;                          //VARIABLE QUE ME PERMITE LLEVAR LA INSTANCIA SELECCIONADA POR EL LABEL
        int n = 0;                              //VARIABLE QUE ME PERMITE LLEVAR EL NUMERO DE TORNEOS EN EL DTGV
        int dgvIndice = 0;                      //VARIABLE QUE ME PERMITE LLEVAR EL INDICE DE LA CELDA ELEGIDA

        //BOTONES

        //AGREGAR PAREJA
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Inscribir inscribir = new Inscribir();
            AddOwnedForm(inscribir);
            inscribir.ShowDialog();
        }

        //ELIMINAR PAREJA
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarPareja();
        }

        //SIGUIENTE TORNEO
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(indice < (sistema.Torneos.Count - 1))
            {
                indice += 1;
                torneo = sistema.Torneos[indice];
                lblTorneo.Text = torneo.Nombre;
                limpiarGrid();
                cargarGrid();
            }
        }

        //TORNEO ANTERIOR
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(indice > 0)
            {
                indice -= 1;
                torneo = sistema.Torneos[indice];
                lblTorneo.Text = torneo.Nombre;
                limpiarGrid();
                cargarGrid();
            }
        }

        //GETTERS
        public Torneo getTorneo()
        {
            return torneo;
        }

        //SETTERS
        public void setTorneo(Torneo torneo)
        {
            this.torneo = torneo;
        }

        //FUNCIONES

        //ABRIR ARCHIVO
        public void AbrirArchivo()
        {
            try
            {
                sistema = Archivo.Abrir(sistema.Direccion() + @"\Torneo.dat");  //RECIBO EL ARCHIVO GUARDADO DE SISTEMAS
            }
            catch (Exception ex)
            {
                sistema = null;
            }
        }

        //GUARDAR ARCHIVO
        public void GuardarArchivo()
        {
            if (!Directory.Exists(sistema.Direccion()))
                Directory.CreateDirectory(sistema.Direccion());

            bool result = Archivo.Guardar(sistema.Direccion() + @"\Torneo.dat", sistema);
        }

        //CARGA EL FORM
        public void FormInscriptos_Load()
        {
            if (sistema.Torneos.Count != 0)
            {
                torneo = sistema.Torneos[0];
                lblTorneo.Text = torneo.Nombre;
                if (torneo.getCategorias().Exists(item => item.Inscripciones.Count != 0))
                {
                    limpiarGrid();
                    cargarGrid();
                }
            }
            else
            {
                lblTorneo.Text = "No existen Torneos";
            }
        }

        //LIMPIA EL DGV
        public void limpiarGrid()
        {
            DtgvInscriptos.Rows.Clear();
            n = 0;
        }

        //CARGA EL DGV
        public void cargarGrid()
        {
            foreach(var categoria in torneo.getCategorias())
            {
                foreach(var inscriptos in categoria.Inscripciones)                                                //RECORREMOS LA LISTA DE PAREJAS
                {
                    n = DtgvInscriptos.Rows.Add();                                              //ADICIONAMOS NUEVO RENGLON

                    //CARGAMOS LOS DATOS DE LA PAREJA
                    DtgvInscriptos.Rows[n].Cells[0].Value = inscriptos.getJugador1().Nombre;
                    DtgvInscriptos.Rows[n].Cells[1].Value = inscriptos.getJugador2().Nombre;
                    DtgvInscriptos.Rows[n].Cells[2].Value = inscriptos.getJugador1().Localidad + ", " + inscriptos.getJugador2().Localidad;
                    DtgvInscriptos.Rows[n].Cells[3].Value = inscriptos.getJugador1().Categoria;
                }
            }
        }

        //SELECIONAR PAREJA DEL DGV
        private void DtgvInscriptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvIndice = e.RowIndex;
        }

        //OBTENER PAREJA DEL DGV
        private void seleccionarPareja()
        {
            if (dgvIndice != -1)
            {
                string nombre = DtgvInscriptos.Rows[dgvIndice].Cells[0].Value.ToString();
                foreach (var categoria in torneo.getCategorias())
                {
                    if(categoria.Inscripciones.Any(item => item.getJugador1().Nombre == nombre))
                    {
                        foreach(var _pareja in categoria.Inscripciones)
                        {
                            if(_pareja.getJugador1().Nombre == nombre) pareja = _pareja;
                        }
                    }
                    else pareja = null;
                }
            }
        }

        //ELIMINAR PAREJA
        private void eliminarPareja()
        {
            if (dgvIndice != -1)
            {
                string nombre = DtgvInscriptos.Rows[dgvIndice].Cells[0].Value.ToString() + ", " + DtgvInscriptos.Rows[dgvIndice].Cells[1].Value.ToString();
                if (MessageBox.Show("Estas Seguro que desea eliminar a la pareja " + nombre, "Eliminar Pareja", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    seleccionarPareja();
                    string categoria = pareja.getJugador1().Categoria;
                    DtgvInscriptos.Rows.RemoveAt(dgvIndice);
                    torneo.obtenerCategoria(categoria).Inscripciones.Remove(pareja);
                    n -= 1;
                    GuardarArchivo();
                }
            }
        }

    }//FIN FormInscriptos
}//FIN NAMESPACE
