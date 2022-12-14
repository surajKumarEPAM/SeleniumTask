using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOverriding
{
    public class Circle
    {
        public void fun1(int a,int b)
        {
            Console.WriteLine(a + "Adding two numbers fun1 paraent" + b);
        }
        public virtual  void fun2(int a, int b)
        {
            Console.WriteLine(a+"Sub two number fun2 paraent "+b);
        }
        public void fun3(int a, int b)
        {
            Console.WriteLine(a+"Multiplying two number");
        }
    }
    public class Cylinder : Circle
    {
        public void fun1(int a, int b, int c)
        {
            Console.WriteLine("three paramenter in child class");
            base.fun1(1,2);
            base.fun2(1, 2);

            
        }
        public void fun2(int a, int b)
        {
            Console.WriteLine("This is the overriden class in child class");
        }
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder();
            c.fun1(1, 2);
            c.fun1(1,2,3);
            c.fun2(2, 3);
            Console.ReadLine();

        }
    }
}
