using System;
using Rcard_ns;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rcard mycard = new Rcard();
            Console.WriteLine("Card number: "+mycard.createCardNumber1()+ "-"+ mycard.createCardNumber2() + "-"+ mycard.createCardNumber3() + "-"+ mycard.createCardNumber4());
            Console.WriteLine("Card password: "+mycard.createPassword());
            Console.WriteLine("User name: "+mycard.userName);
            Console.WriteLine("Card balance: "+mycard.balance);
            Console.WriteLine("Card Date: " + mycard.date());
            Console.ReadLine();
        }
    }
}