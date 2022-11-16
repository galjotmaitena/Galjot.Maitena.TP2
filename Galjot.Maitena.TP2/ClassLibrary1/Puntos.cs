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
        #endregion

        public  int CalcularTotal()
        {
            return  this.uno + this.dos + this.tres + this.cuatro + this.cinco + this.seis + this.escalera +
                    this.full + this.poker + this.generala + this.generalaReal;
        }

        public int CalcularJugadasSimples(int numero, int cantidadDados)
        {
            return numero * cantidadDados;
        }

        public Jugada CalcularJugadasMayores(List<int> numeros, int puntosExtra)
        {//si fue en la primer tirada, 5p extra, sino 0
            int[] cantidades = new int[5];
            Jugada retorno = Jugada.Simple;

            for (int i = 0; i < cantidades.Length; i++)
            {
                cantidades[i] = this.CalcularCantidadIguales(i + 1, numeros);
            }

            for (int i = 0; i < cantidades.Length; i++)
            {
                for (int j = i + 1; j < cantidades.Length; j++)
                {
                    if(cantidades[i] == 3 && cantidades[j] == 2 || cantidades[i] == 2 && cantidades[j] == 3)
                    {
                        retorno = Jugada.Full;
                        break;
                    }
                }

                if (cantidades[i] == 4)
                {
                    retorno = Jugada.Poker;
                }
                else
                {
                    if (cantidades[i] == 5)
                    {
                        retorno = Jugada.Generala;
                    }
                }
            }
            
            return retorno;
        }

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

        public int CalcularPuntos(Jugada unaJugada)
        {
            int retorno = 0;

            switch (unaJugada)
            {
                case Jugada.Escalera:
                    retorno = 20;
                    //puntos.escalera = 20;
                    break;
                case Jugada.Full:
                    retorno = 30;
                    //puntos.full = 30;
                    break;
                case Jugada.Poker:
                    retorno = 40;
                    //puntos.poker = 40;
                    break;
                case Jugada.Generala:
                    retorno = 50;
                    //puntos.generala = 50;
                    break;
                case Jugada.GeneralaReal:
                    retorno = 60;
                    //puntos.generalaReal = 60;
                    break;
                default:
                    break;
            }

            return retorno;
        }
    }
}
