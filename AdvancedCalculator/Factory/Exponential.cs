using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Factory
{
    class Exponential:Inputs
    {
        public override void result()
        {
            double sum = Math.Pow(x, y);
            Console.WriteLine("Im adding the sum of the two float values");
            Console.WriteLine(x + "^" + y + "=" + sum);
        }
    }
}
