using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input Temperatue");
            string C = Console.ReadLine();
            double Temp = Convert.ToDouble(C);


            Console.WriteLine("Temperature in Farenheit is {0:0}", (CtoF(1.8 * Temp)+32));
        }     

        public static double CtoF(double F)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            return(F);

        }
    }
}
