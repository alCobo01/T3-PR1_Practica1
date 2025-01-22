using System;

namespace T3PR1
{
    public static class SistemaUtils
    {
        public static double LlegirDoubleValid()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                MostrarMissatgeError(Missatges.MissatgeErrorTryParse, ConsoleColor.Red);
            }
            return input;
        }

        public static int LlegirIntValid()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                MostrarMissatgeError(Missatges.MissatgeErrorTryParse, ConsoleColor.Red);
            }
            return input;
        }

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

        public static void MostrarMissatgeError(string missatge, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(missatge);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
