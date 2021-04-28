using System;

namespace OOPDataAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array of the recent temperatures in Bradford PA

            int[] tempDays = new int[] { 80, 74, 64, 50, 59, 69, 72, 67 };

            Console.WriteLine("The recent temperatures in Bradford PA are as follows: ");

            foreach (int N in tempDays)
            {
                Console.WriteLine("{0}", N);
            }

            // Finding the average temperature over the recent days

            int sum = 0;
            int average = 0;

            for (int N = 0; N < tempDays.Length; N++)
            {
                sum += tempDays[N];
            }

            average = (int)sum / tempDays.Length;

            Console.WriteLine("The average temperature over the past week is: {0} ", average);
        }
    }
}
