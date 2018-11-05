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
            //7.В трехзначном числе x зачеркнули его вторую цифру.
            // Когда к образованному при этом двузначному числу справа 
            // приписали вторую цифру числа x, то получилось число 456.Найти число x.
            int x = 456;
            Console.WriteLine("x = " + x);
            x = (x % 10) * 100 + x / 10;
            Console.WriteLine("x = " + x);
        }
    }
}
