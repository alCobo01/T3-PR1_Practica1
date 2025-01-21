using System;

namespace T3PR1
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public int HoresSol { get; set; }

        public SistemaSolar(DateTime data, int horesSol)
        {
            Data = data;
            Tipus = "Solar";
            HoresSol = horesSol;
        }

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
