using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"C:\Users\Sulushash1\Desktop\numbers1.8.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(stream);
            string line = reader.ReadLine();
            reader.Close();
            stream.Close();

            string[] arr = line.Split(' ');
            int lenght = arr.Length;

            int min = 10000;

            for (int i = 0; i < lenght; i++)
            {
                string num = arr[i];
                int n = Int32.Parse(num);
                Boolean Prime = isPrime(n);
                if (Prime == true && n < min) 
                {
                    min = n;
                }

            }
            Console.WriteLine(min);
            Console.ReadKey();

        

        }
        static Boolean isPrime(int x)
        {
            int cnt = 0;

            for (int i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    cnt++;
                }

            }
            Boolean res = false;
            if (cnt == 0 && x != 1)
            {
                res = true;
            }

            return res;

        }

    }
}
