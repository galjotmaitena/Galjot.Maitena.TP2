using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaDeClases 
{
    public class ListaJugadores : BaseDeDatos<Jugador> 
    {
        private List<Jugador> lista;
        private int ultimoId;

        public ListaJugadores()
        {
            this.lista = new List<Jugador>();
            this.ultimoId = 0;
        }

        public int UltimoID 
        { 
            get 
            { 
                return this.ultimoId; 
            } 
        }

        /// <summary>
        /// Trae a todos los jugadores y los guarda en una lista que luego se rotrnara.
        /// </summary>
        /// <returns></returns> Retorna una lista con los jugadores.
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
                    int id = 0;
                    int victorias = 0;
                    int derrotas = 0;
                    int empates = 0;
                    int abandonos = 0;

                    nombre = this.lector["nombre"].ToString();
                    clave = this.lector["clave"].ToString();
                    id = (int)this.lector["id"];

                    switch (this.lector["sexo"])
                    {
                        case "Hombre":
                            sexo = Sexo.Hombre;
                            break;
                        case "Mujer":
                            sexo = Sexo.Mujer;
                            break;
                    }

                    victorias = (int)this.lector["victorias"];
                    derrotas = (int)this.lector["derrotas"];
                    empates = (int)this.lector["tablas"];
                    abandonos = (int)this.lector["abandonos"];

                    unJugador = new Jugador(nombre, clave, sexo, id, victorias, derrotas, empates, abandonos);
                    this.ultimoId = id;
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

        /// <summary>
        /// Agrega un jugador nuevo al SQL
        /// </summary>
        /// <param name="dato"></param> Jugador que se desea agregar.
        /// <returns></returns> True/False dependiendo de si la operacion fue exitosa.
        public override bool Agregar(Jugador dato)
        {
            bool retorno = true;
            Jugador auxiliar = (Jugador)dato;

            try
            {
                string sql = "INSERT INTO jugadores (nombre, clave, sexo, victorias, derrotas, abandonos,tablas) VALUES(";
                sql = sql + "'"+ auxiliar.Nombre + "','" + auxiliar.Clave + "','" + auxiliar.Sexo.ToString() + "','" +
                    auxiliar.Victorias + "','" + auxiliar.Derrotas + "','" + auxiliar.Abandonos + "','" + auxiliar.Empates +"')";

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

        public override bool Modificar(Jugador dato)
        {
            bool retorno = true;
            Jugador auxiliar = (Jugador)dato;

            try
            {
                string sql = $"UPDATE jugadores SET victorias='{auxiliar.Victorias}', derrotas='{auxiliar.Derrotas}', abandonos='{auxiliar.Abandonos}'" +
                    $", tablas='{auxiliar.Empates}'" +
                    $" WHERE id = {auxiliar.ID}";

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
