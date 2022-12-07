using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibreriaDeClases
{
    public abstract class BaseDeDatos<T>
    {
        protected static string cadena_conexion;
        protected SqlConnection conexion;
        protected SqlCommand comando;
        protected SqlDataReader lector;

        static BaseDeDatos()
        {
            BaseDeDatos<T>.cadena_conexion = @"Server = DESKTOP-QLNMTV8;Database=Generala;Trusted_Connection=true;";
        }

        public BaseDeDatos()
        {
            this.conexion = new SqlConnection(BaseDeDatos<T>.cadena_conexion);
        }

        public bool ProbarConexion()
        {
            bool retorno = true;

            try
            {
                this.conexion.Open();
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

        public abstract List<T> Traer();
        public abstract bool Agregar(T objeto);
        public virtual bool Modificar(T objeto)
        {
            return true;
        }
    }
}
