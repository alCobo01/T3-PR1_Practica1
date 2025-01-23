using System;

namespace T3PR1
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        private const string _name = "Hidroelèctrica";

        //Propietats
        public double Cabal { get; set; }

        //Constuctor amb major càrrega lògica
        public SistemaHidroelectric(DateTime data, double cabal)
        {
            if (!ValidarDada(cabal, 20)) throw new ArgumentException(Missatges.HidroelectricArgumentException);
            Data = data;
            Tipus = _name;
            Cabal = cabal;
        }

        //Constructor amb menor càrrega lògica
        public SistemaHidroelectric()
        {
            Data = DateTime.Now;
            Tipus = _name;
            Cabal = 25;
        }

        //Mètodes de la classe
        /// <summary>
        /// Valida si el cabal és superior al mínim requerit.
        /// </summary>
        /// <param name="dada">El cabal a validar.</param>
        /// <param name="minim">El valor mínim requerit per al cabal.</param>
        /// <returns>Retorna true si el cabal és superior al mínim, en cas contrari retorna false.</returns>
        public bool ValidarDada(double dada, int minim) => dada >= minim;

        /// <summary>
        /// Calcula l'energia generada pel sistema hidroelèctric.
        /// </summary>
        /// <returns>
        /// Retorna l'energia calculada en kWh, arrodonida a tres decimals.
        /// </returns>
        public override double CalculEnergia() => Math.Round(Cabal * 9.8 * 0.8, 3);

        /// <summary>
        /// Mostra un informe detallat de la simulació del Sistema Hidroelèctric.
        /// </summary>
        public override void MostrarInforme()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Informe de simulació Sistema Hidroelèctric");
            Console.WriteLine("===========================================");
            Console.WriteLine("| Propietat         | Valor               |");
            Console.WriteLine("|-------------------|---------------------|");
            Console.WriteLine($"| Data              | {Data} |");
            Console.WriteLine($"| Cabal             | {Cabal} m³/s            |");
            Console.WriteLine($"| Energía Calculada | {CalculEnergia()} kWh            |");
            Console.WriteLine("===========================================\n");
        }
    }
}
