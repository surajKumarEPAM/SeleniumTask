using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
    class LowBalanceException:Exception
    {
        //public LowBalanceException() 
        //{

        //    Console.WriteLine("Exception thrown");
        //}
        public override string ToString()
        {
            return "Low balance exception message";
        }

    }
    class User 
    {
        public static int amount = 3000;
        public void WithdrawProcess(int withdrawAmount)
        {
            if (amount > withdrawAmount) { Console.WriteLine("Successfull Transcation with balance "+(amount-withdrawAmount)); }
            else
            {
                throw new LowBalanceException();
            }
        }
    }
    internal class ExceptionDemo
    {
        public static void Main(String[] args)
        {
          
            int withdraw = 4000;
            User user =new User();
            try
            {

                user.WithdrawProcess(withdraw);
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadLine();


        }
    }
}
