using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Partida
    {
        private Jugador[] jugadores;
        private Puntos[] puntos;
        private Queue<Turno> turnos;

        private Jugador ganador;

        private int[] totalPuntos;

        public Partida(Jugador unJugador, Jugador otroJugador)
        {
            this.jugadores = new Jugador[2];
            this.puntos = new Puntos[2];
            this.turnos = new Queue<Turno>();
            this.totalPuntos = new int[2];

            this.jugadores[0] = unJugador;
            this.jugadores[1] = otroJugador;

            this.puntos[0] = new Puntos();
            this.puntos[1] = new Puntos();

            this.CargarTurnos(8);
        }

        public Partida(Jugador unJugador, Jugador otroJugador, int puntosJ1, int puntosJ2, Jugador ganador) : this(unJugador, otroJugador)
        {
            this.jugadores[0] = unJugador;
            this.jugadores[1] = otroJugador;

            this.totalPuntos[0] = puntosJ1;
            this.totalPuntos[1] = puntosJ2;

            this.ganador = ganador;
        }

        #region Setters y Getters
        public Jugador[] Jugadores
        {
            get { return this.jugadores; }
        }

        public Puntos[] Puntos
        {
            get { return this.puntos; }
            set { this.puntos = value; }
        }

        public int[] Total
        {
            get { return this.totalPuntos; }
            set { this.totalPuntos = value; }
        }

        public Jugador Ganador
        {
            get { return this.ganador; }
        }

        public Queue<Turno> TurnoJugador
        {
            get { return this.turnos; }
            set { this.turnos = value; }
        }
        #endregion

        /// <summary>
        /// Compara los puntajes de los jugadores, para asi determinar si este gano, perdio o empato.
        /// </summary>
        /// <returns></returns> Retorna o el nombre del ganador, o EMPATE.
        public string ObtenerGanador()
        {
            string resultado;

            if(this.puntos[0].CalcularTotal() == this.puntos[1].CalcularTotal())
            {
                resultado = "EMPATE";

                this.jugadores[0].Empates++;
                this.jugadores[1].Empates++;
            }
            else
            {
                if(this.puntos[0].CalcularTotal() > this.puntos[1].CalcularTotal())
                {
                    resultado = $"El ganador es {this.jugadores[0].Nombre}!!!";

                    this.ganador = this.jugadores[0];

                    this.jugadores[0].Victorias++;
                    this.jugadores[1].Derrotas++;
                }
                else
                {
                    resultado = $"El ganador es {this.jugadores[1].Nombre}!!!";

                    this.ganador = this.jugadores[1];

                    this.jugadores[1].Victorias++;
                    this.jugadores[0].Derrotas++;
                }             
            }

            return resultado;
        }

        /// <summary>
        /// Carga los turnos que tendra la partida
        /// </summary>
        /// <param name="len"></param> Cantidad de turnos a cargar
        private void CargarTurnos(int len)
        {
            for (int i = 0; i < len; i++)
            {
                this.TurnoJugador.Enqueue(new Turno());
            }
        }

        public override string ToString()
        {
            if(this.ganador is not null)
            {
                return $"{this.Jugadores[0].Nombre} {this.Jugadores[0].Clave} {this.Jugadores[0].Sexo} {this.Jugadores[0].ID}" +
                $" {this.Jugadores[1].Nombre} {this.Jugadores[1].Clave} {this.Jugadores[1].Sexo} {this.Jugadores[1].ID} " +
                $"{this.totalPuntos[0]} {this.totalPuntos[1]} " +
                $"{this.ganador.Nombre} {this.ganador.Clave} {this.ganador.Sexo} {this.ganador.ID}";
            }
            else
            {
                return $"({this.Jugadores[0].ID}) {this.Jugadores[0].Nombre} -- " +
                $"({this.Jugadores[1].ID}) {this.Jugadores[1].Nombre}";
            }
        }
    }
}
