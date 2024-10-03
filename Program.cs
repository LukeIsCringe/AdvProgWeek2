using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProgWeek2
{
    internal class Program
    {
        static Random randomGenerator = new Random();
        static List<double> listOfDoubles = new List<double>();

        static void Main(string[] args)
        {
            TenDoubles();
            MenuSystem mainmenu = new MenuSystem("Program");

            mainmenu.AddMenuItem("Randomise List of Doubles (10 Values)", "TenDoubles", typeof(Program));
            mainmenu.AddMenuItem("Print List of Doubles", "PrintListOfDoubles", typeof(Program));
            mainmenu.AddMenuItem("Perform a Bubble Sort", "PerformBubble", typeof(Program));

            mainmenu.RunForever();
            Console.ReadKey();
        }

        public static void PerformBubble()
        {
            Console.WriteLine("Performing Bubble Sort...");
            BubbleSort.Perform(listOfDoubles);
            Console.WriteLine("Sort Completed");
        }

        public static void TenDoubles()
        {
            Console.WriteLine("Populating List with random numbers...");
            PopulateListWithRandomDoubles(10);
            Console.WriteLine("List populated");
        }

        static void PopulateListWithRandomDoubles(int size)
        {
            listOfDoubles.Clear();

            for (int i = 0; i < size; i++)
            {
                double twoDigiDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.00000"));
                listOfDoubles.Add(twoDigiDouble);
            }
        }

        public static void PrintListOfDoubles()
        {
            Console.WriteLine("\n\nLIST PRINT:\n");

            for (int i = 0; i < listOfDoubles.Count; i++)
            {
                Console.WriteLine(" " + i + " " + listOfDoubles[i].ToString());
            }

            Console.WriteLine("\nEND \n");
        }

    }
}
