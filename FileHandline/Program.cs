using System;
using System.IO;
using System.Text;
namespace FileHandline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Suraj_Kumar\Desktop\myFile3";
           using(FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                   // String line = "";
                    //while((line=sr.ReadLine())!=null)
                        //Console.WriteLine(line);
                    //Console.WriteLine(line);
                    Console.WriteLine(sr.ReadToEnd());
                    Console.WriteLine(sr.Peek());
                }
            }
             Console.ReadLine();
        }
    }
}
