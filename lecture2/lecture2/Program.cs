using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello world");

            sw.Close();
            fs.Close();
        }
        static void F2()
        {
            FileStream fs= new FileStream("input.txt", FileMode.OpenOrCreate.
        }
    }
}
