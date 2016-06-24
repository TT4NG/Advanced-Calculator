using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.TypeInjection
{
    class _subtraciton : Iresults
    {
        public void _results(int x, int y)
        {
            double sum = x - y;
            Console.WriteLine(sum);
        }
    }
}
