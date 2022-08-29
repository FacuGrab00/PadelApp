using System;
using System.Collections.Generic;
using System.Text;

namespace padel_app_21
{
    [Serializable]
    public abstract class  Datos
    {
        //ATRIBUTOS
        string nombre;
        long telefono;

        //GETTERS SETTERS
        public string Nombre { get => nombre; set => nombre = value; }
        public long Telefono { get => telefono; set => telefono = value; }

        //CONSTRUCTOR
        public Datos(string nombre, long telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        //OVERRIDE
        public override string ToString()
        {
            return Nombre;
        }
    }
}
