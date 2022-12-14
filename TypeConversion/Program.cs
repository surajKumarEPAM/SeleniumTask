using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long l = 23;
            //float f = 999999999999999999999f;
            //f = l;      Compiles successfully
            //l = f;     //Error
            //Console.WriteLine(f);

            //byte s = 152;
            //byte k = 2;
            //s = s + k;            //Error ???????????????????
            //Console.WriteLine(s);


            //Console.WriteLine(float.MaxValue - long.MaxValue);    //got 3.402823E+38 which is Huge diff
            //Implicit conversion
            //int a = 111;
            //float b = a;
            //Console.WriteLine(b);

            //Not convertible
            //String str = "1011";
            //int k =(int) str;

            //Boxing and Unboxing 
            //int a = 10;
            //object b = a;
            //int c = (int)b;
            //Console.WriteLine(c);
            //Console.WriteLine(a.);
            //Console.WriteLine(b.);

            //Convert method
            //String str = "121";
            //String str1 = "Suraj";
            //int b=Convert.ToInt32(str);       // so must be within try bolck
            //Console.WriteLine(b);
            //Console.WriteLine(Convert.ToInt32(str1));

            //parse method
            //String str = "123";
            //try
            //{
            //    int i=int.Parse(str);
            //    Console.WriteLine(i);
            //}

            //catch(Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            int a=2147483647;
            int b = a - 2;
            Console.WriteLine("Value of b is " + b);
            Console.ReadLine();
            Console.ReadLine(); 
        }
    }
}
