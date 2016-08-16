using System;

namespace CSExercises
{
    //Given a number find out its factorial.  

    //Write two different C# program variations for 
    //the problem:
    //a.Using increment counter
    //b.Using a decrement counter.

    //Carefully study the similarities and differences 
    //between the two approaches.
    //List the conditions, if any, under which your program 
    //is likely to fail

    public class ExE1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact1 = CalculateFactorialInc(n);
            Console.WriteLine(fact1);

            int fact2 = CalculateFactorialDec(n);
            Console.WriteLine(fact2);
        }

        public static int CalculateFactorialInc(int n)
        {
            int Inc = 1;

            for (int d = 1; d <=n; d++ )
            {
                Inc = d * Inc;
            }

                //YOUR CODE HERE
                return Inc;
        }

        public static int CalculateFactorialDec(int n)
        {
            int Dec = 1;

            for (int digit = n; digit>= 1; digit-- )
            {
                Dec = digit * Dec;
            }
                //YOUR CODE HERE
                return Dec;


        }


    }
}
