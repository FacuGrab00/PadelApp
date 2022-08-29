using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace padel_app_21
{
    [Serializable]
    public class Torneo : Datos
    {
        //ATRIBUTOS
        DateTime fechaInicio;
        double inscripcion;
        double premio;
        double puntos;
        byte maxParejas;
        List<Categoria> categorias;

        //CONSTRUCTOR
        public Torneo(string nombre, long telefono, DateTime fechaInicio, double inscripcion, double premio, byte maxParejas, double puntos) : base(nombre, telefono)
        {
            this.fechaInicio = fechaInicio;
            this.inscripcion = inscripcion;
            this.premio = premio;
            this.maxParejas = maxParejas;
            this.puntos = puntos;
            this.categorias = new List<Categoria>();
        }

        //GETTERS Y SETTERS
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public double Inscripcion { get => inscripcion; set => inscripcion = value; }
        public double Premio { get => premio; set => premio = value; }
        public double Puntos { get => puntos; set => puntos = value; }
        public byte MaxParejas { get => maxParejas; set => maxParejas = value; }
        public List<Categoria> getCategorias()
        {
            return categorias;
        }
        public void setCategorias(string categoria)
        {
            if(!categorias.Any(item => item.Nivel == categoria))
            {
                categorias.Add(new Categoria(categoria));
            }
        }

        
        //CREA UN STRING QUE CONTIENE TODAS LAS CATEGORIAS DEL TORNEO
        public string stringCategorias()
        {
            string cadena = "";
            foreach (Categoria categoria in categorias)
            {
                cadena += categoria.Nivel + " ";
            }

            return cadena;
        }

        //GET DE UNA CATEGORIA DEL LISTADO DE CATEGORIAS
        public Categoria obtenerCategoria(string nivel)
        {
            Categoria listado = null;
            foreach(var categoria in categorias)
            {
                if (categoria.Nivel == nivel) listado = categoria;
            }

            if(listado == null)
            {
                throw new Exception("La categoira que esta buscando no existe en este torneo");
            }
            return listado;
        }
    }
}
