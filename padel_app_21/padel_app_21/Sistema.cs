using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace padel_app_21
{
    [Serializable]
    public class Sistema
    {
        //ATRIBUTOS
        public List<Jugador> Jugadores { get; set; }                                                        //LISTA QUE CONTIENE TODOS LOS JUGADRES A GUARDAR
        public List<Torneo> Torneos { get; set; }                                                           //LISTA QUE CONTIENE TODOS LOS TORNEOS A GUARDAR

        string direccion = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PadelApp"; //ME GENERA LA DIRECCION DE GUARDADO EN MISDOCUMENTOS/PADELAPP

        //CONSTRUCTOR
        public Sistema()
        {
            Jugadores = new List<Jugador>();
            Torneos = new List<Torneo>();
        }

        //GETTERS
        public string Direccion()
        {
            return direccion;
        }

        //SETTERS
        public void agregar(Torneo torneo)
        {
            Torneos.Add(torneo);
        }

        public void agregar(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

    }
}
