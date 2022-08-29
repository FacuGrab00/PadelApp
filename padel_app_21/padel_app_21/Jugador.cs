using System;
using System.Collections.Generic;
using System.Text;

namespace padel_app_21
{
    [Serializable]
    public class Jugador : Datos
    {
        //ATRIBUTOS
        string posicion;
        string localidad;
        string categoria;
        double puntos;
        int edad;
        int dni;

        //GETTERS SETTERS
        public string Posicion { get => posicion; set => posicion = value; }
        public string Localidad { get => localidad; set => localidad = value; } 
        public string Categoria { get => categoria; set => categoria = value; }
        public double Puntos { get => puntos; set => puntos = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dni { get => dni; set => dni = value; }
        //CONSTRUCTOR
        public Jugador(string nombre, long telefono,int dni,string posicion, string localidad, string categoria, double puntos, int edad) : base(nombre, telefono)
        {
            this.posicion = posicion;
            this.categoria = categoria;
            this.localidad = localidad;
            this.puntos = puntos;
            this.edad = edad;
            this.dni = dni;
        }
    }
}
