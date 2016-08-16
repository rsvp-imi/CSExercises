using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        //   Console.WriteLine("Welcome to the Bank of ISS");

         

           // Console.Write("Enter your PIN:");
           // int PIN = Convert.ToInt32(Console.ReadLine());

        

            //for (int counter = 0; counter <= 3; counter++ )
            //{ 
                //if (PIN != 123456)
               // {
                  //  Console.WriteLine("Incorrect PIN. Please try again");
                //}
              //  }
              //  else
            //        Console.WriteLine("PIN accepted. You can access your account now.");

             Console.WriteLine("Welcome to the Bank of ISS");

         int counter = 0;
            bool isPINAccepted = false;

            do
            {
            Console.Write("Enter your PIN:");
            int PIN = Convert.ToInt32(Console.ReadLine());
                             
             
                if (PIN == 123456)
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    isPINAccepted= true;
                }
                 else
                if (counter <3)
                    {Console.WriteLine("Incorrect Pin. Please try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too many wrong PIN entries. Your Account is locked.");
                    }
                    
                }
                while (isPINAccepted && counter <3);
                
            }
            }   
            }
    