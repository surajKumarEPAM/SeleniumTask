using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticingStatic
{
    class StaticClassDemo
    {
        
        public static int x = 20;
        public int y = 30;
        public static void fun()
        {
            Console.WriteLine("This is fun1 in static class"+new StaticClassDemo().y);
        }
    }

    internal class Program
    {
        static int x = 10;

        public  void dispay()
        {
            Console.WriteLine(x+4);
        }
        static void Main(string[] args)
        {
            Program program= new Program();
           StaticClassDemo sc=new StaticClassDemo();
            Console.WriteLine(Program.x);
            Console.WriteLine(sc.y);
           // sc.fun();
          StaticClassDemo.fun();
            Console.ReadLine();
        }
    }
}
