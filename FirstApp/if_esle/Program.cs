using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_esle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 0;
            Console.Write("Enter first number: ");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                Console.WriteLine("first number is larger than second number");
            }
            else if (firstnumber == secondnumber)
            {
                Console.WriteLine("first number is larger than second number");
            }
            {
                Console.WriteLine("Second number is greater then first number");
            }
            Console.ReadLine();
        }
    }
}
