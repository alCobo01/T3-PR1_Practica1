using System;
using System.Reflection.Emit;

namespace T3PR1
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        private const string _name = "Solar";

        //Propietats
        public double HoresSol { get; set; }

        //Constructor amb major càrrega lògica
        public SistemaSolar(DateTime data, double horesSol)
        {
            if (!ValidarDada(horesSol, 1)) throw new ArgumentException(Missatges.SolarArgumentException);
            Data = data;
            Tipus = _name;
            HoresSol = horesSol;
        }

        //Constructor amb menor càrrega lògica
        public SistemaSolar()
        {
            Data = DateTime.Now;
            Tipus = _name;
            HoresSol = 5;
        }

        //Mètodes de la classe
        /// <summary>
        /// Valida si les hores de sol són majors que el mínim especificat.
        /// </summary>
        /// <param name="dada">Les hores de sol a validar.</param>
        /// <param name="minim">El valor mínim que les hores de sol han de superar.</param>
        /// <returns>Retorna <c>true</c> si les hores de sol són majors que el mínim, en cas contrari <c>false</c>.</returns>
        public bool ValidarDada(double dada, int minim) => dada >= minim;

        /// <summary>
        /// Calcula l'energia generada pel sistema solar.
        /// </summary>
        /// <returns>Retorna l'energia calculada en kWh.</returns>
        public override double CalculEnergia() => HoresSol * 1.5;

        /// <summary>
        /// Mostra un informe detallat de la simulació del sistema solar.
        /// </summary>
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
