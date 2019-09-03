/* In class conditional statement example
*
*Kendall Gorman
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string weightAsString, containsHazardousAsString;
            double weight, distance;
            bool containsHazardous;

            Console.WriteLine("What is the weight of your shipment? >>");
            weightAsString = Console.ReadLine();
            weight = Convert.ToDouble(weightAsString); // Option one

            Console.WriteLine("What is the distance of your shipment? >>");
            distance = Convert.ToDouble(Console.ReadLine()); //Option two, don't need to declare distanceAsString.

            Console.WriteLine("Does your shipment contain hazardous material? (yes/no) >>");
            containsHazardousAsString = Console.ReadLine();

            double quote = distance * .55 + weight * .73;
            double hazardousCost = 0;

            containsHazardousAsString = contiansHazardousAsString.ToLower();

            if (containsHazardousAsString == "yes")
            {
                // this is the only place in code we know for sure that  user typed yes 
                containsHazardous = true;
                hazardousCost = 0.15 * weight;
            }
            else if (containsHazardousAsString == "no")
            {
                containsHazardous = false;
                hazardousCost = 0;
            }
            else
            {
                Console.WriteLine("Invalid input for hazardous material, please contact support for help.");
                Environment.Exit(-1);
               
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;

            if (distance < 150 && weight > 500)
            {
                discount = netTotal * .10;
            } // dont need else if because all other options end with end value = 0, and this is already defined in above double


            double total = netTotal - discount;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hazardous cost:\t{hazardousCost.ToString("C2")}");
            
            Console.WriteLine($"Discount:\t{discount.ToString("C2")});
            

            Console.WriteLine($"Total:\t\t{total.ToString("C2")}");
            Console.ReadLine();

            Console.ReadLine();

        }
    }
}
