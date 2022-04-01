using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and create object
            Calculator calc = new Calculator();
            int x = 3;
            int y = 5;
            int sum = 0;
            sum = calc.Add(x, y);
            Console.WriteLine("sum of {0} + {1} = {2}",x,y,sum);
            Console.WriteLine("12 - 6 = {0}", calc.Substract(12,6));
            Console.WriteLine("7 x 8 = {0}", calc.Multiply(7, 8));
            Console.WriteLine("48 ÷ 4 = {0}", calc.Divide(48, 4));
            Console.ReadLine();

        }
    }
}
