using System;

namespace T3PR1
{
    public static class SistemaUtils
    {
        /// <summary>
        /// Llegeix un valor de tipus double des de la consola i valida que sigui correcte.
        /// </summary>
        /// <returns>El valor de tipus double introduït per l'usuari.</returns>
        public static double LlegirDoubleValid()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                MostrarMissatgeAmbColor(Missatges.MissatgeErrorTryParse, ConsoleColor.Red);
            }
            return input;
        }

        /// <summary>
        /// Llegeix un valor de tipus integer des de la consola i valida que sigui correcte.
        /// </summary>
        /// <returns>El valor de tipus integer introduït per l'usuari.</returns>
        public static int LlegirIntValid()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                MostrarMissatgeAmbColor(Missatges.MissatgeErrorTryParse, ConsoleColor.Red);
            }
            return input;
        }

        /// <summary>
        /// Llegeix un valor de tipus integer des de la consola, valida que sigui correcte i que estigui dins d'un rang específic.
        /// </summary>
        /// <param name="minim">El valor mínim acceptable.</param>
        /// <param name="maxim">El valor màxim acceptable.</param>
        /// <returns>El valor de tipus integer introduït per l'usuari que està dins del rang especificat.</returns>
        public static int LlegirIntValid(int minim, int maxim)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < minim || input > maxim)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Missatges.MissatgeErrorTryParseAmbRang, minim, maxim);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return input;
        }

        /// <summary>
        /// Mostra un missatge a la consola amb un color específic.
        /// </summary>
        /// <param name="missatge">El missatge a mostrar.</param>
        /// <param name="color">El color del text del missatge.</param>
        public static void MostrarMissatgeAmbColor(string missatge, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(missatge);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
