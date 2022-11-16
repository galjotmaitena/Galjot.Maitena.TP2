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

        public Partida(Jugador unJugador, Jugador otroJugador)
        {
            this.jugadores = new Jugador[2];
            this.puntos = new Puntos[2];
            this.turnos = new Queue<Turno>();

            this.jugadores[0] = unJugador;
            this.jugadores[1] = otroJugador;

            this.CargarTurnos();
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

        public string VerGanador()
        {
            string resultado;

            if(puntos[0].CalcularTotal() == puntos[1].CalcularTotal())
            {
                resultado = "Empate";
            }
            else
            {
                if(puntos[0].CalcularTotal() > puntos[1].CalcularTotal())
                {
                    resultado = this.jugadores[0].Nombre;
                    this.ganador = this.jugadores[0];
                }
                else
                {
                    resultado = this.jugadores[1].Nombre;
                    this.ganador = this.jugadores[1];
                }             
            }

            return resultado;
        }

        private void CargarTurnos()
        {
            for (int i = 0; i < 6; i++)
            {
                this.TurnoJugador.Enqueue(new Turno());
            }
        }
    }
}
