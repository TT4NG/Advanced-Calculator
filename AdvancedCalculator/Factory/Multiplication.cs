using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Factory
{
    class Multiplication:Inputs
    {
        public override void result()
        {
            float sum = x * y;
            Console.WriteLine("Im adding the sum of the two float values");
            Console.WriteLine(x + "*" + y + "=" + sum);
        }
    }
}
