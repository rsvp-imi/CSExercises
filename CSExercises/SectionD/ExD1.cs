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
         Console.WriteLine("Input number between <1-100> to find the secret number");
         int number = 0;

         do
         {
             Console.WriteLine("Try again!");
             number = Convert.ToInt32(Console.ReadLine());
         }
         while (number != 88); 
            Console.WriteLine("Congrats! You guessed it!");

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
