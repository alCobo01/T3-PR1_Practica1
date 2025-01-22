using System;

namespace T3PR1
{
    public static class SistemaUtils
    {
        public static void MostrarMissatgeBenvinguda()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Missatges.MissatgeBenvinguda);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void MostrarMenu()
        {
            const string BenvingutMissatge = "Benvingut a EcoEnergy Solutions! Escull una opció:";
            const string IniciarSimulacioOption = "1. Iniciar simulació";
            const string VeureInformesOption = "2. Veure informes de simulacions";
            const string SortirOption = "3. Sortir";
            const string EscullOpcioMissatge = "Quina opció vols escollir? (escriu un número): ";

            Console.WriteLine(BenvingutMissatge);
            Console.WriteLine(IniciarSimulacioOption);
            Console.WriteLine(VeureInformesOption);
            Console.WriteLine(SortirOption);
            Console.Write(EscullOpcioMissatge);
        }

        public static double LlegirNumeroValid()
        {
            const string MissatgeError = "Error: si us plau, introdueix un número vàlid entre 1 i 3.";

            double input;
            while (!double.TryParse(Console.ReadLine(), out input) || input < 1 || input > 3)
            {
                Console.Write(MissatgeError);
            }
            return input;
        }
    }
}
