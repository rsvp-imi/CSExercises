using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input distance travelled");

            string Dt = Console.ReadLine();
            double D = Convert.ToDouble(Dt);

            double Ft = (2.40 + (D * 0.40));

            Console.WriteLine("Total fare is ${0:0.#}", Fare(Ft)); //YOUR CODE HERE
        }

        public static double Fare(double F)
        {
            //YOUR CODE HERE
            return (F);

        }
    }
}
