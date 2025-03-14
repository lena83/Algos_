using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Amazon
{
    public static class FiveStarReviews
    {
        public static int FiveStarReviewsProblem(int[][] productRatings, int ratingsThreshold)
        {
            var maxHeap = new PriorityQueue<(int fiveStarRatingAmount, int products), double>();
            double actualThreshhold = 0.0;
            int count = 0;
            foreach (var productRating  in productRatings)
            {
                int fiveStarRatingCount = productRating[0];
                int products = productRating[1];

                var possibleRatingGain = (double)(fiveStarRatingCount + 1) / (products + 1) - (double)fiveStarRatingCount / products;
                actualThreshhold += (double)fiveStarRatingCount / products;
                maxHeap.Enqueue((fiveStarRatingCount,products), -possibleRatingGain);
            }

            actualThreshhold = actualThreshhold / productRatings.Length;

            var diff = (double)ratingsThreshold / 100 - actualThreshhold;
            while (diff > 0)
            {
               var (fiveStarRatingAmount,  products) = maxHeap.Dequeue();
               var possibleRatingGain = (double) (fiveStarRatingAmount + 1) / (products + 1) - (double)fiveStarRatingAmount / products;
                fiveStarRatingAmount++;
                products++;
                maxHeap.Enqueue((fiveStarRatingAmount, products), -possibleRatingGain/productRatings.Length);
               diff -= possibleRatingGain / productRatings.Length;
                count++;

            }


            return count;

        }
    }
}
