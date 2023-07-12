using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_PracticeProblem
{
    public class MaximumSelingPrice
    {
        public static void MaximumSellingPriceMain()
        {
            // Read input
            string[] nk = Console.ReadLine().Split(' ');
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            int[] pricesA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] pricesB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Find the maximum selling price of Basket A
            int maxPrice = CalculateMaxPrice(N, K, pricesA, pricesB);

            // Print the result
            Console.WriteLine(maxPrice);
        }

        static int CalculateMaxPrice(int N, int K, int[] pricesA, int[] pricesB)
        {
            int maxPrice = 0;

            // Calculate the initial price of Basket A
            for (int i = 0; i < N; i++)
            {
                maxPrice += pricesA[i];
            }

            // Calculate the price difference between each fruit in Basket A and Basket B
            int[] priceDiff = new int[N];
            for (int i = 0; i < N; i++)
            {
                priceDiff[i] = pricesB[i] - pricesA[i];
            }

            // Sort the price differences in descending order
            Array.Sort(priceDiff);
            Array.Reverse(priceDiff);

            // Swap at most K fruits from Basket B to Basket A
            for (int i = 0; i < K; i++)
            {
                if (priceDiff[i] > 0)
                {
                    maxPrice += priceDiff[i];
                }
                else
                {
                    // No more positive price differences to swap, break the loop
                    break;
                }
            }

            return maxPrice;
        }
    }
}
