using System;

namespace T3PR1
{
    public class SistemaSolar : SistemaEnergia
    {
        public int HoresSol { get; set; }

        public SistemaSolar(DateTime data, int horesSol)
        {
            Data = data;
            Tipus = "Solar";
            HoresSol = horesSol;
        }
    }
}
