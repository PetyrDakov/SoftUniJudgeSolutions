﻿using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class ChooseADrink
    {
        private static readonly string[] DrinkNames = { "Water", "Coffee", "Beer", "Tea" };
        private static string professionName;

        /// <summary>
        /// Collect output here instead of directly writing to Console.
        /// This noticeably improves the execution times.
        /// </summary>
        private static StringBuilder result = new StringBuilder();
                
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
        }

        private static void Solve()
        {
            int drinkIdx = FindDrinkIdxByProfession(professionName);
            result.Append(DrinkNames[drinkIdx]);
        }
    }
}