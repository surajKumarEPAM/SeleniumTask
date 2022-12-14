using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumrationPratice
{
    enum Days
    {
        Monday, Tuesday, Wednesday, Thrusday, Friday
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Days d = (Days)1;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
