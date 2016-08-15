using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pleae enter the distance travelled in km");
            
            double distance = Convert.ToDouble(Console.ReadLine());

            double fare = CalculateFare(distance);

            Console.WriteLine("Total fare is {0:C}", fare);

            //Your code here            
        }

        public static double CalculateFare(double distance)
        {
            double fare = 0;

            if (distance >=0 && distance <=0.5)
            { fare = 2.40; }

            else if (distance >0.5 && distance<=9.0)
            { fare = (2.40 + ((distance-0.5)*10 * 0.04)); }

            else if (distance >9.0)
            {fare = (2.40 + (85*0.04) + ((distance-9)*10*0.05));}

            double TFare = Math.Ceiling(fare * 10) / 10.0;

            //YOUR CODE HERE
            return TFare;



        }
    }
}