using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can use ExE4.IsPerfectNumber() method here

            for (int n=1; n<=1000; n++)
            {
                int sum = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        sum = sum + i;
                }
                if (sum ==n)
                
                    Console.WriteLine("is a perfect number {0}", n);
                
                }
            }

        }
    }

