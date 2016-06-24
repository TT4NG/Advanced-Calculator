using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Facade
{
    class _Inputs
    {
        public int x;
        public int y;
        public string operand;
        public int ValueX
        {
            get { return x; }
        }
        public int ValueY
        {
            get { return y; }
        }
        public string NewOperand
        {
            get { return operand; }
        }
        public _Inputs(int x, int y, string operand)
        {
            this.x = x;
            this.y = y;
            this.operand = operand;
        }
    }
}
