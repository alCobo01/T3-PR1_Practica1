using System;
using System.Reflection.Emit;

namespace T3PR1
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double HoresSol { get; set; }

        public SistemaSolar(DateTime data, double horesSol)
        {
            if (!ValidarDada(horesSol, 20)) throw new ArgumentException("Les hores de sol han de ser superiors a 1!");
            Data = data;
            Tipus = "Solar";
            HoresSol = horesSol;
        }

        public bool ValidarDada(double horesSol, int minim) => horesSol > minim;
        public double CalculEnergia() => HoresSol * 1.5;

        public void MostrarInforme()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Informe del Sistema Solar");
            Console.WriteLine("====================================");
            Console.WriteLine("| Propietat         | Valor        |");
            Console.WriteLine("|-------------------|--------------|");
            Console.WriteLine($"| Data              | {Data.ToShortDateString()}   |");
            Console.WriteLine($"| Tipus             | {Tipus}        |");
            Console.WriteLine($"| Hores de sol      | {HoresSol}h           |");
            Console.WriteLine($"| Energía Calculada | {CalculEnergia()} kWh       |");
            Console.WriteLine("====================================");
        }
    }
}
