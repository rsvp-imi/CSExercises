using System;

namespace CSExercises
{
    ///Write a C# program that would keep prompting you to enter an integer number over and over again until you enter the number 88. If you enter 88 the computer should say: 
  	//	“Lucky you…” 
    //and exit the program.


    public class ExD1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            int num = 0; ////
            do////
            {////
                Console.Write("Enter a number (1-100): ");////
                num = Convert.ToInt32(Console.ReadLine());////
            } while (num != 88);////

            Console.WriteLine("Lucky you");////

        }
    }
}
