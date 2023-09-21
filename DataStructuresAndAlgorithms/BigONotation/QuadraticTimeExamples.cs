using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BigONotation
{
    public class QuadraticTimeExamples : IQuadraticTimeExamples
    {
        /// <summary>
        /// Demonstrates a basic bubble sort algorithm.
        /// Time Complexity: O(n^2) - Because of nested loops each iterating through almost the entire array.
        /// Space Complexity: O(1) - Using constant extra space for variables and swapping.
        /// </summary>
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            // Iterate over the array (n-1) times
            for (int i=0; i < n - 1; i++)
            {
                // For each i, iterate through the (n-i-1) elements
                for (int j=0; j < n - i - 1; j++)
                {
                    // Compare adjacent elements
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the elements if arr[j] > arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Demonstrates an example of finding all pairs in an array.
        /// Time Complexity: O(n^2) - Due to nested loops iterating through each element to find pairs.
        /// Space Complexity: O(1) - Using only a constant amount of extra space.
        /// </summary>
        public void FindAllPairs(int[] arr)
        {
            int n = arr.Length;

            // Iterate through each element
            for (int i = 0; i < n; i++)
            {
                // Iterate through remaining elements to find pairs
                for (int j = i + 1; j < n; j++)
                {
                    Console.WriteLine($"Pair: ({arr[i]}, {arr[j]}");
                }
            }
        }
    }
}
