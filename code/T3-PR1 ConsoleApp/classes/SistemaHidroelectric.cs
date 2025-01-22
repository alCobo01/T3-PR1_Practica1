using System;

namespace T3PR1
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double Cabal { get; set; }

        public SistemaHidroelectric(DateTime data, double cabal)
        {
            if (!ValidarDada(cabal, 20)) throw new ArgumentException(Missatges.HidroelectricArgumentException);
            Data = data;
            Tipus = "Hidroelèctrica";
            Cabal = cabal;
        }

        public bool ValidarDada(double cabal, int minim) => cabal > minim;
        public override double CalculEnergia() => Math.Round(Cabal * 9.8 * 0.8, 3);
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
