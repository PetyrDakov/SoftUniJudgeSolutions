using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class CaloriesCounter
    {
        private const string answerFormat = "Total calories: {0}";
        private static readonly int[] calories = { 500, 150, 600, 50 };
        private static readonly string[] foods = { "cheese", "tomato sauce", "salami", "pepper" };
        private static int count;
        private static StringBuilder result = new StringBuilder();
        private static int totalAmount = 0;

        private static void Main(string[] args)
        {
            ReadInput();
            Solve();
            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        private static void ReadInput()
        {
            count = int.Parse(Console.ReadLine());
            if (count < 1 || count > 20)
            {
                throw new ArgumentOutOfRangeException();
            }
      
        }

        private static void Solve()
        {
            for (int i = 0; i < count; i++)
            {
                string food = Console.ReadLine().ToLower();
                int foodIndex = Array.IndexOf(foods, food);
                if (foodIndex == -1)
                {
                    continue;
                }
                else
                {
                    int foodCalories = calories[foodIndex];
                    totalAmount += foodCalories;
                }
            }
            result.AppendFormat(answerFormat, totalAmount);

        }
    }
} 