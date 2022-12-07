using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public static class Reglas
    {
        private static List<string> reglas;
        private static JSON serializador;

        static Reglas()
        {
            Reglas.reglas = new List<string>();
            Reglas.serializador = new JSON();
        }

        public static void CrearReglas()
        {
            string regla1 = "Cada jugador puede hacer hasta tres tiros por turno y debe marcar una jugada obligatoriamente. \n" +
                "El turno comienza tirando los cinco dados. \n" +
                "Al final de cada tiro, el jugador puede apartar los dados que crea util para formar la mejor jugada. \n" +
                "No es obligatorio, puede volver a lanzar los cinco dados si lo prefiere.\n" +
                "Dentro de los tres tiros disponibles, el jugador debe marcar una jugada dentro de las disponibles.\n \n" +
                "Jugadas: Existen dos tipos de jugadas diferentes, las simples y las mayores.\n \n";

            string regla2 = "Simples: Las simples son las que corresponden al valor de un numero. \n" +
                "El valor de estas es el total de dados donde aparece dicho numero multiplicado por el numero.\n" +
                "Ejemplo: tres 5 valen 15 puntos para el cinco; dos 3 vale 6 puntos para el tres. \n \n" +
                "Mayores: Estas jugadas estan formadas por una combinacion especifica de dados.\n" +
                "Estas son:\n \n";

            string regla3 = "ESCALERA: las combinaciones posibles son 1 - 2 - 3 - 4 - 5, 2 - 3 - 4 - 5 - 6.\n \n" +
                "FULL: 3 dados del mismo numero y un par. Vale 30 puntos.\n \n" +
                "POKER: 4 dados de un mismo numero y uno diferente. Vale 40 puntos.\n \n" +
                "GENERALA: 5 dados de un mismo numero.Vale 50 puntos.\n \n" +
                "GENERALA REAL: igual a la generala, pero con el numero 1.Vale 60 puntos.\n \n";

            string regla4 = "Jugadas mayores servidas: se considera una jugada servida si con el primer tiro se forma una jugada mayor. " +
                "En estos casos, si se marca la jugada, se le suman 5 puntos extras.\n \n" +
                "Puntaje: los jugadores no necesitan marcar una jugada hasta el ultimo tiro de su turno." +
                "Una vez marcada una jugada, no puede volver a marcarse otra vez.\n \n" +
                "Una vez completada las 4 rondas, el jugador con mas puntos resultara ganador.";

            Reglas.reglas.Add(regla1);
            Reglas.reglas.Add(regla2);
            Reglas.reglas.Add(regla3);
            Reglas.reglas.Add(regla4);
        }

        public static bool GuardarReglas()
        {
            bool retorno = false;

            if(Reglas.serializador.Serializar(Reglas.reglas))
            {
                retorno = true;
            }

            return retorno;
        }
        
        public static List<string> CargarReglas()
        {
            return (List<string>)Reglas.serializador.Deserializar();
        }
    }
}
