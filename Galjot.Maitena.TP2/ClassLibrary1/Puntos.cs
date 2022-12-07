using System;
using System.Collections.Generic;

namespace LibreriaDeClases
{
    public class Puntos
    {
        private int uno;
        private int dos;
        private int tres;
        private int cuatro;
        private int cinco;
        private int seis;
        private int escalera;
        private int full;
        private int poker;
        private int generala;
        private int generalaReal;

        public Puntos()
        {
            this.uno = 0;
            this.dos = 0;
            this.tres = 0;
            this.cuatro = 0;
            this.cinco = 0;
            this.seis = 0;
            this.escalera = 0;
            this.full = 0;
            this.poker = 0;
            this.generala = 0;
            this.generalaReal = 0;
        }

        #region Setters y Getters
        public int Uno
        {
            set { this.uno = value; }
        }

        public int Dos
        {
            set { this.dos = value; }
        }

        public int Tres
        {
            set { this.tres = value; }
        }

        public int Cuatro
        {
            set { this.cuatro = value; }
        }

        public int Cinco
        {
            set { this.cinco = value; }
        }

        public int Seis
        {
            set { this.seis = value; }
        }

        public int Escalera
        {
            set { this.escalera = value; }
        }

        public int Full
        {
            set { this.full = value; }
        }

        public int Poker
        {
            set { this.poker = value; }
        }

        public int Generala
        {
            set { this.generala = value; }
        }

        public int GeneralaReal
        {
            set { this.generalaReal = value; }
        }
        #endregion

        /// <summary>
        /// Suma los puntos de todas las jugadas y los retorna.
        /// </summary>
        /// <returns></returns> retorna el total de los puntos.
        public  int CalcularTotal()
        {
           return this.uno + this.dos + this.tres + this.cuatro + this.cinco + this.seis + this.escalera +
                    this.full + this.poker + this.generala + this.generalaReal + 0; ;
        }

        /// <summary>
        /// Evalua que tipo de juagada se tiene seleccionada.
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns></returns> Retorna el tipo de jugada.
        public Jugada CalcularJugadasMayores(List<int> numeros)
        {
            int[] cantidades = new int[6];
            Jugada retorno = Jugada.Simple;

            for (int i = 0; i < cantidades.Length; i++)
            {
                cantidades[i] = this.CalcularCantidadIguales(i + 1, numeros);
            }

            if(!(cantidades[1] == 0 || cantidades[2] == 0 || cantidades[3] == 0 || cantidades[4] == 0))
            {
                retorno = Jugada.Escalera;
            }
            else
            {
                for (int i = 0; i < cantidades.Length; i++)
                {
                    switch (cantidades[i])
                    {
                        case 4:
                            retorno = Jugada.Poker;
                            break;
                        case 5:
                            retorno = Jugada.Generala;
                            break;
                        default:
                            for (int j = i + 1; j < cantidades.Length; j++)
                            {
                                if (cantidades[i] == 3 && cantidades[j] == 2 || cantidades[i] == 2 && cantidades[j] == 3)
                                {
                                    retorno = Jugada.Full;
                                    break;
                                }
                            }
                            break;
                    }
                }

                if(cantidades[0] == 5)
                {
                    retorno = Jugada.GeneralaReal;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Calcula la cantidad de dados iguales que tengo seleccionados.
        /// </summary>
        /// <param name="numero"></param> El numero que se esta buscando.
        /// <param name="lista"></param> La lista en la que se buscaran dados con ese mismo numero.
        /// <returns></returns> Retorna la cantidad de dados encontrados.
        public int CalcularCantidadIguales(int numero, List<int> lista)
        {
            int cantidad = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i] == numero)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        /// <summary>
        /// Calcula cuantos puntos corresponden a cada jugada.
        /// </summary>
        /// <param name="unaJugada"></param>  La jugada en la que se quiere anotar.
        /// <param name="puntosExtras"></param> 0 en caso de que no haya sido la primer tirada, 5 en caso de que si
        /// <returns></returns> retorna el total de puntos.
        public int CalcularPuntos(Jugada unaJugada, int puntosExtras)
        {
            int retorno = 0;

            switch (unaJugada)
            {
                case Jugada.Escalera:
                    retorno = 20 + puntosExtras;
                    break;
                case Jugada.Full:
                    retorno = 30 + puntosExtras;
                    break;
                case Jugada.Poker:
                    retorno = 40 + puntosExtras;
                    break;
                case Jugada.Generala:
                    retorno = 50 + puntosExtras;
                    break;
                case Jugada.GeneralaReal:
                    retorno = 60 + puntosExtras;
                    break;
            }

            return retorno;
        }
    }
}
