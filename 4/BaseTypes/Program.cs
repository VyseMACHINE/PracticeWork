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
            int days = 234;
            int daysInWeek = 7;
            int weeks = days / daysInWeek;
            Console.WriteLine("in " + days + " full " + weeks + " weeks");
        }
    }
}
