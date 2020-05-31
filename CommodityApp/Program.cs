// Grading ID Here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CommodityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentValue;   // Current commodity's value
            double totalValue = 0; // Running total of commodity's value
            CommodityItem[] items; // Commodity Items

            // #1 - Put code here to construct 3  commodity items: Toilet Paper, Hand Sanitizer, Disinfection Wipes as directed
          

            CommodityItem item1 = new CommodityItem("Sonia Toilet Paper", "TP6565", 10, 6.50);  //Toilet Paper
            CommodityItem item2 = new CommodityItem("LIB Hand Sanitizer", "HS8985", 13, 7.50); //Hand Sanitizer
            CommodityItem item3 = new CommodityItem("Lysol Disinfection Wipes", "DW9494", 10, 6.50); //Disinfection Wipes

            items = new CommodityItem[] { item1, item2, item3 };

            WriteLine($"Commodity Revenue Report:");

            // #2 - Complete loop to step through array of items
            for (int index = 0; index < items.Length; ++index)
            {

                currentValue = items[index].CalcValue();  //      from array by calling CalcValue

                totalValue += currentValue; // #4 - Add currentValue into running total

                WriteLine($"{currentValue:C}, {items[index].ToString()}");
                // #5 - Output currentValue, with currency formatting, followed by string representation
                //      of current item from array
            }

            WriteLine($"\nTotal Gross Revenue:{totalValue:C}");
            // #6 - Output totalValue of Gross Revenue, with currency formatting
           
        }
    }
}
