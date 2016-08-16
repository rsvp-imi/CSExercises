using System;

namespace CSExercises
{
    //Write a program to print all numbers between 1 and 10 with the values 
    //of its inverse, square root and square as below:

    //NO            INVERSE         SQUARE ROOT    SQUARE
    //------------------------------------------------------
    //1.0             1.0             1.0             1.0
    //2.0             0.5             1.414           4.0
    //3.0             0.333           1.732           9.0
    //4.0             0.25            2.0             16.0
    //5.0             0.2             2.236           25.0
    //6.0             0.167           2.449           36.0
    //7.0             0.143           2.646           49.0
    //8.0             0.125           2.828           64.0
    //9.0             0.111           3.0             81.0
    //10.0            0.1             3.162           100.0

    public class ExE2
    {
        public static void Main(string[] args)
        {
            string Number = "";
            string Inverse = "";
            string SquareRoot = "";
            string Square = "";

            Console.WriteLine("Number{0,5} Inverse{0,0} Square Root{0,1} Sqaure{0,1}", Number, Inverse, SquareRoot, Square);

            double No;

            for (No = 1; No <= 10; No++)
            {
                double Inv = (1 / No);
                double Sqrt = Math.Sqrt(No);
                double Sqr = Math.Pow(No, 2);

                Console.WriteLine("{0,5:0.00#} {1,10:0.00#} {2,10:0.00#} {3,10:0.00#}", No, Inv, Sqrt, Sqr);
            }

            
        }
    }
}
