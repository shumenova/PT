using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;                                      //create 2 numbers, which can be fractional
            Console.WriteLine("Enter 2 numbers");             //ask to set 2 numbers
            a = Convert.ToDouble(Console.ReadLine());         //convert number a into double type
            b = Convert.ToDouble(Console.ReadLine());         //convert number b into double type
            Console.WriteLine("a + b ={0}", a + b);           //making operation addition and the result withdraw to the screen
            Console.ReadLine();                               //waiting for the following actions


        }
    }
}
