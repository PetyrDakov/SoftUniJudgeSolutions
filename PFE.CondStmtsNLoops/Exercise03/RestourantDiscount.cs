using System;
using System.Linq;
using System.Text;

namespace SoftUniJudgeSolutions
{
 
    internal class RestourantDiscount
    {
        private const string MSG_HALL_OFFER = "We can offer you the {0}";
        private const string MSG_NO_HALL = "We do not have an appropriate hall.";
        private const string MSG_PRICE_PER_PERSON = "The price per person is {0:0.00}$";
        private static readonly int[] hallCapacity = { 50, 100, 120 };
        private static readonly double[] hallPrices = { 2500, 5000, 7500 };
        private static readonly string[] hallTypes = { "Small Hall", "Terrace", "Great Hall" };
        private static readonly double[] serviceDiscounts = { 5, 10, 15 };
        private static readonly string[] servicePackages = { "Normal", "Gold", "Platinum" };
        private static readonly double[] servicePrices = { 500, 750, 1000 };
        private static int groupSize;
        private static string packageName;
        private static StringBuilder result = new StringBuilder();

        private static double CalcDiscount(double totalPrice, double discountPersent)
        {
            return (totalPrice * discountPersent) / 100f;
        }

        private static int GetHallIndexForGroup(int groupSize)
        {
           
            if (groupSize < 1 )
                return -1;
            
            for(int i = 0; i < hallCapacity.Length; i++)
            {
                if (groupSize <= hallCapacity[i])
                    return i;
            }

            return -1;
        }
        
        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        private static void ReadGroupSize()
        {
            groupSize = int.Parse(Console.ReadLine());
        }

        private static void ReadInput()
        {
            ReadGroupSize();
            ReadPackage();
        }

        private static void ReadPackage()
        {
            packageName = Console.ReadLine();

        }

        private static void Solve()
        {
            int hallTypeIndex = GetHallIndexForGroup(groupSize);

            int packageTypeIndex = Array.IndexOf(servicePackages, packageName);

            if (hallTypeIndex < 0)
            {
                result.Append(MSG_NO_HALL);
            }
            else
            {
                double hallPrice =  hallPrices[hallTypeIndex];

                double packagePrice = servicePrices[packageTypeIndex];

                double discountPersent = serviceDiscounts[packageTypeIndex];

                double totalPrice = hallPrice + packagePrice;

                double totalPriceAftarDiscount = totalPrice - CalcDiscount(totalPrice , discountPersent);

                double pricePerPerson = totalPriceAftarDiscount / (double)groupSize;

                string hallName = hallTypes[hallTypeIndex];
                result.AppendFormat(MSG_HALL_OFFER, hallName);

                result.AppendLine();

                result.AppendFormat(MSG_PRICE_PER_PERSON, pricePerPerson);
                
            }


        }
    }
}