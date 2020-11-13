using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] candleArray = new int[] { 3, 2, 1, 3 };

            int result = ReturnNumberOfLargest(candleArray);
            Console.WriteLine("Largest candle: {0}", result);
            Console.WriteLine("press any key to exit");
            Console.ReadLine();

        }

        static int ReturnNumberOfLargest(int[] candles)
        {
            int numberOfLargest=0;
            int largest=0;
            for(int i=0; i < candles.Length; i++)
            {
                if (candles[i] > largest)
                {
                    largest = candles[i];
                    numberOfLargest = 1;
                }
                else if (candles[i] == largest)
                {
                    numberOfLargest++;
                }
            }

            return numberOfLargest;
        }
    }
}
