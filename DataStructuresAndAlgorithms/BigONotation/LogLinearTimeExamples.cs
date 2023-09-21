using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BigONotation
{
    public class LogLinearTimeExamples : ILogLinearTimeExamples
    {
        /// <summary>
        /// Sorts an array using the Merge Sort algorithm.
        /// Time Complexity: O(n log n) because the array is divided into halves (log n) and then merged (n).
        /// Space Complexity: O(n) for the temporary arrays used during merging.
        /// </summary>
        /// <param name="arr">The input array.</param>
        public void MergeSort(int[] arr)
        {
            // Base case: Arrays with 1 element are already sorted
            if (arr.Length <= 1) return;

            // Calculate the middle index of the array
            int mid = arr.Length / 2;

            // Split the array into two halves
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();

            // Recursively sort both halves
            MergeSort(left);
            MergeSort(right);

            // Merge the sorted halves
            Merge(arr, left, right);
        }

        private void Merge(int[] arr, int[] left, int[] right) 
        {
            // i is the index for the left array, j for the right array, and k for the merged array
            int i = 0, j = 0, k = 0;

            // While both arrays have elements
            while (i < left.Length && j < right.Length) 
            {
                // Compare and put the smaller element into the merged array
                if (left[i] < right[j]) 
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            // If there are remaining elements in the left array, put them in the merged array
            while (i < left.Length) arr[k++] = left[i++];

            // If there are remaining elements in the right array, put them in the merged array
            while (j < right.Length) arr[k++] = right[j++];
        }

        public void QuickSort(int[] arr, int low, int high)
        {
            // Base case: If 1 or zero elements, partition is already sorted
            if (low < high)
            {
                // Partition the array. Value pivotIndex is the position of the
                // pivot element such that element smaller than the pivot
                // are at the left of pivot and elements greater than the
                // pivot are at the right of the pivot
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the array
                QuickSort(arr, low, pivotIndex); // Sort left partition
                QuickSort(arr, pivotIndex + 1, high); // Sort right partition
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            // Choose the leftmost element as the pivot
            int pivot = arr[low];
            // Initialize left pointer at the lowest index
            int left = low;
            // Initialize right pointer at the highest index
            int right = high;

            // Keep running until we've partitioned all elements
            while (true)
            {
                // Move left pointer right until an element bigger than the pivot is found
                while (arr[left] < pivot) left++;
                // Move right pointer left until an element smaller than the pivot is found
                while (arr[right] > pivot) right--;

                // If there's an element larger on the left and smaller on the right, let's swap them
                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
