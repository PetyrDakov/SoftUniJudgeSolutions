using System;
using System.Text;

namespace SoftUniJudgeSolutions
{

 
    internal class Intervals
    {

        private static int from;
        private static StringBuilder result = new StringBuilder();
        private static int to;

        

        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        private static void ReadInput()
        {
            int first = int.Parse(Console.ReadLine());
            ValidateInput(first);

            int second = int.Parse(Console.ReadLine());
            ValidateInput(second);

            from = Math.Min(first, second);

            to = Math.Max(first, second);

        }

        private static void Solve()
        {
            for (int i = from; i <= to; i++)
            {
                result.Append(i);
                result.AppendLine();
            }
        }

        private static void ValidateInput(int num)
        {
            if (num < 0 || num > 100)
                throw new ArgumentOutOfRangeException("num");
        }
    }
}