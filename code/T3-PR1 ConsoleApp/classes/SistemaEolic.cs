using System;

namespace T3PR1
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        private const string _name = "Eòlica";

        //Propietats
        public double VelocitatVent { get; set; }

        //Constuctor amb major càrrega lògica
        public SistemaEolic(DateTime data, double velocitatVent)
        {
            if (!ValidarDada(velocitatVent, 5)) throw new ArgumentException(Missatges.EolicArgumentException);
            Data = data;
            Tipus = _name;
            VelocitatVent = velocitatVent;
        }

        //Constructor amb menor càrrega lògica
        public SistemaEolic()
        {
            Data = DateTime.Now;
            Tipus = _name;
            VelocitatVent = 10;
        }

        //Mètodes de la classe
        /// <summary>
        /// Valida la velocitat del vent en funció d'un valor mínim.
        /// </summary>
        /// <param name="dada">La velocitat del vent a validar.</param>
        /// <param name="minim">El valor mínim que ha de superar la velocitat del vent.</param>
        /// <returns>Retorna true si la velocitat del vent és superior al valor mínim, en cas contrari retorna false.</returns>
        public bool ValidarDada(double dada, int minim) => dada >= minim;


        /// <summary>
        /// Calcula l'energia generada pel sistema eòlic.
        /// </summary>
        /// <returns>Retorna l'energia generada en kWh.</returns>
        public override double CalculEnergia() => Math.Pow(VelocitatVent, 3) * 0.2;

        /// <summary>
        /// Mostra un informe detallat de la simulació del Sistema Eòlic.
        /// </summary>
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