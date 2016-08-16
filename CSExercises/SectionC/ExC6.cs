using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Input Qty for TV");
            int tvQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Qty for DVD");
            int dvdQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Qty for MP3");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());

            int TV = 900;
            int DVD = 500;
            int MP3 = 700;

            int TotalCost = (TV * tvQty) + (DVD * dvdQty) + (MP3 * mp3Qty);

          if (TotalCost > 5000)
            {
                double discount = CalculateDiscount(TotalCost);

                Console.WriteLine("Your Total Price of order is {0} and after discount is {1}.", TotalCost, discount); }

            else
            {
                Console.WriteLine("Your total cost is {0:C}, no discount.", TotalCost);
            }
        }
        
        public static double CalculateDiscount(int tvQty, int dvdQty, int mp3Qty)
        {
           int TV = 900;
            int DVD = 500;
            int MP3 = 700;

            int TotalCost = (TV * tvQty) + (DVD * dvdQty) + (MP3 * mp3Qty);

            double D1 = 10 / 100;
            double D2 = 15 / 100;


            if (TotalCost > 5000 && TotalCost <= 10000)
            { discount = D1 * TotalCost; }

            else if (TotalCost > 10000)
            { discount = D2 * TotalCost; }

                //YOUR CODE HERE
                return discount;



        }
    }
}