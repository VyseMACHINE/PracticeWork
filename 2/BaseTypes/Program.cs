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
            double r, c, s;
            double pi = 3.1415;
            Console.WriteLine("Enter R: ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("C = 2* pi* r");
            Console.WriteLine("S = pi*r*r");
            c = 2 * pi * r;
            s = pi * r * r;
            Console.WriteLine("C = " + c);
            Console.WriteLine("S = " + s);
        }
    }
}
