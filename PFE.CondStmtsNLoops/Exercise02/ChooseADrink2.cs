using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class ChooseADrink2
    {
        private const string FORMAT_ANSWER = "The {0} has to pay {1:0.00}.";
        private static readonly string[] DrinkNames = { "Water", "Coffee", "Beer", "Tea" };
        private static readonly double[] DrinkPrices = { 0.70f, 1.00f, 1.70f, 1.20f};

        private static int drinkQuantity;
        private static string professionName;

        /// <summary>
        /// Collect output here instead of directly writing to Console.
        /// This noticeably improves the execution times.
        /// </summary>
        private static StringBuilder result = new StringBuilder();

        private static double CalcTotalPrice(string drinkName, int drinkQuantity)
        {
            double singleDrinkPrice = GetPriceForDrink(drinkName);
            return ((double)drinkQuantity) * singleDrinkPrice;

        }

        private static int FindDrinkIdxByProfession(string profession)
        {
            switch (profession)
            {
                case "Athlete":
                    return Array.IndexOf(DrinkNames, "Water");

                case "Businessman":
                case "Businesswoman":
                    return Array.IndexOf(DrinkNames, "Coffee");

                case "SoftUni Student":
                    return Array.IndexOf(DrinkNames, "Beer");

                default:
                    return Array.IndexOf(DrinkNames, "Tea");
            }
        }

        private static string FindDrinkNameByProfession(string profession)
        {
            return DrinkNames[FindDrinkIdxByProfession(profession)];
        }

        private static double GetPriceForDrink(string drinkName)
        {
            int drinkIndex = Array.IndexOf(DrinkNames, drinkName);
            return DrinkPrices[drinkIndex];
        }

        

        /// <summary>
        /// Prints the collected output when solving has completed.
        /// </summary>
        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        /// <summary>
        /// Read console input here.
        /// Assign to static variables,
        /// in order do be accessible across the other static methods
        /// </summary>
        private static void ReadInput()
        {
            professionName = Console.ReadLine();
            drinkQuantity = int.Parse(Console.ReadLine().Trim());
        }

        private static void Solve()
        {
            string drinkName = FindDrinkNameByProfession(professionName);

            double totalPrice = CalcTotalPrice(drinkName, drinkQuantity);
            
            result.AppendFormat(FORMAT_ANSWER, professionName, totalPrice);
        }
    }
}