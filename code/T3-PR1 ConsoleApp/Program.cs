using System;

namespace T3PR1
{
    public class Program
    {
        public static void Main()
        {
            const string MissatgeBenvinguda = "\r\n _____          _____                             _____       _       _   _                 \r\n|  ___|        |  ___|                           /  ___|     | |     | | (_)                \r\n| |__  ___ ___ | |__ _ __   ___ _ __ __ _ _   _  \\ `--.  ___ | |_   _| |_ _  ___  _ __  ___ \r\n|  __|/ __/ _ \\|  __| '_ \\ / _ \\ '__/ _` | | | |  `--. \\/ _ \\| | | | | __| |/ _ \\| '_ \\/ __|\r\n| |__| (_| (_) | |__| | | |  __/ | | (_| | |_| | /\\__/ / (_) | | |_| | |_| | (_) | | | \\__ \\\r\n\\____/\\___\\___/\\____/_| |_|\\___|_|  \\__, |\\__, | \\____/ \\___/|_|\\__,_|\\__|_|\\___/|_| |_|___/\r\n                                     __/ | __/ |                                            \r\n                                    |___/ |___/                                             \r\n";
            bool sortirPrograma = false;

            do
            {
                Console.WriteLine(MissatgeBenvinguda);
                SistemaUtils.MostrarMenu();

                switch (SistemaUtils.LlegirNumeroValid())
                {
                    case 1:
                        Console.WriteLine("Has escollit la opció 1");
                        break;
                    case 2:
                        Console.WriteLine("Has escollit la opció 2");
                        break;
                    case 3:
                        Console.WriteLine("Has escollit sortir del programa! :(");
                        sortirPrograma = true;
                        break;
                    default:
                        Console.Write("Error: si us plau, introdueix un número vàlid.");
                        break;
                }
            } while (!sortirPrograma);
            
        }
    }
}
