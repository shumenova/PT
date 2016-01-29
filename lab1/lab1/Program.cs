using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Complex 
    {
        public int a, b;
        public Complex (int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public static Complex operator + (Complex c1, Complex c2)
        {
            Complex.sum = new Complex(c1.a + c2.a, c1.b + c2.b);
            return sum; 
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            num3 = Int32.Parse(Console.ReadLine());
            num4 = Int32.Parse(Console.ReadLine());
            Complex complex_1 = new Complex(num1, num2);
            Complex complex_2 = new Complex(num1, num2);
            Complex sum = complex_1 + complex_2;

        }
    }
     
}
