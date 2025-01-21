using System;

namespace T3PR1
{
    public class SistemaHidroelectric : SistemaEnergia
    {
        public double Cabal { get; set; }

        public SistemaHidroelectric(DateTime data, double cabal)
        {
            if (cabal <= 0) throw new ArgumentException("El cabal ha de ser positiu");
            Data = data;
            Tipus = "Hidroelèctrica";
            Cabal = cabal;
        }

        public double CalculEnergia() => Cabal * 9.8 * 0.8;
        public void MostrarInforme()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Informe del Sistema Hidroelèctric");
            Console.WriteLine("====================================");
            Console.WriteLine("| Propietat         | Valor        |");
            Console.WriteLine("|-------------------|--------------|");
            Console.WriteLine($"| Data              | {Data.ToShortDateString()}   |");
            Console.WriteLine($"| Tipus             | {Tipus}|");
            Console.WriteLine($"| Cabal             | {Cabal} m³/s       |");
            Console.WriteLine($"| Energía Calculada | {CalculEnergia()} kWh      |");
            Console.WriteLine("====================================");
        }
    }
}
