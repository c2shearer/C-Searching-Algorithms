using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numberList = new()
            {
                3, 8, 1, 4, 7, 6, 9, 2, 12, 11, 10, 5
            };

            /*Search(numberList, 25);*/

            numberList.Sort();

            BSearch(numberList, 9, 0, 12);

        }

        // Binary Search 
        private static int BSearch(List<int> numList, int itemToFind, int min, int max)
        {
            // Find Midpoint
            int midPoint = (min + max) / 2;

            if (numList[midPoint] < itemToFind)
            {
                BSearch(numList, itemToFind, midPoint + 1, max);
            }
            else if (numList[midPoint] > itemToFind)
            {
                BSearch(numList, itemToFind, min, midPoint - 1);
            }
            else
            {
                return numList[midPoint];
            }

            return -1;
        }

        // Linear Search
        private static int Search(List<int> numList, int itemToFind)
        {
            foreach (int num in numList)
            {
                if (num == itemToFind)
                {
                    return num;
                }
               
            }
            return -1;
        }

    }
}
