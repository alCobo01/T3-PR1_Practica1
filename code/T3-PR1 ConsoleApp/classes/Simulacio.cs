using System;

namespace T3PR1
{
    public static class Simulacio
    {
        /* El mètode ExecutarSimulacio té com a paràmetre un array referenciat, simulacionsTotals, per permetre modificar el contingut de l'array original passat com a argument. 
         Això és necessari perquè el mètode pot ampliar la mida de l'array si cal (amb el mètode AmpliarArray) i afegir noves simulacions al mateix array. 
         Si no es passés per referència, els canvis fets a l'array dins del mètode no es reflectirien fora d'aquest, i perdríem les noves simulacions afegides. */

        /// <summary>
        /// Executa una sèrie de simulacions de sistemes d'energia.
        /// </summary>
        /// <param name="simulacionsTotals">Array referenciat que conté totes les simulacions de sistemes d'energia.</param>
        /// <param name="simulacionsActuals">Nombre de simulacions realitzades fins al moment.</param>
        /// <param name="quantitatSimulacio">Nombre de noves simulacions a realitzar.</param>
        public static void ExecutarSimulacio(ref SistemaEnergia[] simulacionsTotals, ref int simulacionsActuals, int quantitatSimulacio)
        {
            const string MissatgeEscollirSistema = "\n Quin sistema vols simular? (simulació {0} de {1}): \n 1. Hidroelèctrica \n 2. Eòlica \n 3. Solar \n Sistema escollit: ";
            if (simulacionsActuals >= simulacionsTotals.Length) AmpliarArray(ref simulacionsTotals);

            for (int i = 0; i < quantitatSimulacio; i++)
            {
                Console.Write(MissatgeEscollirSistema, i + 1, quantitatSimulacio);
                int opcio = SistemaUtils.LlegirIntValid(1, 3);
                simulacionsTotals[simulacionsActuals] = CrearSistema(opcio);
                Console.WriteLine(Missatges.SimulacioAcabada, simulacionsTotals[simulacionsActuals].CalculEnergia());
                simulacionsActuals++;
            }
            Console.WriteLine(Missatges.FinalSimulacions);
        }

        /// <summary>
        /// Crea un nou sistema d'energia basat en l'opció seleccionada.
        /// </summary>
        /// <param name="opcio">L'opció seleccionada per l'usuari (1: Hidroelèctrica, 2: Eòlica, 3: Solar).</param>
        /// <returns>Un objecte de tipus SistemaEnergia corresponent a l'opció seleccionada.</returns>
        private static SistemaEnergia CrearSistema(int opcio)
        {
            switch (opcio)
            {
                case 1:
                    return CrearSistemaHidroelectric();
                case 2:
                    return CrearSistemaEolic();
                case 3:
                    return CrearSistemaSolar();
                default:
                    throw new ArgumentException(Missatges.OpcioEquivocadaMenuMissatge);
            }
        }

        /// <summary>
        /// Crea un nou sistema hidroelèctric amb el cabal especificat per l'usuari.
        /// </summary>
        /// <returns>Un objecte de tipus SistemaHidroelectric amb el cabal especificat.</returns>
        private static SistemaHidroelectric CrearSistemaHidroelectric()
        {
            const string MissatgeCabal = "Quin cabal vols per la hidroelèctrica? (m³/s): ";
            bool validInput = false;
            double cabal = 0;

            while (!validInput)
            {
                try
                {
                    Console.Write(MissatgeCabal);
                    cabal = SistemaUtils.LlegirDoubleValid();
                    validInput = true;
                }
                catch (ArgumentException ex)
                {
                    SistemaUtils.MostrarMissatgeAmbColor(ex.Message, ConsoleColor.Cyan);
                }
            }

            return new SistemaHidroelectric(DateTime.Now, cabal);
        }

        /// <summary>
        /// Crea un nou sistema eòlic amb la velocitat de vent especificada per l'usuari.
        /// </summary>
        /// <returns>Un objecte de tipus SistemaEolic amb la velocitat de vent especificada.</returns>
        private static SistemaEolic CrearSistemaEolic()
        {
            const string MissatgeVent = "Quina velocitat de vent vols per la eòlica? (m/s): ";
            bool validInput = false;
            double velocitatVent = 0;

            while (!validInput)
            {
                try
                {
                    Console.Write(MissatgeVent);
                    velocitatVent = SistemaUtils.LlegirDoubleValid();
                    validInput = true;
                }
                catch (ArgumentException ex)
                {
                    SistemaUtils.MostrarMissatgeAmbColor(ex.Message, ConsoleColor.Cyan);
                }
            }

            return new SistemaEolic(DateTime.Now, velocitatVent);
        }


        /// <summary>
        /// Crea un nou sistema solar amb les hores de sol especificades per l'usuari.
        /// </summary>
        /// <returns>Un objecte de tipus SistemaSolar amb les hores de sol especificades.</returns>
        private static SistemaSolar CrearSistemaSolar()
        {
            const string MissatgeHoresSol = "Quantes hores de sol vols per la solar? ";
            bool validInput = false;
            double horesSol = 0;

            while (!validInput)
            {
                try
                {
                    Console.Write(MissatgeHoresSol);
                    horesSol = SistemaUtils.LlegirDoubleValid();
                    validInput = true;
                }
                catch (ArgumentException ex)
                {
                    SistemaUtils.MostrarMissatgeAmbColor(ex.Message, ConsoleColor.Cyan);
                }
            }

            return new SistemaSolar(DateTime.Now, horesSol);
        }

        /// <summary>
        /// Mostra els informes de totes les simulacions realitzades.
        /// </summary>
        /// <param name="sistemes">Array que conté totes les simulacions de sistemes d'energia.</param>
        public static void VeureSimulacions(SistemaEnergia[] sistemes)
        {
            for (int i = 0; i < sistemes.Length; i++)
            {
                sistemes[i]?.MostrarInforme();
            }
        }

        /// <summary>
        /// Amplia la mida de l'array de simulacions de sistemes d'energia.
        /// </summary>
        /// <param name="array">Array de sistemes d'energia a ampliar.</param>
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

        /* Reassignem array perquè els arrays són objectes referenciats en C#.
         Quan passes un array com a paràmetre, estàs treballant amb una referència a l'array original.
         No pots canviar a què apunta aquesta referència tret que ho facis explícitament usant ref.
         Si no fas aquesta reassignació, l'array global simulacionsTotals continuaria apuntant a l'array original,
         i els nous elements no podrien ser emmagatzemats perquè no hi hauria suficient espai. */
    }
}
