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
            int x, y;
            Console.WriteLine("Enter X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X =  " + x);
            y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("7 * x * x - 3 * x + 4  = " + y);
        }
    }
}

