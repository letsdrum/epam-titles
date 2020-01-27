using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_titles.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Addition(10, 5));
            Console.WriteLine(Calculator.Substract(10, 5));
            Console.WriteLine(Calculator.Multiply(10, 5));
            Console.WriteLine(Calculator.Divide(10, 3));

            Console.ReadKey();
        }
    }
}
