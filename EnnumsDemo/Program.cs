using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnnumsDemo
{
    public enum Days
    {
        Mon,
        Tue,
        Wed,
        Thr,
        Fri,
        Sat,
        Sun
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.WriteLine("This is Ram");


            // Days d = (Days)1;
            // Console.WriteLine(d);

            //Days d = Days.Thr;
            //Console.WriteLine((int)d);

            //foreach(string i in Enum.GetNames(typeof(Days)))
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (int i in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine(i);
            //}



            Console.ReadKey();
            
        }
    }
}
