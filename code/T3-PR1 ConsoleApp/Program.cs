using System;
using T3PR1;

namespace T3PR1
{
    public class Program
    {
        public static void Main()
        {
            int contadorSimulacions = 0;
            bool sortirPrograma = false;

            do
            {
                Console.WriteLine(Missatges.MissatgeBenvinguda);
                SistemaUtils.MostrarMenu();

                switch (SistemaUtils.LlegirNumeroValid())
                {
                    case 1:
                        Console.WriteLine(Missatges.OpcioUnMenuMissatge);
                        contadorSimulacions++;
                        break;
                    case 2:
                        Console.WriteLine(contadorSimulacions > 0 ? Missatges.OpcioDosValidMenuMissatge : Missatges.OpcioDosInvalidMenuMissatge);
                        break;
                    case 3:
                        Console.WriteLine(Missatges.OpcioTresMenuMissatge);
                        sortirPrograma = true;
                        break;
                    default:
                        Console.Write(Missatges.OpcioEquivocadaMenuMissatge);
                        break;
                }
            } while (!sortirPrograma);

        }
    } 
}
