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
            //8.Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
            //a.не X и не Y;
            //b.X или(не X и Y);
            //c.  (не X и Y) или Y.
            bool x, y;

            Console.WriteLine("(true/false) x = ");
            x = bool.Parse(Console.ReadLine());
            Console.WriteLine("x = " + x);
            Console.WriteLine("(true/false) y = ");
            y = bool.Parse(Console.ReadLine());
            Console.WriteLine("y = " + y);

            Console.Write("a.не X и не Y;\t");
            if (!x && !y)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.Write("b.X или(не X и Y);\t");
            if (x || (!x && !y))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.Write("c.  (не X и Y) или Y.\t");
            if ((!x && y) || y)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
