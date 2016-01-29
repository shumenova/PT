using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int x;
            x = Int16.Parse(Console.ReadLine());
            for (int i = 2; i <= 2; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                    break;
                }
            if(prime)
                {
                    Console.WriteLine("prostoe");
                }
                else
                {
                    Console.WriteLine("ne prostoe");
                }
                
            }

        }
        Console.Readkey();
    }
    
    
}
