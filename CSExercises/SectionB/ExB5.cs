using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input X to calculate Y");
            string C = Console.ReadLine();
            double X = Convert.ToDouble(C);


            Console.WriteLine("Value from formula is {0:0}", XtoY((5 * X * X) - (4 * X)) + 3);
        }

        public static double XtoY(double Y)
        {
            
            return (Y);

        }
    }
}
