using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{
    class Program
    {
        static bool isPrime(int s) // принимаем значение 
        {
            int cnt = 0; // создаем счетчик
            for(int j=2; j<= Math.Sqrt(s); j++) // ппробегаемся 
            {
                if(s%j==0) // условие 
                {
                    cnt++; // продолжение условия
                }
            }
            return (cnt == 0) && (s != 1); // возвращаем результат 
        }
        static void Main(string[] args)
        {
            string enterDigit = Console.ReadLine(); // считываем число
            string[] enteredDigitArray = enterDigit.Split(' '); // создаем массив
            int arrLenght = enteredDigitArray.Length; // узнаем размер массива 
            for(int i =0; i < arrLenght; i++) // пробегаемся по массиву
            {
                string strElement = enteredDigitArray[i];  // записываем число
                int enterSingle = Int32.Parse(strElement); // переводим число
                bool prime = isPrime(enterSingle); //  передаем значение
                if (prime) // создаем условие 
                {
                    Console.WriteLine("the number" + enterSingle + "is prime"); // вывод результата на консоль
                }
                else
                {
                    Console.WriteLine("the number" + enterSingle + "isn't prime");

                }
            }
            Console.ReadKey();
        }
    }


}
