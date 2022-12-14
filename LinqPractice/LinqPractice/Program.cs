using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Runtime.Remoting.Channels;
using System.Xml.Linq;

namespace LinqPractice
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //public Address Location { get; set; }
        public List<String> programming { get; set; }   
    }
    class Address
    {
        public String city;
        public String state;
        public String zipcode;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 4, 5 };
            List<string> stringList = new List<string>() { "Ankesh", "Kumar", "is ", "a" };
            //var check=list.All(x => x <6);
            //var check = list.Any(x => x < 2);
            //var check = list.Contains(2);
            //var check = stringList.Contains("Kumr");
            var check = (from l in stringList select l).Contains("Kumar");

            Console.WriteLine(check);
            //IEnumerable<int> a = from element in list where element > 2 select element;
            

          
            //IEnumerable<int> b=list.Where(x => x >=2 ).Select(x=>x);
            //IQueryable<int> query = list.AsQueryable().Where(x => x <5).Select(x=>x+100);
            //foreach (int i in query)
            //    Console.WriteLine(i);
            List<User> users = new List<User>();
            List<int> myList=new List<int>() { 11,2,41,5,9,12,7};
            List<Address> addresses = new List<Address>()
            {
                new Address(){ city="N",state="N",zipcode="N",},
                new Address(){ city="m",state="m",zipcode="m"}
            };
            //Console.WriteLine("size is "+addresses.Count);
            users.Add(new User() { Name = "Rakesh", Id = 2, Email = "rakeshcse@gmail.com", programming = new List<String> { "C#", "C" } });
            users.Add(new User() { Name = "Radha", Id = 4, Email = "radha@gmail.com", programming = new List<String> { "java", "python", "C" } });
            users.Add(new User() { Name = "Anuradha", Id = 54, Email = "anuradha@gmail.com", programming = new List<String> { "HTML", "C#" } });
            users.Add(new User() { Id = 1, Name = "Ankesh", Email = "suraj@gmail.com", programming = new List<String> { "javaScript", "Linq", "Nodejs" } });
            users.Add(new User() { Name = "Suraj", Id = 3, Email = "surajkumar@gmail.com", programming = new List<String> { "F#", "rubi", "C++", "CSS" } });

            //var name1 = myList.Select(x => x).Reverse();

            //var name1 = (from num in myList select num).Reverse();

            //foreach (var item in name1)
            //{
            //    Console.WriteLine(item);
            //}


            //var name1 = myList.Where(x => x > 5).OrderByDescending(x => x);

            //var name1 = from num in myList where num > 7 orderby num descending select num;

            //foreach (var item in name1)
            //{
            //    Console.WriteLine(item);
            //}
            //List<Object> users2 = new List<Object> { "Ankesh", 1,9, "Suraj", "3", "Radha" ,8};
            ////var name = users2.OfType<int>().Where(x=>x<3);
            //var name1= from id in users2 where id is int && (int)id>2  select id;

            //var pro=users.Select(x => x.programming);
            //var pro2 = users.SelectMany(x => x.programming);
            //Console.WriteLine("Printijng select ");
            //foreach (var item in name1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Printijng selct many");
            //foreach (var item in pro2)
            //{
            //    Console.WriteLine(item);
            //}
            //List<String> name = new List<String> { "Ankesh", "Radha", "Shyam", "Annu" };
            //var myName=name.Select(x => x);
            //Console.WriteLine("pringting select");

            //foreach (var item in myName)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("pringting select many");
            //var myName2=name.SelectMany(x => x);

            //foreach (var item in myName2)
            //{
            //    Console.WriteLine(item);
            //}
            //var pq = users.Select(x => new
            //{
            //    NameX = x.Name,
            //    IdX = x.Id
            //});

            //foreach (var item in pq)
            //{
            //    Console.WriteLine("The name is "+item.NameX +" the id is "+item.IdX);
            //}

            //var xt = (from us in users where us.Id > 2 select new User { Email = us.Email, Name = us.Name }).ToList();
            //foreach (var item in xt)
            //{
            //    Console.WriteLine("The email is "+item.Email +" and name is "+item.Name);
            //}
            //var allNames = from user in users select user.Name;

            //foreach (var name in allNames)
            //{
            //    Console.WriteLine(name);
            //}
            //var allEmailList = users.Select(x => x.Email);
            //foreach (var email in allEmailList)
            //{
            //    Console.WriteLine(email);
            //}
            //var userList = from user in users where user.Id > 2 select user;

            //foreach (var user in userList)
            //{
            //    Console.WriteLine(user.Name);
            //}
            //var allUserList = users.Where(x => x.Id > 3).Select(x => x.Name);
            //foreach (var user in allUserList)
            //{
            //    Console.WriteLine("name of person having id greater than 2 is" + user);
            //}

            //var userDetails = from user in users where user.Id == 1 select new { personName = user.Name, personEmail = user.Email };
            //foreach (var user in userDetails)
            //{
            //    Console.WriteLine("the name is :" + user.personName + " and email is " + user.personEmail);
            //}

            //var allUsersList= users.Where(x => x.Id==1).Select(x => x.Name);

            //// int[][]= arr = new int[2][] [ { 1, 2 }, { 2, 4 } ];
            //int[,] ar = { { 1, 2, 3 },{ 2, 24, 5 } };

            //int[][,]arr =
            //{
            //    new int[,] {{ 1, 2,3 } },
            //    new int[,] {{1,2 },{2,3 } }
            //};
            //List<int> list = new List<int>();
            //list.Add(3);
            //ArrayList arrayList = new ArrayList();
            //Queue<> queue =new Queue<int>();
            //queue.Enqueue(1);

            //Queue q=new Queue();
            //q.Enqueue(userDetails);

            //Stack st = new Stack();
            //st.Push(3);
            //st.pop();

            //Stack<int> st = new Stack<int>.();
            //st.Push(1);
            //st.Push(-13);
            //st.Pop();

            //Hashtable ht=new Hashtable();
            //ht.Add("Ank", 2);
            //ht.Add("Rit", 5);
            //ht.Remove("Ank");

            //Dictionary<String,int> map= new Dictionary<String,int>();
            //map.Add("a", 10);
            //map.Add("b", 20);
            //map.Add("c", 30);

            //foreach (var keys in map.Keys)
            //{
            //    Console.WriteLine(keys);
            //}
            //foreach(var value in map.Values) { Console.WriteLine(value); }  
            Console.ReadLine();
        
        } 
    }
}
