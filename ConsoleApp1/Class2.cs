using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace Rcard_ns
{
    class Rcard
    {       
            public int vcard_number;
            public string userName="Jack";
            private int password;
            public int balance=500;
           
            public int createCardNumber1()
            {
                Random rnd1 = new Random();
                int card_number1 = rnd1.Next(1000, 2500);                
                return card_number1;
            }
        public int createCardNumber2()
        {
            Random rnd2 = new Random();
            int card_number2 = rnd2.Next(2500, 5000);
            return card_number2;
        }
        public int createCardNumber3()
        {
            Random rnd3 = new Random();
            int card_number3 = rnd3.Next(5000, 7500);
            return card_number3;
        }

        public int createCardNumber4()
        {
            Random rnd4 = new Random();
            int card_number4 = rnd4.Next(7500, 9999);
            return card_number4;
        }


        public int createPassword()
            {           
                Random rnd = new Random();
                int pin = rnd.Next(100, 999);
                password = pin;
                return password;
            }
       public DateTime date()
        {
            DateTime value = new DateTime(2018, 1, 18);
            return value;
        }  

    }
    
    }

