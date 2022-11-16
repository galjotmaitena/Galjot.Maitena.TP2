using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Jugador
    {
        private string nombre;
        private Sexo sexo;
        private string clave;

        private int victorias;
        private int derrotas;
        private int abandonos;

        public Jugador(string nombre, string clave, Sexo sexo)
        {
            this.nombre = nombre;
            this.clave = clave;
            this.sexo = sexo;

            this.victorias = 0;
            this.derrotas = 0;
            this.abandonos = 0;
        }

        #region Setters y Getters
        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Clave
        {
            get { return this.clave; }
        }

        public int Victorias
        {
            get { return this.victorias; }
            set { this.victorias = value; }
        }

        public int Derrotas
        {
            get { return this.derrotas; }
            set { this.derrotas = value; }
        }

        public int Abandonos
        {
            get { return this.abandonos; }
            set { this.abandonos = value; }
        }

        public Sexo Sexo
        {
            get { return this.sexo; }
        }
        #endregion

        public static bool operator ==(Jugador unJugador, Jugador otroJugador)
        {
            return unJugador.nombre == otroJugador.nombre && unJugador.clave == otroJugador.clave;
        }

        public static bool operator !=(Jugador unJugador, Jugador otroJugador)
        {
            return !(unJugador == otroJugador);
        }

        public override string ToString()
        {
            return $"{this.nombre} {this.clave} {this.sexo}";
        }

        public override bool Equals(object obj)
        {
            if(obj is Jugador)
            {
                return this == ((Jugador)obj);
            }
            return false;
        }

        //**************************************************************

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
