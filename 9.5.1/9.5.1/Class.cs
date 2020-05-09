using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5._1
{
    class Class : IPerimetri, IFartobi
    {
        IPerimetri Object_1;
        IFartobi Object_2;
        float IPerimetri.Cal(float gverdi_1, float gverdi_2, float gverdi_3) => gverdi_1 + gverdi_2 + gverdi_3;
        float IFartobi.Cal(float gverdi_1, float Height) => (gverdi_1 * Height) / 2;

        public float Cal_1(float gverdi_1, float gverdi_2, float gverdi_3)
        {
            Object_1 = this;
            return Object_1.Cal(gverdi_1, gverdi_2, gverdi_3);
        }
        public float Cal_2(float gverdi_1,float Height)
        {
            Object_2 = this;
            return Object_2.Cal(gverdi_1, Height);
        }
    }
}
