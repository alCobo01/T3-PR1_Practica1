using System;

namespace T3PR1
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        public double VelocitatVent { get; set; }

        public SistemaEolic(DateTime data, double velocitatVent)
        {
            Data = data;
            Tipus = "Eòlica";
            VelocitatVent = velocitatVent;
        }

        public double CalculEnergia() => Math.Pow(VelocitatVent, 3) * 0.2;

        public void MostrarInforme()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Informe del Sistema Eòlic");
            Console.WriteLine("====================================");
            Console.WriteLine("| Propietat         | Valor        |");
            Console.WriteLine("|-------------------|--------------|");
            Console.WriteLine($"| Data              | {Data.ToShortDateString()}   |");
            Console.WriteLine($"| Tipus             | {Tipus}       |");
            Console.WriteLine($"| Velocitat del vent| {VelocitatVent} m/s       |");
            Console.WriteLine($"| Energía Calculada | {CalculEnergia()} kWh      |");
            Console.WriteLine("====================================");
        }
    }
}