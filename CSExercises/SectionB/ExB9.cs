using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input distance travelled");

            string Dt = Console.ReadLine();
            double distance = Convert.ToDouble(Dt);

            double fare = Fare(distance);
            Console.WriteLine("Total fare is {0:C}", fare); //YOUR CODE HERE
            
        }

        public static double Fare(double distance)
        {
            double Ft = (2.40 + (distance * 0.40));
            double TFare = Math.Ceiling(Ft * 10) / 10.0;

            return (TFare);

        }
    }
}
