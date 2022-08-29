using System;
using System.Collections.Generic;
using System.Text;

namespace padel_app_21
{
    [Serializable]
    public class Categoria
    {
        string nivel;
        List<Pareja> inscripciones;

        public Categoria(string nivel)
        {
            this.nivel = nivel;
            inscripciones = new List<Pareja>();
        }

        public string Nivel { get => nivel; set => nivel = value; }
        public List<Pareja> Inscripciones { get => inscripciones; set => inscripciones = value; }

        public override string ToString()
        {
            return nivel;
        }
    }
}
