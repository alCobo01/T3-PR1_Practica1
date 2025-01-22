using System;
using System.Reflection.Emit;

namespace T3PR1
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double HoresSol { get; set; }

        public SistemaSolar(DateTime data, double horesSol)
        {
            if (!ValidarDada(horesSol, 1)) throw new ArgumentException(Missatges.SolarArgumentException);
            Data = data;
            Tipus = "Solar";
            HoresSol = horesSol;
        }

        public bool ValidarDada(double horesSol, int minim) => horesSol > minim;
        public override double CalculEnergia() => HoresSol * 1.5;

        public override void MostrarInforme()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Informe de simulació Sistema Solar");
            Console.WriteLine("===========================================");
            Console.WriteLine("| Propietat         | Valor               |");
            Console.WriteLine("|-------------------|---------------------|");
            Console.WriteLine($"| Data              | {Data} |");
            Console.WriteLine($"| Hores de sol      | {HoresSol}h               |");
            Console.WriteLine($"| Energía Calculada | {CalculEnergia()} kWh             |");
            Console.WriteLine("===========================================\n");
        }
    }
}
