using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input distance travelled");

            string Dt = Console.ReadLine();
            double D = Convert.ToDouble(Dt);

            double Ft = (2.40 + (D * 0.40));
                     
            Console.WriteLine("Total fare is {0:C}", Fare (Ft)); //YOUR CODE HERE
        }

        public static double Fare(double F)
        {
            //YOUR CODE HERE
            return (F);

        }
    }
}
