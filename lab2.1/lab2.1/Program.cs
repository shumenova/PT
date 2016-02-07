using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"C:\Users\Sulushash1\Desktop\numbers1.8.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(stream);

            string line = reader.ReadToEnd();

            reader.Close();
            stream.Close();

            string[] arr = line.Split(' ');
            int arrLength = arr.Length;

            int maks = 0;
            int min = 1000000;

            for(int i=0; i<arrLength; i++)
            {
                string elem = arr[i];
                int val = Int32.Parse(elem);

                if(val>maks)
                {
                    maks = val;
                }

                if(val < min)
                {
                    min = val;
                }

            }

            Console.WriteLine("Min val is {0}, Max is {1}", min, maks);
            Console.ReadKey();
        }
    }
}
