using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Factory
{
    class Menu: TypeofOperator
    {
        public override Inputs getOperator(string operator_type)
        {
            switch (operator_type)
            {
                case "+":
                    return new Addition();
                case "-":
                    return new Subtraction();
                case "*":
                    return new Multiplication();
                case "/":
                    return new Division();
                case "^":
                    return new Exponential();
                default:
                    throw new ApplicationException(string.Format("Invalid Choice {0}", operator_type));
            }
        }
    }
}
