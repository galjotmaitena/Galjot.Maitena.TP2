using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibreriaDeClases
{
    public static class Archivos
    {
        public static StreamWriter sw;
        public static StreamReader sr;
        public static string path;

        static Archivos()
        {
            if (!Directory.Exists("..\\Partidas"))
            {
                Directory.CreateDirectory("..\\Partidas");
            }

            Archivos.path = "..\\Partidas\\partidas.txt";
        }

        public static bool AgregarAlArchivo(List<Partida> lista)
        {
            bool agrego = false;

            try
            {
                Archivos.sw = new StreamWriter(Archivos.path, true);

                foreach (Partida item in lista)
                {
                    Archivos.sw.WriteLine(item.ToString());
                }

                agrego = true;
            }
            catch (Exception)
            {
                agrego = false;
            }
            finally
            {
                if (Archivos.sw != null)
                {
                    Archivos.sw.Close();
                }   
            }

            return agrego;
        }

        public static bool SobreescribirElArchivo(List<Partida> lista)
        {
            bool agrego = false;

            try
            {
                using (Archivos.sw = new StreamWriter(Archivos.path))
                {
                    foreach (Partida item in lista)
                    {
                        Archivos.sw.WriteLine(item.ToString());
                    }
                }

                agrego = true;
            }
            catch (Exception)
            {
                agrego = false;
            }

            return agrego;
        }

        public static List<Partida> LeerArchivoLineaALinea()
        {
            string retorno = "";
            List<Partida> lista = new List<Partida>();
            Sexo auxiliar1 = 0;
            Sexo auxiliar2 = 0;
            Sexo auxiliar3 = 0;

            string[] partida = null;

            try
            {
                using (Archivos.sr = new StreamReader(Archivos.path))
                {
                    while ((retorno = Archivos.sr.ReadLine()) != null)
                    {
                        string[] datosJugadores = null;

                        partida = retorno.Split(" \n ");

                        
                            datosJugadores = partida[0].Split(" ");

                            if (datosJugadores[2] == "Hombre")
                            {
                                auxiliar1 = Sexo.Hombre;
                            }

                            if (datosJugadores[6] == "Hombre")
                            {
                                auxiliar2 = Sexo.Hombre;
                            }

                            if (datosJugadores[12] == "Hombre")
                            {
                                auxiliar3 = Sexo.Hombre;
                            }

                            Partida p = new Partida(new Jugador(datosJugadores[0], datosJugadores[1], auxiliar1, int.Parse(datosJugadores[3])),
                                new Jugador(datosJugadores[4], datosJugadores[5], auxiliar2, int.Parse(datosJugadores[7])),
                                int.Parse(datosJugadores[8]), int.Parse(datosJugadores[9]),
                                new Jugador(datosJugadores[10], datosJugadores[11], auxiliar3, int.Parse(datosJugadores[13])));

                            lista.Add(p);
                        
                    }  
                }
            }
            catch (Exception e)
            {
                
            }

            return lista;
        }

        public static string LeerArchivoHastaElFinal()
        {
            string retorno = "";
            try
            {
                using (Archivos.sr = new StreamReader(Archivos.path))
                {
                    retorno = Archivos.sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                retorno = e.Message;
            }

            return retorno;
        }
    }
}
