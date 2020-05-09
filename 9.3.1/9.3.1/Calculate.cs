using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._1
{
    public class Calculate : ICalcuation_1
    {
        public float Square(float number) => number * number;
        public float Cube(float number) => number * number * number;
    }
}
