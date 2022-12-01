using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskOnInterface
{
    interface IRestaurant
    {
        void eating();
        void ordering();
       
    }
    interface IHotel
    {
        void eating();
        void ordering();
    }
    class MyClass: IRestaurant,IHotel
    {
         void IRestaurant.eating() {
            Console.WriteLine("eating in Restaurant");
        }
         void IHotel.eating()
        {
            Console.WriteLine("eating in Hotel");
        }
         void IRestaurant.ordering() {
            Console.WriteLine("Ordering in Restaurant");
        }
        void IHotel.ordering()
        {
            Console.WriteLine("Ordering in hotel");
        }
    }
    internal class Program
    {
        //Eat and order
        
        static void Main(string[] args)
        {
            IHotel myhotel= new MyClass();
            myhotel.eating();
            myhotel.ordering();
            IRestaurant myrestaurant = new MyClass();
            myrestaurant.eating();
            myrestaurant.ordering();
            Console.ReadLine();
            
        }
    }
}
