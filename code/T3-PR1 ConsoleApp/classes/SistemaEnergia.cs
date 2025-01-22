using System;

namespace T3PR1
{
    public abstract class SistemaEnergia
    {
        public DateTime Data { get; set; }
        public string? Tipus { get; set; }

        /// <summary>
        /// Mostra l'informe del sistema d'energia.
        /// </summary>
        public abstract void MostrarInforme();

        /// <summary>
        /// Calcula l'energia del sistema.
        /// </summary>
        /// <returns>Retorna el valor de l'energia calculada.</returns>
        public abstract double CalculEnergia();
    }
}
