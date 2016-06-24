using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Factory
{
    abstract class TypeofOperator
    {
        public abstract Inputs getOperator(string operator_type);
    }
}
