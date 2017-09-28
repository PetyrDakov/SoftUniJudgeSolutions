using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class ChooseADrink
    {
        private static String profession;

        /// <summary>
        /// Collect output here instead of directly writing to Console.
        /// This noticeably improves the execution times.
        /// </summary>
        private static StringBuilder result = new StringBuilder();

        /// <summary>
        /// Simple 3-steps approach to any exercise
        /// </summary>
        private static void Main(string[] args)
        {
            ReadInput();
            Solve();
            PrintResult();
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
            profession = Console.ReadLine();
        }

        private static void Solve()
        {
            switch (profession)
            {
                case "Athlete":
                    result.Append("Water");
                    break;

                case "Businessman":
                case "Businesswoman":
                    result.Append("Coffee");
                    break;

                case "Softuni Student":
                    result.Append("Beer");
                    break;

                default:
                    result.Append("Tea");
                    break;
            }
        }
    }
}