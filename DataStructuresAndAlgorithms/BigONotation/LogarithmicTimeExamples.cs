using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BigONotation
{
    internal class LogarithmicTimeExamples : ILogarithmicTimeExamples
    {
        /// <summary>
        /// Performs a binary search on a sorted array to find the index of the target element.
        /// Time Complexity: O(log n) as the array size is halved with each iteration.
        /// Space Complexity: O(1) as we are using a constant amount of extra space.
        /// </summary>
        /// <param name="sortedArray">The sorted input array.</param>
        /// <param name="target">The target element to find.</param>
        /// <returns>The index of the target element if found, otherwise -1.</returns>
        public int BinarySearch(int[] sortedArray, int target)
        {
            // Initialize left pointer at the beginning of the array
            int left = 0;
            // Initialize right pointer at the end of the array
            int right = sortedArray.Length - 1;

            // Keep searching while the left pointer is less than or equal to the right pointer
            while (left <= right) 
            {
                // Calculate the middle index
                int mid = left + (right - left) / 2;

                // If the middle element is the target, return its index
                if (sortedArray[mid] == target)
                {
                    return mid;
                }
                // If the target is greater than the middle element, discard the left half
                else if (sortedArray[mid] < target) 
                {
                    left = mid + 1;
                }
                // If the target is smaller than the middle element, discard the right half
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// Calculates the power of a base number raised to an exponent using exponentiation by squaring.
        /// Time Complexity: O(log n) where n is the exponent, as the exponent is halved in each recursive call.
        /// Space Complexity: O(log n) due to the recursive call stack.
        /// </summary>
        /// <param name="baseNum">The base number.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of the base number raised to the exponent.</returns>
        public int CalculatePower(int baseNum, int exponent)
        {
            // Base case: anything raised to the power of 0 is 1
            if (exponent == 0) return 1;
            // Check if the exponent is even
            if (exponent % 2 == 0)
            {
                // Recursively calculate the power for half of the exponent
                // This takes advantage of the mathematical property a^(n/2) * a^(n/2) = a^n
                int half = CalculatePower(baseNum, exponent / 2);
                // Return the result of half * half (i.e., a^(n/2) * a^(n/2))
                return half * half;
            }
            // If the exponent is odd
            else
            {
                // Recursively calculate the power for (exponent - 1), then multiply by baseNum
                // This takes advantage of the mathematical property a^n = a * a^(n-1)
                return baseNum * CalculatePower(baseNum, exponent - 1);
            }
        }
    }
}
