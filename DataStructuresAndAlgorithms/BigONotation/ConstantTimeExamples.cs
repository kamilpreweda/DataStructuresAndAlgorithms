using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BigONotation
{
    public class ConstantTimeExamples : IConstantTimeExamples
    {
        /// <summary>
        /// Retrieves the first element of the array.
        /// Time Complexity: O(1) because accessing an array element by index takes constant time.
        /// Space Complexity: O(1) as we are using a constant amount of extra space.
        /// </summary>
        /// <param name="arr">The input array.</param>
        /// <returns>The first element of the array.</returns>
        public int GetFirstElement(int[] arr)
        {
            return arr[0];
        }

        /// <summary>
        /// Calculates the sum of two integers.
        /// Time Complexity: O(1) because adding two numbers is a constant time operation.
        /// Space Complexity: O(1) as we are using a constant amount of extra space.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
