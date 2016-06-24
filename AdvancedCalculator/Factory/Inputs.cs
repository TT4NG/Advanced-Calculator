using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Factory
{
    class Inputs
    {
        public int x;
        public int y;
        public int ValueX
        {
            get { return x; }
        }
        public int ValueY
        {
            get { return y; }
        }
        public virtual void result()
        {
            //result type from whatever operator is given
        }
    }
}
