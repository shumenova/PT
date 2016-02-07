using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Point // конструктор
    {
        public int x;
        public int y;
        public int z;
        public Info info;
        public Point()
        {
            x = 10;
            y = 20;
            z = 30;
            info = new Info();
            info.owner = "abc";
            info.version = "1.0";

        }
        public class Info
        {
            public string owner;
            public string version;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F1();
            
        }
        public static void F1()
        {
            Point a = new Point();
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point)); // istrument kotoryu sochranyaet sostoyanie obiekta 
            xs.Serialize(fs, a);
            fs.Close();
        }
        public static void F2()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point)); // istrument kotoryu sochranyaet sostoyanie obiekta 
            Point b= xs.Deserialize(fs) as Point; // polucenie obiekta

            Console.WriteLine(b.x);
            Console.WriteLine(b.info.owner);
            Console.ReadKey();

            fs.Close();

        }
    }
}
