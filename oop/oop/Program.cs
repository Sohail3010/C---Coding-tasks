using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x = 10;
            int y = 5;
            int sum = 0;
            sum = calc.Add(x, y);
            Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);
            sum = calc.Subtract(x, y);
            Console.WriteLine("sum of {0} - {1} = {2}", x, y, sum);
            sum = calc.Divide(x, y);
            Console.WriteLine("sum of {0} / {1} = {2}", x, y, sum);
            Console.ReadLine();
        }

      
    }   
}
