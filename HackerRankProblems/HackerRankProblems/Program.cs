using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    class Result
    {

        public static int birthdayCakeCandles(List<int> candles, int totalCandals)
        {
            int max = candles[0];
            var count = 1;

            for (var i = 1; i < totalCandals; i++)
            {
                if (candles[i] > max)
                {
                    max = candles[i];
                    count = 1;
                }
                else if (candles[i] == max)
                {
                    count++;
                }
            }
            return count;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter No of candles : ");

            int candlesCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Candle Lengths : ");

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles, candlesCount);

            Console.WriteLine(result);
        }
    }
}
