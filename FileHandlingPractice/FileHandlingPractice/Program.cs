using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String pathSource = "C:\\Users\\Suraj_Kumar\\Desktop\\MyFile.txt";

            //String pathTarget = "C:\\Users\\Suraj_Kumar\\Downloads\\AFileHandLing\\xyz.txt";
            //if (File.Exists(path)) { Console.WriteLine("yes this file is present"); }
            //else { Console.WriteLine("This file is not there"); }

            //File.WriteAllText(path, "This is Ankesh Kumar zxc

            //File.Delete(path);

            //File.Copy(pathSource,pathTarget,true);

            //File.AppendAllText(pathSource, "This is appended");

            //Console.WriteLine(File.GetCreationTime(pathSource));

            // File.Move(pathSource, pathTarget);

            //File.Create(pathSource);

            //File.ReadAllText(pathSource);

            //String[] str=File.ReadAllLines(pathSource);

            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            String pathSource = "C:\\Users\\Suraj_Kumar\\Desktop\\MyFolder1";
            //String pathTarget = "C:\\Users\\Suraj_Kumar\\Downloads\\AFileHandLing\\xyz";

            //DirectoryInfo directoryInfo = new DirectoryInfo(pathSource);
            // directoryInfo.Create();
            //directoryInfo.MoveTo(pathSource);
            //DirectoryInfo a=directoryInfo.Parent;
            //directoryInfo.CreateSubdirectory("SubFolder");


            //DirectoryInfo[] f = directoryInfo.GetDirectories();
            //foreach (DirectoryInfo f2 in f)
            //{
            //    Console.WriteLine(f2);
            //}
            //DirectoryInfo fx=directoryInfo.Root;
            //Console.WriteLine(fx);
            //FileInfo[] ft=directoryInfo.GetFiles();
            //foreach (FileInfo f2 in ft)
            //{
            //    Console.WriteLine(f2);
            //}

            //FileStream fs = new FileStream(pathSource, FileMode.Create,FileAccess.Write);

            //fs.Close();

            //using (FileStream fs = new FileStream(pathSource, FileMode.Append, FileAccess.Write))
            //{
            //    using(StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine("This is by stream Writer Ankesh");

            //    }
            //}

            using (FileStream fs = new FileStream(pathSource, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr=new StreamReader(fs))
                {
                    //String str= sr.ReadToEnd();
                    // Console.WriteLine(str);
                    //String str = sr.ReadLine();
                    //Console.WriteLine(str);
                    String str = "";
                    while((str=sr.ReadLine())!=null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }


                Console.ReadLine();


        }
    }
}
