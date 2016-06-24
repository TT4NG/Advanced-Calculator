using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            string operand;
            string line;
            

            //record math string to then parse for ints and operands
           
            //hard code individual ints and operands
            Console.WriteLine("Input a variable x: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Input a variable y: ");
            int.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Choose an operator for x __  y:  + , - , / , * , ^");
            operand = Console.ReadLine();
            line = (x + operand + y + "=");

            //Facade Pattern
            Console.WriteLine("Facade Pattern");
            Facade._Inputs Input = new Facade._Inputs(x, y, operand);
            Facade.BranchToOp Branch = new Facade.BranchToOp();
            bool Right = Branch.Proper(Input, Input, Input);
            //Factory Pattern
            Console.WriteLine("Factory Pattern");
            Factory.Menu Menu = new Factory.Menu();
            Factory.Inputs opSet = null;
            try
            {
                opSet = Menu.getOperator(operand);
                opSet.x = x;
                opSet.y = y;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                opSet= new Factory.Addition();
            }
            opSet.result();

            //Type Injection Pattern
            Console.WriteLine("Injection Pattern");
            //instance of injections
            TypeInjection._addition Add = new TypeInjection._addition();
            TypeInjection._subtraciton Minus = new TypeInjection._subtraciton();
            TypeInjection._division Divide = new TypeInjection._division();
            TypeInjection._multiplication Multiply = new TypeInjection._multiplication();
            TypeInjection.__exponent Karat = new TypeInjection.__exponent();
            //if else check
            Console.WriteLine("checking if viable operand");
            if (operand == "+")
            {
                TypeInjection._NewInput newInput = new TypeInjection._NewInput(Add, x, y);
                Console.WriteLine(line);
                newInput.Results();
            }
            else if (operand == "-")
            {
                TypeInjection._NewInput newInput = new TypeInjection._NewInput(Minus, x, y);
                Console.WriteLine(line);
                newInput.Results();
            }
            else if (operand == "*")
            {
                TypeInjection._NewInput newInput = new TypeInjection._NewInput(Multiply,x,y);
                Console.WriteLine(line);
                newInput.Results();
            }
            else if (operand == "/")
            {
                TypeInjection._NewInput newInput = new TypeInjection._NewInput(Divide,x,y);
                Console.WriteLine(line);
                newInput.Results();
            }
            else if (operand == "^")
            {
                TypeInjection._NewInput newInput = new TypeInjection._NewInput(Karat,x,y);
                Console.WriteLine(line);
                newInput.Results();
            }
            else
            {
                Console.WriteLine("operator is invalid");
                
            }
            Console.ReadKey();
        }
    }
}
