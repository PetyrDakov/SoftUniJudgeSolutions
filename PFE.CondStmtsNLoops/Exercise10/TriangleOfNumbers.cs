using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CondStmtsNLoops.Exercise10
{
    internal class TriangleOfNumbers
    {
        private static int input;
        private static StringBuilder result = new StringBuilder();

        

        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        private static void ReadInput()
        {
            input = int.Parse(Console.ReadLine());



        }

        private static void Solve()
        {
            for (int i = 1; i <= input ; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result.AppendFormat("{0} ", i);
                }
                result.AppendLine();
            }
        }
    }
}
