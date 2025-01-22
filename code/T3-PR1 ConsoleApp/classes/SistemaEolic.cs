using System;

namespace T3PR1
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        //Propietat
        public double VelocitatVent { get; set; }

        //Constuctor amb major càrrega lògica
        public SistemaEolic(DateTime data, double velocitatVent)
        {
            if (!ValidarDada(velocitatVent, 5)) throw new ArgumentException(Missatges.EolicArgumentException);
            Data = data;
            Tipus = "Eòlica";
            VelocitatVent = velocitatVent;
        }

        //Constructor amb menor càrrega lògica
        public SistemaEolic()
        {
            Data = DateTime.Now;
            Tipus = "Eòlica";
            VelocitatVent = 0;
        }

       //Métodes de la clase
        public bool ValidarDada(double velocitatVent, int minim) => velocitatVent > minim;
        public override double CalculEnergia() => Math.Pow(VelocitatVent, 3) * 0.2;

        public override void MostrarInforme()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Informe de simulació Sistema Eòlic");
            Console.WriteLine("===========================================");
            Console.WriteLine("| Propietat         | Valor               |");
            Console.WriteLine("|-------------------|---------------------|");
            Console.WriteLine($"| Data              | {Data} |");
            Console.WriteLine($"| Velocitat del vent| {VelocitatVent} m/s       |");
            Console.WriteLine($"| Energía Calculada | {CalculEnergia()} kWh      |");
            Console.WriteLine("===========================================\n");
        }
        
    }
}