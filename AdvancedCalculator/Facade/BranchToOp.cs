using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Facade
{
    class BranchToOp
    {
        private OpCheck _Check = new OpCheck();
        public bool Proper(_Inputs ValueX, _Inputs ValueY, _Inputs Op)
        {
            Console.WriteLine("{0}{2}{1}", ValueX.x, ValueY.y, Op.operand);
            bool Right = true;

            if (!_Check.OpType(ValueX, ValueY, Op))
            {
                Right = false;
            }
            Console.ReadKey();
            return Right; 
        }
    }
}
