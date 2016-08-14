using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Input x1, y1, x2, and y2");

            string a1 = Console.ReadLine();
            double x1 = Convert.ToDouble(a1);
            string b1 = Console.ReadLine();
            double y1 = Convert.ToDouble(b1);
            string a2 = Console.ReadLine();
            double x2 = Convert.ToDouble(a2);
            string b2 = Console.ReadLine();
            double y2 = Convert.ToDouble(b2);

            double T = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("Distance Travelled is {0:0.00#}", Distance(T));

            //YOUR CODE HERE
        }

        public static double Distance(double D)
        {
            //YOUR CODE HERE
            return (D);
        }
    }
}
