using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Дано двузначное число. Найти:
            //a.число десятков в нем;
            //b.число единиц в нем;
            //c.сумму его цифр;
            //d.произведение его цифр
            int x;
            Console.WriteLine("Введите двузначное число: ");
            x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 99)
            {
                Console.WriteLine(x);
                Console.WriteLine("a.число десятков в нем: " + (x / 10));
                Console.WriteLine("b.число единиц в нем: " + (x % 10));
                Console.WriteLine("c.сумму его цифр: " + (x / 10 + x % 10));
                Console.WriteLine("d.произведение его цифр: " + ((x / 10) * (x % 10)));
            }
            else
            {
                Console.WriteLine("Вводите двузначное число");
            }

        }
    }
}
