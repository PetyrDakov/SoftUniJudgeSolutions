using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class Plurals
    {
        private static readonly string[] REPLACED_WITH_ES = { "o", "ch", "z", "x", "s", "sh" };
        private static StringBuilder result = new StringBuilder();

        private static string word;

       

   
        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        private static void ReadInput()
        {
            word = Console.ReadLine();
        }

        private static void Solve()
        {
            if (word.EndsWith("y"))
            {
                result.Append(word.Substring(0, word.Length - 1));
                result.Append("ies");
            }
            else
            {
                int esIdx = -1;
                for (int i = 0; i < REPLACED_WITH_ES.Length; i++)
                {
                    if (word.EndsWith(REPLACED_WITH_ES[i]))
                    {
                        esIdx = i;
                        break;
                    }
                }
                
                if(esIdx == -1)
                {
                    result.Append(word).Append("s");
                }
                else
                {
                    result
                        .Append(word)
                        .Append("es");
                }
            }
        }
    }
}