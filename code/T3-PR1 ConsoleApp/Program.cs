using System;

namespace T3PR1
{
    public class Program
    {
        public static void Main()
        {
            SistemaSolar sistemaSolar = new SistemaSolar(DateTime.Now, 8);
            sistemaSolar.MostrarInforme();

            SistemaEolic sistemaEolic = new SistemaEolic(DateTime.Now, 10);
            sistemaEolic.MostrarInforme();

            SistemaHidroelectric sistemaHidroelectric = new SistemaHidroelectric(DateTime.Now, 10);
            sistemaHidroelectric.MostrarInforme();
        }
    }
}
