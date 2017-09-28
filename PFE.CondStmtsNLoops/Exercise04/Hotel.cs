using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CondStmtsNLoops.Exercise04
{
    internal class Hotel
    {
        private const string MSG_FORMAT = "{0}: {1:0.00} lv.";
        private const int PERIOD_JUL_AUG_SEPT = 2;
        private const int PERIOD_JUNE_SEPT = 1;
        private const int PERIOD_MAY_OCT = 0;

        private static readonly int BonusNight_MinNightsCount = 7;
        private static readonly string[] BonusNight_Months = { "September", "October" };

        private static readonly int[] DiscountConditions_Double = { 14, 10 };
        private static readonly int[] DiscountConditions_Studio = { 7, 5 };
        private static readonly int[] DiscountConditions_Suite = { 14, 15 };

        private static readonly string[] Months = "May,June,July,August,September,October,December".Split(',');

        private static readonly double[] Prices_JulAugDec = { 68, 77, 89 };
        private static readonly double[] Prices_JuneSept = { 60, 72, 82 };
        private static readonly double[] Prices_MayOct = { 50, 65, 75 };
        private static readonly string[] Rooms = { "Studio", "Double", "Suite" };
        private static string Month;

        private static int NightsCount;

        private static StringBuilder result = new StringBuilder();

        private static int[][] DiscountsConditions => new int[][] { DiscountConditions_Studio, DiscountConditions_Double, DiscountConditions_Suite };

        private static double[][] Prices => new double[][] { Prices_MayOct, Prices_JuneSept, Prices_JulAugDec };

        private static int GetDiscountPercentage(int roomIdx,int periodIdx, int nightsCount)
        {

            int[] discountConditions = DiscountsConditions[periodIdx];

            if (nightsCount > discountConditions[0] && roomIdx == periodIdx)
                return discountConditions[1];

            return 0;
        }

        private static int GetPeriodIdx(int monthIdx)
        {
            switch (monthIdx)
            {
                case 0:
                case 5:
                    return PERIOD_MAY_OCT;

                case 1:
                case 4:
                    return PERIOD_JUNE_SEPT;

                default:
                    return PERIOD_JUL_AUG_SEPT;
            }
        }

        private static bool IsBonusNightApplicable(string monthName, int nightsCount)
        {
            return nightsCount > BonusNight_MinNightsCount && (Array.IndexOf(BonusNight_Months, monthName) >= 0);
        }

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
            Month = Console.ReadLine();

            if (Array.IndexOf(Months, Month) == -1)
                throw new ArgumentException("Specified month is not valid!");

            NightsCount = int.Parse(Console.ReadLine());

            if (NightsCount < 0 || NightsCount > 200)
                throw new ArgumentException("Specified nights count is not valid!");

        }

        private static void Solve()
        {
            int monthIdx = Array.IndexOf(Months, Month);
            int periodIdx = GetPeriodIdx(monthIdx);

            for (int roomIdx = 0; roomIdx < Rooms.Length; roomIdx++)
            {
                double nightlyPrice = Prices[periodIdx][roomIdx];

                int discountPercentage = GetDiscountPercentage(roomIdx,periodIdx, NightsCount);

                nightlyPrice *= (1f - discountPercentage / 100f);

                int nightsToPay = NightsCount;

                if (roomIdx == 0)
                {
                    bool shouldHaveBonusNight = IsBonusNightApplicable(Month, NightsCount);

                    nightsToPay -= (shouldHaveBonusNight ? 1 : 0);
                }


                double totalPrice = ((double)nightsToPay) * nightlyPrice;

                result.AppendFormat(MSG_FORMAT, Rooms[roomIdx], totalPrice);
                result.AppendLine();
            }
        }
    }
}
