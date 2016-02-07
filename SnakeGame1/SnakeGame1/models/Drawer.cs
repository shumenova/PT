using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame1.models
{
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<point> body = new List<point>();// vector, body - nazvanie lista 

        public Drawer() { }
        public void Draw()
        {
            Console.ForegroundColor = color; // zakrashivaet zmeui
            foreach(point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            } 

        }
      

    }
}
