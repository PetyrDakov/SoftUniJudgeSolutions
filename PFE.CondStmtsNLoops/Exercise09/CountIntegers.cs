using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class CountIntegers
    {
        private static int numCount = 0;
        private static StringBuilder result = new StringBuilder();


        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        private static void ReadInput()
        {
            do
            {
                string line = Console.ReadLine();

                try
                {
                    int num = int.Parse(line);
                    numCount++;
                }
                catch (Exception)
                {
                    break;
                }

                /*
                int num;

                bool succeeded = int.TryParse(line, out num);
                if (succeeded)
                {
                    numCount++;
                }else
                {
                    break;
                }
                */
            } while (numCount < 100);
        }

        private static void Solve()
        {
            result.AppendFormat("{0}", numCount);
        }
    }
}