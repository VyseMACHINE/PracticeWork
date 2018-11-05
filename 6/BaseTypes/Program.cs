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
            //6.Дано четырехзначное число. Найти:
            //a.сумму его цифр;
            //b.произведение его цифр.
            int x;
            Console.WriteLine("Введите двузначное число: ");
            x = int.Parse(Console.ReadLine());
            if (x >= 1000 && x <= 9999)
            {
                Console.WriteLine(x);
                Console.WriteLine("a.сумма его цифр: " + (x / 1000 + x / 100 % 10 + x % 100 / 10 + x % 10));
                Console.WriteLine("b.произведение его цифр: " + ((x / 1000) * (x / 100 % 10) * (x % 100 / 10) * (x % 10)));

            }
            else
            {
                Console.WriteLine("Вводите четырехзначное число");
            }

        }
    }
}
