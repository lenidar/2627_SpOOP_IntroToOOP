using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2627_SpOOP_IntroToOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(1, 2));
            //Sub(5, 3);
            //Mul(4, 3);
            //int[] quo = Div(12, 5);
            //Console.WriteLine($"The quotient of 12 and 5 is {quo[0]} remainder {quo[1]}");

            Console.WriteLine(Add(new int[] { 1,2,3,4,5}));
            Console.WriteLine(Add(5));
            Console.WriteLine(Add(Add(new int[] { 2, 4, 6, Mul(7, 8) }), 7));
        }

        /// <summary>
        /// This method just adds two number together
        /// </summary>
        /// <param name="a">This is the first number</param>
        /// <param name="b">This is the second number</param>
        /// <returns>The sum of two numbers</returns>
        static int Add(int a, int b = 1)
        {
            //Console.WriteLine($"The sum of {a} and {b} is {a + b}");
            //Console.WriteLine($"I am called! I am adding {a} and {b} together!");
            return a + b;
        }

        static int Add(int[] a)
        {
            int rT = 0;

            foreach(int x in a)
                rT = Add(rT, x);

            return rT;
        }

        /// <summary>
        /// This method just subtracts the value of the second number from the first
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Returns the difference between the two numbers</returns>
        static int Sub(int a, int b)
        {
            //Console.WriteLine($"The difference of {a} and {b} is {a - b}");
            return a - b;
        }

        /// <summary>
        /// This method multiplies the first number with the second number.
        /// Multiplication is done via the Add method.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>The product of the two numbers</returns>
        static int Mul(int a, int b)
        {
            int prod = 0;

            //Console.WriteLine("Starting the multiplication process!");

            for (int x = 0; x < b; x = Add(x))
                prod = Add(prod, a);

            //Console.WriteLine($"The product of {a} and {b} is {prod}");

            return prod;
        }

        /// <summary>
        /// This method divides the first number with the second number.
        /// Division is done via the Sub() method and counting is done via the Add()
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>The quotient and the remainder in array form</returns>
        static int[] Div(int a, int b)
        {
            int quo = 0;

            //Console.WriteLine("Starting the division process!");
            //Console.Write($"The quotient of {a} and {b} is ");

            while (a > b)
            {
                a = Sub(a, b);
                quo = Add(quo, 1);
            }

            //Console.WriteLine($"{quo} r {a}");

            return new int[] { quo, a };
        }
    }
}
