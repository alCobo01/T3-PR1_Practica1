using System;

namespace T3PR1
{
    internal interface ICalculEnergia
    {
        bool ValidarDada(double dada, int minim);
        double CalculEnergia();
        void MostrarInforme();
    }
}
