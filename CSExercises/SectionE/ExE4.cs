using System;

namespace CSExercises
{
    //Given an integer as input write a C# program to determine 
    //whether the number is a Perfect Number or not.

    //A perfect number is one for which the sum of its factors
    //    (including number one) add up to the number itself.For example 
    //        number six is a perfect number because,
    //		6 = 1 + 2 + 3.


    public class ExE4
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (IPN(n)) //number 'n' is passed here into 'IsPerfectNumber' function
            {
                Console.WriteLine("{0} is a Perfect Number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number", n);
            }
        }

        public static bool IPN(int n) //'n' gets transported here through the method // declaring 'bool' is vital to check true/false
        {
          //  int sum = 0;
            // initialized sum for this step, doesn't change as a result of the loop
          

           // for (int i = 1; i < n; i++ )
             //   if (n % i == 0) //checks for values of 'i' that will divide 'n' and remaidner is '0'

               // { sum = sum + i; } //sum changes with every perfect divide that gives remainder as '0'
            
            //if (sum == n) //to check if the number input is 'perfect'

            //{ return true; }
            //else
            //{ return false; }          

            bool IPN = true;

            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                { sum = sum + i; }
            }
                if (sum != n)
                { IPN = false; }

                return IPN;
            
            }

        }
    }

