using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace padel_app_21
{
    public partial class CrearTorneo : Form
    {
        public CrearTorneo()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        Torneo torneo;

        //BOTON CONFIRMAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            crearTorneo();
        }

        //CREAR TORNEO
        private void crearTorneo()
        {
            //ATRIBUTOS PARA TORNEO
            string nombre;
            long telefono;
            DateTime fechaInicio;
            double inscripcion;
            double premio;
            byte maxParejas;
            double puntos;

            //BANDERA
            bool bandera = false;

            //VALIDACIÓN DE LOS PARAMETROS
            bandera = Validar(bandera);

            //VALIDACIÓN
            if (bandera == true)
            {
                //TOMAMOS LOS VALORES DEL FORMULARIO 
                nombre = txtNombre.Text;
                telefono = Convert.ToInt64(txtTelefono.Text);
                fechaInicio = dtpFecha.Value;
                inscripcion = Convert.ToDouble(txtInscripcion.Text);
                premio = Convert.ToDouble(txtPremio.Text);
                maxParejas = Convert.ToByte(numericMaxParejas.Value);
                puntos = Convert.ToDouble(txtPuntos.Text);

                //CREAMOS TORNEO
                torneo = new Torneo(nombre, telefono, fechaInicio, inscripcion, premio, maxParejas, puntos);

                //CREAMOS LAS LISTAS PARA LAS INSCRIPCIONES
                crearCategorias();

                //COMUNICACION CON VENTANA CREADORA
                FormTorneos formTorneo = Owner as FormTorneos;

                //PASAJE DEL NUEVO TORNEO
                formTorneo.setTorneo(torneo);

                //LIMPIAR CASILLEROS
                this.Close();
            }
        }

        //CARGO LOS DATOS DEL TORNEO PARA MODIFICAR
        public void cargarTorneo()
        {
            FormTorneos formTorneos = Owner as FormTorneos;
            Torneo torneo = formTorneos.getTorneo();
            txtNombre.Text = torneo.Nombre;
            txtTelefono.Text = torneo.Telefono.ToString();
            dtpFecha.Value = torneo.FechaInicio;
            txtInscripcion.Text = torneo.Inscripcion.ToString();
            txtPremio.Text = torneo.Premio.ToString();
            numericMaxParejas.Value = torneo.MaxParejas;
            txtPuntos.Text = torneo.Puntos.ToString();

            foreach(var categoria in torneo.getCategorias())
            {
                if(cbPrincipiante.Text == categoria.Nivel)
                {
                    cbPrincipiante.Checked = true;
                }

                if (cbOctava.Text == categoria.Nivel)
                {
                    cbOctava.Checked = true;
                }

                if (cbSeptima.Text == categoria.Nivel)
                {
                    cbSeptima.Checked = true;
                }

                if (cbSexta.Text == categoria.Nivel)
                {
                    cbSexta.Checked = true;
                }

                if (cbQuinta.Text == categoria.Nivel)
                {
                    cbQuinta.Checked = true;
                }

                if (cbCuarta.Text == categoria.Nivel)
                {
                    cbCuarta.Checked = true;
                }

                if (cbTercera.Text == categoria.Nivel)
                {
                    cbTercera.Checked = true;
                }

                if (cbSegunda.Text == categoria.Nivel)
                {
                    cbSegunda.Checked = true;
                }

                if (cbPrimera.Text == categoria.Nivel)
                {
                    cbPrimera.Checked = true;
                }
            }
        }

        //VALIDACIÓN DE PARAMETROS
        private bool Validar(bool bandera)
        {
            //Nombre
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "ERROR! campo vacio");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            //Telefono
            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "ERROR! campo vacio");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            //Precio Inscripción
            if (txtInscripcion.Text == "")
            {
                errorProvider1.SetError(txtInscripcion, "ERROR! campo vacio");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            //Precio Premio
            if (txtPremio.Text == "")
            {
                errorProvider1.SetError(txtPremio, "ERROR! campo vacio");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            //Categorias
            if (!Controls.OfType<CheckBox>().Any(item => item.Checked == true))
            {
                errorProvider1.SetError(cbPrimera, "ERROR! debes seleccionar al menos una categoria");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            //Maximo Parejas
            if (numericMaxParejas.Value == 0)
            {
                errorProvider1.SetError(numericMaxParejas, "ERROR! Por favor selecciona un maximo de parejas");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            //Puntos
            if (txtPuntos.Text == "")
            {
                errorProvider1.SetError(txtPuntos, "ERROR! campo vacio");
                bandera = false;
            }
            else
            {
                bandera = true;
            }

            return bandera;
        }

        //CREO LAS LISTAS DE JUGADORES PARA CADA CATEGORIA
        private void crearCategorias()
        {
            if (cbPrincipiante.Checked == true)
            {
                torneo.setCategorias(cbPrincipiante.Text);
            }

            if (cbOctava.Checked == true)
            {
                torneo.setCategorias(cbOctava.Text);
            }

            if (cbSeptima.Checked == true)
            {
                torneo.setCategorias(cbSeptima.Text);
            }

            if (cbSexta.Checked == true)
            {
                torneo.setCategorias(cbSexta.Text);
            }

            if (cbQuinta.Checked == true)
            {
                torneo.setCategorias(cbQuinta.Text);
            }

            if (cbCuarta.Checked == true)
            {
                torneo.setCategorias(cbCuarta.Text);
            }

            if (cbTercera.Checked == true)
            {
                torneo.setCategorias(cbTercera.Text);
            }

            if (cbSegunda.Checked == true)
            {
                torneo.setCategorias(cbSegunda.Text);
            }

            if (cbPrimera.Checked == true)
            {
                torneo.setCategorias(cbPrimera.Text);
            }
        }

        //BOTON CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //EVENTO PRESIONAR TECLAS | IMPIDO EL INGRESO DE LETRAS A LOS TEXTBOXS NUMERICOS
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }


        //EVENTO MODIFICAR TEXTO | LIMPIO EL ERROR EN CASO DE EXISTIR
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }


        //EVENTO PRESIONAR TECLAS | IMPIDO EL INGRESO DE NUMEROS A LOS TEXTBOXS
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        //EVENTO CAMBIO(CHECKBOX) COMPRUEBO LA CANTIDAD DE CHECKBOX SELECCIONADOS
        private void cbPrincipiante_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }


    }//FIN CrearTorneo
}//FIN NAMESPACE

