using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
    internal class AnotherExceptionDemo
    {
        public static  int fun1(int x,int y)  
        {
            //try
            //{
            //    return (x / y);
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine("resolved exception in fun1");
            //}
            return (x/y);
            
        }
        public static int fun2(int a,int b)
        {
           
            return fun1(a, b);
        }
        public static void Main(String[] args)
        {
            int a = 2;
            int b = 0;
            // int c =fun2(a,b);
            try
            {
                int c = a / b;
            }
            finally
            {
                Console.WriteLine("Finally runs");
            }
       //   Console.WriteLine("the value is "+c);
            Console.ReadLine();
        }
    }
}
