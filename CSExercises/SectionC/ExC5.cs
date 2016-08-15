using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input three digits");
            int digits = Convert.ToInt32(Console.ReadLine());
                              
            bool Status = IsArmstrongNumber(digits);
            

            Console.WriteLine("Is an Armstrong Number {0}", Status);
            
            //YOUR CODE HERE
        }
        
        public static bool IsArmstrongNumber(int digits)
        {
            int x = digits/100;
            int y = digits%100/10;
            int z = digits%10;
            bool result;
            
            if ((Math.Pow (x,3))+ (Math.Pow(y,3))+ (Math.Pow(z,3))== digits)
            { result = true; }

            else
            { result = false; }


            //YOUR CODE HERE
            return result;

        }
    }
}