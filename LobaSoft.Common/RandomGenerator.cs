using System;
using System.Collections.Generic;

namespace LobaSoft.Common
{
    public class RandomGenerator
    {
        private static Random __generator;

        static RandomGenerator()
        {
            __generator = new Random();
        }
        //The min value is inclusive, the max value is esclusive
        public static int GenerateInteger(int min, int max)
        {
            return __generator.Next(min, max);
        }

        public static double GenerateDouble(double min, double max)
        {
            throw new NotImplementedException();
        }

        public static int [] GenerateRandomicOrder(int length)
        {
            if (length == 0)
                return new int[0];

            int[] randomicOrder = new int[length];
            List<int> availableIndexes = new List<int>();

            for (int i = 0; i < length; i++)
                availableIndexes.Add(i);

            for (int i = 0; i < length; i++)
            {
                int randomIndex = GenerateInteger(0, availableIndexes.Count);
                int selectedIndex = availableIndexes[randomIndex];
                availableIndexes.RemoveAt(randomIndex);
                randomicOrder[i] = selectedIndex;
            }

            return randomicOrder;
        }
    }
}

