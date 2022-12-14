using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollArrayDemo
{
    internal class Program
    {

        public class Student : IComparable<Student>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }
            public int CompareTo(Student other)
            {
                if (this.Id > other.Id)
                    return 1;
                else if (this.Id < other.Id)
                    return -1;
                else
                    return 0;
            }

            public class Myclass : IComparer<Student>
            {
                public int Compare(Student x, Student y)
                {
                    if (x.Marks > y.Marks)
                        return 1;
                    else if (x.Marks < y.Marks)
                        return -1;
                    else
                        return 0;

                }
            }

            static void Main(string[] args)
            {
                Student s1 = new Student { Id = 3, Name = "Suraj", Marks = 200 };
                Student s2 = new Student { Id = 5, Name = "Radha", Marks = 800 };
                Student s3 = new Student { Id = 2, Name = "Ram", Marks = 600 };
                Student s4 = new Student { Id = 4, Name = "Mohan", Marks = 700 };
                Student s5 = new Student { Id = 1, Name = "Sita", Marks = 900 };

                List<Student> stu = new List<Student> { s1, s2, s3, s4, s5 };

                Myclass m1 = new Myclass();
                stu.Sort(m1);

                foreach (Student s in stu)
                    Console.WriteLine(s.Id + " " + s.Name + " " + s.Marks);
                Console.ReadLine();

            }

        }
    }
}
