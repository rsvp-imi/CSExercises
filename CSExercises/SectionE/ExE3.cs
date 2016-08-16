﻿using System;

namespace CSExercises
{
    public class ExE3
    {
        //Given an integer as input determine whether the number 
        //is a prime number or not.  Your program should output “Prime” 
        //    or “Not Prime” as the case may be.

        //A Prime Number is one which is only divisible by one and itself.

        //Consider how the efficiency of the program can be improved. 
        //Normally the order of complexity is proportional to the number of 
        //    times a loop is executed.A more formal definition of 
        //    “Analysis of Algorithms” will be dealt in a later course.

        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
                       
                   
        if (IsPrime(n))
          {
              Console.WriteLine("Prime");
            }
         else
          {
               Console.WriteLine("Not Prime");
          }
       }

       public static bool IsPrime(int n)
          {
         

                if (n < 2)
            {
                return false;
            }

            bool isPrime = true;
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime; //   return true;     <<-- this is wrong as it should be return IsPrime and not return true

}


        }
    }

