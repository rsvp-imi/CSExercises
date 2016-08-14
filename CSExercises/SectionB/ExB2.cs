using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input any number");
            string Str = Console.ReadLine();
            double Dbl = Convert.ToDouble(Str);

            double SqrDbl = Math.Sqrt(Dbl);

            Console.WriteLine("{0:0.00#}",sqroot(SqrDbl));
        }

        public static double sqroot(double x)
        {
            return (x);
        }
    }
}

