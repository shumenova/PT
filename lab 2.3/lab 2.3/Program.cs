using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Desktop"; // путь для нахождения папки
            DirectoryInfo dir = new DirectoryInfo(path); // информация о папке
            int cnt = dir.GetFiles().Length; // количество  файлов в папке
            Console.WriteLine(cnt + "files are located in" + dir.FullName); // вывод на экран

            Stack<DirectoryInfo> items = new Stack<DirectoryInfo>(); // создаем стек
            foreach (DirectoryInfo ndir in dir.GetDirectories()) // пробегаемся по массиву
            {
                items.Push(ndir); // добавляем в стек
            }
            while (true) // задаем условие 
            {
                if (items.Count > 0) // условие по стек не пустой
                {
                    DirectoryInfo npopDir = items.Pop(); // поп самый первый
                    cnt = npopDir.GetFiles().Length; // считываем количество элементов 
                    Console.WriteLine(cnt + "files are located in" + npopDir.FullName);

                    DirectoryInfo[] npopDirItems = npopDir.GetDirectories(); // записываем в массив количество файлов 
                    foreach (DirectoryInfo npopDirIt in npopDirItems) // пробегаемся по массиву 
                    {
                        items.Push(npopDirIt); // пробегаемя по файлам и добавляем  их в стек
                    }
                }
            }
        }
        static void Search(DirectoryInfo dir)
        {
                int cnt = dir.GetFiles().Length;
                Console.WriteLine(cnt + "files are located in" + dir.FullName);
                foreach (DirectoryInfo ndir in dir.GetDirectories())
                {
                    Search(ndir);
                }
        }

        
    }
}
