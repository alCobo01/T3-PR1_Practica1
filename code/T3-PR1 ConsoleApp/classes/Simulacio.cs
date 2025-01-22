using System;

namespace T3PR1
{
    public static class Simulacio
    {
        public static void ExecutarSimulacio(ref SistemaEnergia[] simulacionsTotals, ref int simulacionsActuals, int quantitatSimulacio)
        {
            const string MissatgeEscollirSistema = "\n Quin sistema vols simular? (simulació {0} de {1}): \n 1. Hidroelèctrica \n 2. Eòlica \n 3. Solar \n Sistema escollit: ";
            const string MissatgeCabal = "Quin cabal vols per la hidroelèctrica? (m³/s): ";
            const string MissatgeVent = "Quina velocitat de vent vols per la eòlica? (m/s): ";
            const string MissatgeHoresSol = "Quantes hores de sol vols per la solar? ";

            if (simulacionsActuals >= simulacionsTotals.Length) AmpliarArray(ref simulacionsTotals);

            for (int i = 0; i < quantitatSimulacio; i++)
            {
                Console.Write(MissatgeEscollirSistema, i + 1, quantitatSimulacio);
                switch (SistemaUtils.LlegirIntValid(1, 3))
                {
                    case 1:
                        bool sortir = false;
                        do
                        {
                            try
                            {
                                Console.Write(MissatgeCabal);
                                double cabal = SistemaUtils.LlegirDoubleValid();
                                simulacionsTotals[simulacionsActuals] = new SistemaHidroelectric(DateTime.Now, cabal);
                                sortir = true;
                            }
                            catch (ArgumentException ex) { SistemaUtils.MostrarMissatgeError(ex.Message, ConsoleColor.Cyan); }
                        } while (!sortir);
                        break;
                    case 2:
                        sortir = false;
                        do
                        {
                            try
                            {
                                Console.Write(MissatgeVent);
                                double velocitatVent = SistemaUtils.LlegirDoubleValid();
                                simulacionsTotals[simulacionsActuals] = new SistemaEolic(DateTime.Now, velocitatVent);
                                sortir = true;
                            }
                            catch (ArgumentException ex) { SistemaUtils.MostrarMissatgeError(ex.Message, ConsoleColor.Cyan); }
                        } while (!sortir);
                        break;
                    case 3:
                        sortir = false;
                        do
                        {
                            try
                            {
                                Console.Write(MissatgeHoresSol);
                                double horesSol = SistemaUtils.LlegirDoubleValid();
                                simulacionsTotals[simulacionsActuals] = new SistemaSolar(DateTime.Now, horesSol); ;
                                sortir = true;
                            }
                            catch (ArgumentException ex) { SistemaUtils.MostrarMissatgeError(ex.Message, ConsoleColor.Cyan); }
                        } while (!sortir);
                        break;
                    default:
                        Console.WriteLine(Missatges.OpcioEquivocadaMenuMissatge);
                        break;
                }
                Console.WriteLine(Missatges.SimulacioAcabada, simulacionsTotals[simulacionsActuals].CalculEnergia());
                simulacionsActuals++;
            }
            Console.WriteLine(Missatges.FinalSimulacions);
        }

        public static void VeureSimulacions(SistemaEnergia[] sistemes)
        {
            for (int i = 0; i < sistemes.Length; i++)
            {
                sistemes[i]?.MostrarInforme();
            }
        }

        private static void AmpliarArray(ref SistemaEnergia[] array)
        {
            int nuevoTamaño = array.Length * 2;
            if (nuevoTamaño == 0) nuevoTamaño = 10;
            SistemaEnergia[] nuevoArray = new SistemaEnergia[nuevoTamaño];
            for (int i = 0; i < array.Length; i++)
            {
                nuevoArray[i] = array[i];
            }
            array = nuevoArray;
        }
    }
}
