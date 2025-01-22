using System;

namespace T3PR1
{
    public abstract class SistemaEnergia
    {
        public DateTime Data { get; set; }
        public string? Tipus { get; set; }
        public abstract void MostrarInforme();
        public abstract double CalculEnergia();
    }
}
