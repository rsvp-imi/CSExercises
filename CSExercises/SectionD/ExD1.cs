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
        
         int number = 0;

         do
         {
             Console.WriteLine("Input number between <1-100> to find the secret number");
                          number = Convert.ToInt32(Console.ReadLine());
                       
             if (number !=88)
             { Console.WriteLine("Try again!"); }
                                       
         }
         while (number != 88); 
            Console.WriteLine("Congrats! You guessed it!");

        }
    }
}
