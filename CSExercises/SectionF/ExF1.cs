using System;

namespace CSExercises
{
    //A company records its monthly sales information in an array 
    //of size 12; where Sales[0] represents January sales, Sales[1] is 
    //February sales etc.  After entering the data the company wants to 
    //perform some queries on the data.  Write a program that would do the following:

    //a.Take in the sales for the 12 months.
    //  Note: You may use the array initialisation inside the program for storing these.
    //b.Print the month when Maximum Sales is recorded.
    //  Note: You may just print 0, 1 etc.  for Jan Feb etc… 
    //c.Print the month where Minimum Sales is recorded.
    //d.Print the average monthly sales for the year.

    //There are at least two ways to implement this:
    //1. Implement one method that calculate all the required info in one pass
    //2. Implement 3 methods each calculating different thing

    public class ExF1
    {
        public static void Main(string[] args)
        {
           // int[] sales = new int[12];
            //for (int n = 1; n <= 12; n++)
           // {
             //   Console.Write("Enter sales for month {0}: " , n);
               // sales[n] = Convert.ToInt32(Console.ReadLine());
            //}

//            int max = 0;
  //          int min = 0;
    //        double avg = 0;

      //      CalculateMinMaxAvg(sales, ref min, ref max, ref avg);

        //    Console.WriteLine("Maximum Sales: " + max);
          //  Console.WriteLine("Minimum Sales: " + min);
            //Console.WriteLine("Average Sales: " + avg);

            int[] MSales = new int[12]; // the size specified as '12' must correspondant with the loop-cycle below due to the storage of the input values in 'MonthlySales[m]'.

            int m = 0;

            for (m=0; m<12; m++) // AN ARRAY ALWAYS STARTS FROM '0'. LOOP MUST INCLUDE '0'. '13' is invalid as it doesn't correspondt to the number '12' spaces allocated above.
            {
                Console.Write("Input sales for month {0}: ", m+1);
                MSales[m] = Convert.ToInt32(Console.ReadLine());
            }

                   
            Console.WriteLine("Maximum Sales: " + MaxMonth(MSales));
            Console.WriteLine("Minimum Sales: "+ MinMonth(MSales));
            Console.WriteLine("Avg Sales: {0:C}", AvgSales(MSales));
      }


        public static void CalculateMinMaxAvg(int[] sales, ref int minMonth, ref int maxMonth, ref double avg)
        {
            //YOUR CODE HERE
            //Assign the result to minMonth, maxMonth and avg variable/parameter accordingly
            

        }

        public static int MinMonth(int[] MSales)
        {
            int MinSales = MSales[0];
            int MinMonth = 0;

            for (int i = 0; i <12; i++)
            {
                if (MSales[i] <= MinSales)
                {
                    MinSales = MSales[i];
                    MinMonth = i + 1;
                }

                /*for (int j = i + 1; j < 12; j++)
                {
                    if (MSales[i] < MSales[j])
                    {
                        MinSales = MSales[i];
                    }
                    else
                        MinSales = MSales[j];
                }
                MinMonth = MinSales;

                if (MinMonth > MinSales)
                { MinMonth = MinSales; }
            }*/
            }
            return MinMonth;
            
              /* switch (MinMonth)
                {
                    case 1: Console.WriteLine("January");
                        break;
                    case 2: Console.WriteLine("February");
                        break;
                    case 3: Console.WriteLine("March");
                        break;
                    case 4: Console.WriteLine("April");
                        break;
                    case 5: Console.WriteLine("january");
                        break;
                    case 6: Console.WriteLine("january");
                        break;
                    case 7: Console.WriteLine("january");
                        break;
                    case 8: Console.WriteLine("january");
                        break;
                    case 9: Console.WriteLine("january");
                        break;
                    case 10: Console.WriteLine("january");
                        break;
                    case 11: Console.WriteLine("january");
                        break;
                    case 12: Console.WriteLine("january");
                        break;
               */
                }           
        
        
        public static int MaxMonth(int[] MSales)
        {
            int MaxSales = MSales[0];
            int MaxMonth = 0;

            for (int i = 0; i < 12; i++ )
            {
                if (MaxSales <= MSales[i])
                {
                    MaxSales = MSales[i];
                    MaxMonth = i + 1;
                }
            }
                /*int MaxSales = 0;

                int MaxMonth = 0;

                for (int i = 0; i < 12; i++)
                {
                    for (int j=i+1; j<12; j++)
                    {
                        if (MSales[i] < MSales[j])
                        {
                            MaxSales = MSales[j];
                        }
                        else
                            MaxSales = MSales[i];
                    }
                if (MaxMonth<MaxSales)
                { MaxMonth = MaxSales; }

                }   */
                return MaxMonth;



        }

        public static double AvgSales(int[] MSales)
        {
            double sum = 0;
            double AvgS = 0;

            for (int i = 0; i < 12; i++ )
            {
                sum = sum + MSales[i];
            }

            AvgS = sum / MSales.Length;

                return AvgS;

        }


    }
}
