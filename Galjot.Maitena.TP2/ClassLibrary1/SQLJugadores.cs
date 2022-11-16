using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaDeClases
{
    public class SQLJugadores :BaseDeDatos<Jugador>
    {
        private List<Jugador> lista;

        public SQLJugadores()
        {
            this.lista = new List<Jugador>();
        }

        public override List<Jugador> Traer()
        {
            List<Jugador> listaJugadores = new List<Jugador>();

            try
            {
                base.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM jugadores";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Jugador unJugador;

                    string nombre;
                    Sexo sexo = 0;
                    string clave;

                    nombre = this.lector["nombre"].ToString();
                    clave = this.lector["clave"].ToString();

                    switch (this.lector["sexo"])
                    {
                        case "Hombre":
                            sexo = Sexo.Hombre;
                            break;
                        case "Mujer":
                            sexo = Sexo.Mujer;
                            break;
                    }

                    unJugador = new Jugador(nombre, clave, sexo);

                    listaJugadores.Add(unJugador);
                }
            }
            catch (Exception)
            {
                listaJugadores = null;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return listaJugadores;
        }

        public override bool Agregar(Jugador dato)
        {
            bool retorno = true;
            Jugador auxiliar = (Jugador)dato;

            try
            {
                string sql = "INSERT INTO jugadores (nombre, clave, sexo, victorias, derrotas, abandonos) VALUES(";
                sql = sql + "'" + auxiliar.Nombre + "','" + auxiliar.Clave + "','" + auxiliar.Sexo.ToString() + "','" +
                    auxiliar.Victorias + "','" + auxiliar.Derrotas + "','" + auxiliar.Abandonos + "')";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }
    }
}
