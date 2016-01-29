using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture1
{
    class Program
    {
        static void Main(string[] args)

        {   
            DirectoryInfo d = new DirectoryInfo(@"c:\testfolder");
            int cnt = Search(d);
            Console.WriteLine(cnt);
            Console.ReadKey();

        }

        static int Search(DirectoryInfo d)
        {
            FileInfo files[] = d.GetFiles();
            int cnt_files = d.GetFiles().Lenght;

            DirectoryInfo[] dectories = d.GetDirectories(); 
            foreach(DirectoryInfo directory in directories)
            {
                cnt_files += Search(directory);
            }
            return cnt_files;

        }
    }
}
