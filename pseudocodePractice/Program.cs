﻿using System;
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
            /*Console.WriteLine("enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int product = num1 * num2;
            Console.WriteLine("the answer is " + product);
            Console.ReadLine();*/

            /*Console.WriteLine("Enter a number: ");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 5 || answer == 6)
            {
                Console.WriteLine("your number is either five or six");
            }
            else
            {
                Console.WriteLine("your number is not five or six!");
            }
            Console.ReadLine();*/

            /*Console.WriteLine("Enter a number between 0 and 29: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num < 10)
            {
                Console.WriteLine("Blue");
            }
            else if (10 < num && num < 20)
            {
                Console.WriteLine("Red");
            }
            else if (20 < num && num < 30)
            {
                Console.WriteLine("Green");
            }
            else
                Console.WriteLine("you have not entered a color option");
            Console.ReadLine();*/
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int div;
            int sub;
            int add = num2 + num1;
            int multi = num2 * num1;

            if (num1 > num2)
            {
                div = num1 / num2;
                sub = num1 - num2;
            }
            else
            {
                div = num2 / num1;
                sub = num2 - num1;
            }
            Console.WriteLine("here are the results for the numbers "
                + num1 + " and " + num2 + ": \n Add: " + add + "\n Subtract: " + sub +
                "\n Multiply: " + multi + "\n Divide: " + div);
            Console.ReadLine();
        }
    }

}




