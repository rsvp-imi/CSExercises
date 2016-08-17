using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can call ExE3.IsPrime method (from previous exercise) 
            //to check whether a number is a prime or not.

            
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine (ExE3.IsPrime(n));

            for (int n = 5; n<=1000; n++)

                {
                    int sum = 0;

                for (int i = 2; i<n; i++)
                {
                   

                    if (n % i == 0)
                       sum = (sum + 1);
                }
                    if (sum == 0)

                        Console.WriteLine (n);
                }
                


        }
       
    }
}
