using System;

namespace T3PR1
{
    public class SistemaEolic : SistemaEnergia
    {
        public double VelocitatVent { get; set; }

        public SistemaEolic(DateTime data, double velocitatVent)
        {
            Data = data;
            Tipus = "Eòlica";
            VelocitatVent = velocitatVent;
        }
    }
}