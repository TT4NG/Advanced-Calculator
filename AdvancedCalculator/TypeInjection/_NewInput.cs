using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.TypeInjection
{
    
    class _NewInput
    {
        Iresults _inputs;
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
        public _NewInput(Iresults inputs, int x, int y)
        {
            this._inputs = inputs;
            this.x = x;
            this.y = y;
        }
        public void Results()
        {
            _inputs._results( x,  y);
        }
    }
}
