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
                Console.WriteLine("{0} degrees", N);
            }

            // Finding the average temperature over the recent days

            int sum = 0;
            int average = 0;

            for (int N = 0; N < tempDays.Length; N++)
            {
                sum += tempDays[N];
            }

            average = (int)sum / tempDays.Length;

            Console.WriteLine("The average temperature over the past week is: {0} degrees. ", average);

            // Asking the user to enter the current temperature to the array and finding the new average

            Console.WriteLine("Please enter the current temperature: ");

            int NumCheck = 0;

            while (NumCheck < 1)
            {
                if (int.TryParse(Console.ReadLine(), out tempDays[NumCheck]))
                    NumCheck++;
                else
                    Console.WriteLine("You didn't enter the temperature. Please try again: ");
            }

            // This will boot out the oldest temperature of the past week with the new current day temperature

            Console.WriteLine("This makes the recent temperatures of Bradford PA as follows: ");

            foreach (int N in tempDays)
            {
                Console.WriteLine("{0} degrees", N);
            }


            int newSum = 0;
            int newAverage = 0;

            for (int N = 0; N < tempDays.Length; N++)
            {
                newSum += tempDays[N];
            }

            newAverage = (int)newSum / tempDays.Length;

            Console.WriteLine("This also changes the average temperature over the past week to: {0} degrees.", newAverage);
        }
    }
}
