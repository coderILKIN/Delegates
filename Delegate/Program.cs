using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] PruductPrices = { 1.9, 25.7, 9.99, 4.8, 101.99, 12.6 };
            Action<double[]> Info = TotalPriceCount;
            Info(PruductPrices);

        }
        public static void TotalPriceCount(double[] Arr)
        {
            int count = Arr.Length;
            double TotalPrice = default(int);
            foreach (double item in Arr)
            {
                TotalPrice += item;
            }
            Console.WriteLine($"Total price of pruduct: {TotalPrice}$ , Pruducts count: {count}");
        }
    }
}
