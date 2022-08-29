using System;
using System.Collections.Generic;
using System.Text;

namespace padel_app_21
{
    [Serializable]
    public class Pareja
    {
        //ATRIBUTOS
        Jugador jugador1;
        Jugador jugador2;

        //CONSTRUCTOR
        public Pareja(Jugador jugador1, Jugador jugador2)
        {
            if(jugador1.Categoria == jugador2.Categoria)
            {
                if (jugador1 != jugador2)
                {
                    this.jugador1 = jugador1;
                    this.jugador2 = jugador2;
                }
                else
                {
                    throw new Exception("No se puede crear una pareja con una sola persona, por favor seleccione dos jugadores diferentes");
                }
            }
            else
            {
                throw new Exception("Los jugadores no pertenecen a la misma categoria");
            }
        }

        public Jugador getJugador1()
        {
            return jugador1;
        }

        public Jugador getJugador2()
        {
            return jugador2;
        }
    }
}
