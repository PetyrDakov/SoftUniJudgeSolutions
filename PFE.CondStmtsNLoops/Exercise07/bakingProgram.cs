using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class bakingProgram
    {

        private const string addingIngredient = "Adding ingredient {0}.";

        private const string endResult = "Preparing cake with {0} ingredients.";


        private static int numOfIngredient = 0;
        private static StringBuilder result = new StringBuilder();

        private static void Main(string[] args)
        {        
            Solve();
            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }


        private static void Solve()
        {
            string input;

            do
            {
                input = Console.ReadLine();
                if (input == "Bake!")
                {
                    break;
                }
                Console.WriteLine(addingIngredient , input);
                numOfIngredient++;
            }
            while (numOfIngredient <= 20);
            
                result.AppendFormat(endResult, numOfIngredient);                   
        }
    }
}