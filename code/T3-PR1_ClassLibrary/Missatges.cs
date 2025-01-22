using System;

namespace T3PR1
{
    public static class Missatges
    {
        public const string MissatgeBenvinguda = "\r\n _____          _____                             _____       _       _   _                 \r\n|  ___|        |  ___|                           /  ___|     | |     | | (_)                \r\n| |__  ___ ___ | |__ _ __   ___ _ __ __ _ _   _  \\ `--.  ___ | |_   _| |_ _  ___  _ __  ___ \r\n|  __|/ __/ _ \\|  __| '_ \\ / _ \\ '__/ _` | | | |  `--. \\/ _ \\| | | | | __| |/ _ \\| '_ \\/ __|\r\n| |__| (_| (_) | |__| | | |  __/ | | (_| | |_| | /\\__/ / (_) | | |_| | |_| | (_) | | | \\__ \\\r\n\\____/\\___\\___/\\____/_| |_|\\___|_|  \\__, |\\__, | \\____/ \\___/|_|\\__,_|\\__|_|\\___/|_| |_|___/\r\n                                     __/ | __/ |                                            \r\n                                    |___/ |___/                                             \r\n";
        public const string OpcioUnMenuMissatge = "\n Iniciant la simulació... que comenci la màgia energètica!\n Quantes simulacions vols fer? ",
            OpcioDosValidMenuMissatge = "Aquí tens les teves simulacions. Atenció, podries acabar creant una nova central elèctrica! ",
            OpcioDosInvalidMenuMissatge = "Ah, vols veure el futur? Doncs encara no tenim ni una sol dada. Fes la primera simulació i comencem!\n",
            OpcioTresMenuMissatge = "Fins aviat! Torna quan vulguis il·luminar el teu dia amb simulacions",
            OpcioEquivocadaMenuMissatge = "Error: si us plau, introdueix un número vàlid.",
            MissatgeErrorTryParse = "Error: si us plau, introdueix un número vàlid: ",
            MissatgeErrorTryParseAmbRang = "Error: si us plau, introdueix un número vàlid entre {0} i {1}: ",
            EolicArgumentException = "La velocitat del vent ha de ser superior a 5 m/s! ",
            HidroelectricArgumentException = "El cabal ha de ser major a 20 m^3! ",
            SolarArgumentException = "Les hores de sol han de ser superiors a 1! ",
            FinalSimulacions = "Simulacions finalitzades amb èxit! \n",
            SimulacioAcabada = "Aquesta simulació té una energia total de {0} kWh \n";

        /// <summary>
        /// Mostra el missatge de benvinguda en color groc a la consola.
        /// </summary>
        public static void MostrarMissatgeBenvinguda()
        {
            SistemaUtils.MostrarMissatgeAmbColor(Missatges.MissatgeBenvinguda, ConsoleColor.Yellow);
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Mostra el menú principal a la consola amb les opcions disponibles.
        /// </summary>
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
    }
}
