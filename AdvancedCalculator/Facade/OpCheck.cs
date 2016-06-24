using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Facade
{
    class OpCheck
    {
        double sum;
        public bool OpType(_Inputs x,_Inputs y, _Inputs operand)
        {

            Console.WriteLine("checking if viable operand");
            if (operand.operand == "+")
            {
                sum = x.x + y.y;
                Console.WriteLine("operator is valid");
                Console.WriteLine(x.x + operand.operand + y.y + "=" + sum);
                return true;
            }
            else if (operand.operand == "-")
            {
                sum = x.x - y.y;
                Console.WriteLine("operator is valid");
                Console.WriteLine(x.x + operand.operand + y.y + "=" + sum);
                return true;
            }
            else if (operand.operand == "*")
            {
                sum = x.x * y.y;
                Console.WriteLine("operator is valid");
                Console.WriteLine(x.x + operand.operand + y.y + "=" + sum);
                return true;
            }
            else if (operand.operand == "/")
            {
                sum = x.x / y.y;
                Console.WriteLine("operator is valid");
                Console.WriteLine(x.x + operand.operand + y.y + "=" + sum);
                return true;
            }
            else if (operand.operand == "^")
            {
                sum = Math.Pow(x.x , y.y);
                Console.WriteLine("operator is valid");
                Console.WriteLine(x.x + operand.operand + y.y + "=" + sum);
                return true;
            }
            else
            {
                Console.WriteLine("operator is invalid");
                return false;
            }
        }
    }
}
