using System;

namespace T3PR1
{
    public class SistemaHidroelectric : SistemaEnergia
    {
        public double Cabal { get; set; }

        public SistemaHidroelectric(DateTime data, double cabal)
        {
            Data = data;
            Tipus = "Hidroelèctrica";
            Cabal = cabal;
        }
    }
}
