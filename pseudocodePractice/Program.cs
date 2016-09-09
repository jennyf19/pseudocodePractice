using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pseudocodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int product = num1 * num2;
            Console.WriteLine("the answer is " + product);
            Console.ReadLine();
        }
    }
}
