using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 5, 0, 7, 8 };
            String filepath = "C:\\Users\\Suraj_Kumar\\MyProjects\\DotNet\\MyFramework\\MyTestProject";
            //File.Open(filepath,FileMode.Open);
            try
            {
                //int div = numbers[0] / numbers[3];
                Console.WriteLine(numbers[12]);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exception meassage1 : " + ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception message2 : "+ex.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block for cleanup the resources");
            }
           
            Console.ReadLine();
        }
    }
}
