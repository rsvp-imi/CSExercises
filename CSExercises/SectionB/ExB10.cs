using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            Console.WriteLine("Input the length of sides a, b, and c");

            string a1 = Console.ReadLine();
            double a = Convert.ToDouble(a1);
            string b1 = Console.ReadLine();
            double b = Convert.ToDouble(b1);
            string c2 = Console.ReadLine();
            double c = Convert.ToDouble(c2);
                           
            double side = (a + b + c) / 2;

            if (side < c)
                Console.WriteLine("The input lenghts are invalid. AREA cannot be calculated");

            double A = Math.Sqrt(side * (side - a) * (side - b) * (side - c));

                                 
            
            Console.WriteLine("The AREA of the Triangle is {0:0.#}", AREA(A));

            //YOUR CODE HERE
        }

        public static double AREA(double R)
        {
            //YOUR CODE HERE
            return (R);
        }
    }
}