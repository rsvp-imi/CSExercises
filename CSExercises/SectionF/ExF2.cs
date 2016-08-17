using System;

namespace CSExercises
{
    //Write a C# program that would sort a numeric array in descending order 
    //using the simplified selection sort method described.

    //At the end of each pass print out the array to know the progress!

    public class ExF2
    {
        public static void Main(string[] args)
        {
            int[] list = new int[] {86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79};

            /* Sort(list);

            for (int k = 0; k < list.Length; k++)
            {
                Console.Write(list[k] + " ");
            }
            Console.WriteLine();*/

            for (int n = 0; n < list.Length; n++) // 'for-loop' used to display the numbers in a single row-list (**)
            {
                Console.Write(list[n] + " "); //Used to display the values in the array vai the 'for-loop' function. " " are used to create the spaces between the values
            }
            Console.WriteLine(); //used to get a line-break
           
            Sort(list);
            
        }

        public static void Sort(int[] list)
        {                    

            for (int i=0; i<list.Length-1; i++ )
            {
               for (int j=i+1; j<list.Length; j++)
               {
                   if (list[i] < list[j])
                   {
                       int Sort = list[j];
                       list[j] = list[i];
                       list[i] = Sort;
                   }
               }
            }

             for (int i=0; i<list.Length-1; i++ ) //instead of the "return" function, to create another loop, similar to the one in the main (**) to display the final list after sorting
             {
                 Console.Write(list[i] + " ");
             }
            Console.WriteLine();
             }
        }

    }

