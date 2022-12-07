using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibreriaDeClases
{
    class JSON : ISerializacion
    {
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;

        static JSON()
        {
            JSON.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            JSON.path += "\\Reglas.json";
        }

        public bool Serializar(Object lista)
        {
            bool retorno = false;
            List<string> listaAuxiliar = (List<string>)lista;

            try
            {
                using (JSON.writer = new StreamWriter(JSON.path))
                {

                    string json = JsonSerializer.Serialize(listaAuxiliar);

                    JSON.writer.Write(json);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        public Object Deserializar()
        {
            List<string> aux = new List<string>();

            try
            {
                using (JSON.reader = new StreamReader(JSON.path))
                {
                    string json = JSON.reader.ReadToEnd();

                    aux = JsonSerializer.Deserialize<List<string>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (Object)aux;
        }
    }
}
