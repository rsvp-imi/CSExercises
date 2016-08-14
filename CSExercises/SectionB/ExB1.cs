using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input any number");
            string Str = Console.ReadLine();
            double Dbl = Convert.ToDouble(Str);

            double SqrDbl = Math.Sqrt(Dbl);

            Console.WriteLine(sqroot(SqrDbl));
        }

        public static double sqroot(double x)
        {
            return (x);
        }
    }
}








        
    

