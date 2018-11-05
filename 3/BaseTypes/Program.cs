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
            int centimetres, meters;
            int centimetresInMeters = 100;
            Console.WriteLine("Enter centimetres: ");
            centimetres = int.Parse(Console.ReadLine());
            meters = centimetres / centimetresInMeters;
            Console.WriteLine("Full metres in " + centimetres + "sm = " + meters + "m");
        }
    }
}
