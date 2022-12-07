using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Jugador
    {
        private int id;

        private string nombre;
        private Sexo sexo;
        private string clave;

        private int victorias;
        private int derrotas;
        private int abandonos;
        private int empates;

        public Jugador(string nombre, string clave, Sexo sexo, int id)
        {
            this.id = id;

            this.nombre = nombre;
            this.clave = clave;
            this.sexo = sexo;

            this.victorias = 0;
            this.derrotas = 0;
            this.abandonos = 0;
            this.empates = 0;
        }

        public Jugador(string nombre, string clave, Sexo sexo, int id, int victorias, int derrotas, int empates, int abandonos) : this(nombre, clave, sexo, id)
        {
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.abandonos = abandonos;
            this.empates = empates;
        }

        #region Setters y Getters
        public int ID 
        { 
            get { return this.id; } 
        }

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

        public int Empates
        {
            get { return this.empates; }
            set { this.empates = value; }
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
            return $"{this.id} {this.nombre}";
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
