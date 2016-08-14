using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input Pay");
            string Str = Console.ReadLine();
            double Pay = Convert.ToDouble(Str);
            
                                   
           Console.WriteLine("Total Salary earned is {0:C}", (percent(Pay)+
               (percent(Pay)*3/100)+ (percent(Pay)*10/100)));

        }

        public static double percent(double Salary)
        {
            return (Salary);
        }
    }
}

