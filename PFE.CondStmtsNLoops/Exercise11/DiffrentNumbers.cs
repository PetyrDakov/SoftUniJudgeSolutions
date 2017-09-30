using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    internal class DiffrentNumbers
    {
        private const string whoAttack = "{0} used {1} and reduced {2} to {3} health.";
        private const string winner = "{0} won in {1}th round.";
        private static string gosho = "Gosho";
        private static string goshoAttacks = "Thunderous fist";
        private static int goshoDamage;
        private static int goshoHealth = 100;

        private static string pesho = "Pesho";
        private static string peshoAttacks = "Roundhouse kick";
        private static int peshoDamage;
        private static int peshoHealth = 100;
        private static StringBuilder result = new StringBuilder();
        private static int round = 0;

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
            peshoDamage = int.Parse(Console.ReadLine());
            goshoDamage = int.Parse(Console.ReadLine());
        }

        private static void Solve()
        {

            while (peshoHealth > 0 && goshoHealth > 0)
            {

                round++;

                if (round % 2 != 0)
                {
                    if (goshoHealth > 0)
                    {
                    goshoHealth -= peshoDamage;

                    result.AppendFormat(whoAttack, pesho, peshoAttacks, gosho, goshoHealth);
                    result.AppendLine();
                    }

                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if(peshoHealth > 0)
                    {

                    result.AppendFormat(whoAttack, gosho, goshoAttacks, pesho, peshoHealth);
                    result.AppendLine();
                    }
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
              
            }
            if (peshoHealth <= 0)
            {
                result.AppendFormat(winner, gosho, round);
            }
            else
            {
                result.AppendFormat(winner, pesho, round);

            }

        }
    }
}