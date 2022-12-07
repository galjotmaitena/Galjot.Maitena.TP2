using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaDeClases
{
    public class Turno
    {
        private int tiradas;
        private List<int> dados = new List<int>();

        public Turno()
        {
            this.dados = AgregarValores(5);
            this.tiradas = 3;
        }

        #region Setters y Getters
        public int Tiradas
        {
            get { return this.tiradas; }
            set { this.tiradas = value; }
        }

        public List<int> Dados
        {
            get { return this.dados; }
            set { this.dados = value; }
        }

        #endregion

        /// <summary>
        /// Designa numeros random entre el 1 y el 6, que luego seran designados a los dados.
        /// </summary>
        /// <param name="cantidadDados"></param> Cantidad de numeros que deben ser asignados.
        /// <returns></returns> Lista de numeros designados.
        public static List<int> AgregarValores(int cantidadDados)
        {
            Random numeros = new Random();
            List<int> listaNumeros = new List<int>();

            for(int i = 0; i < cantidadDados; i ++)
            {
                listaNumeros.Add(numeros.Next(1, 7));
            }

            return listaNumeros;
        }
    }
}
