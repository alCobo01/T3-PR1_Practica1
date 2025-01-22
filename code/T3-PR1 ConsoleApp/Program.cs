using System;
using T3PR1;

namespace T3PR1
{
    public class Program
    {
        private static SistemaEnergia[] simulacionsTotals = new SistemaEnergia[10];
        private static int simulacionsActuals = 0;

        public static void Main()
        {
            int quantitatSimulacions = 0;
            bool sortirPrograma = false, simulacioFeta = false;

            Missatges.MostrarMissatgeBenvinguda();
            do
            {
                Missatges.MostrarMenu();

                switch (SistemaUtils.LlegirIntValid(1, 3))
                {
                    case 1:
                        Console.Write(Missatges.OpcioUnMenuMissatge);
                        quantitatSimulacions = SistemaUtils.LlegirIntValid();
                        Simulacio.ExecutarSimulacio(ref simulacionsTotals, ref simulacionsActuals, quantitatSimulacions);
                        simulacioFeta = true;
                        break;
                    case 2:
                        if (simulacioFeta)
                        {
                            Simulacio.VeureSimulacions(simulacionsTotals);
                        }
                        else
                        {
                            Console.WriteLine(Missatges.OpcioDosInvalidMenuMissatge);
                        }
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
