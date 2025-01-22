using System;

namespace T3PR1
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double Cabal { get; set; }

        public SistemaHidroelectric(DateTime data, double cabal)
        {
            if (!ValidarDada(cabal, 20)) throw new ArgumentException("El cabal ha de ser major a 20 m^3!s");
            Data = data;
            Tipus = "Hidroelèctrica";
            Cabal = cabal;
        }

        public bool ValidarDada(double cabal, int minim) => cabal > minim;
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
