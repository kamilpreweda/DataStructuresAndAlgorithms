
namespace DataStructuresAndAlgorithms.BigONotation
{
    public class LinearTimeExamples : ILinearTimeExamples
    {
        /// <summary>
        /// Calculates the sum of the ASCII codes of characters in the given string.
        /// Time Complexity: O(n) where n is the length of the input string.
        /// Space Complexity: O(1) as we are using a constant amount of space.
        /// </summary>
        /// <param name="n">The input string.</param>
        /// <returns>The sum of ASCII codes of characters in the string.</returns>
        public int SumCharCodes(string s)
        {
            int sum = 0;
            for (int i = 0; i< s.Length; i++)
            {
                sum += s[i];
            }
            return sum;
        }

        /// <summary>
        /// Calculates the sum of the ASCII codes of characters in the given string twice sequentially.
        /// Time Complexity: O(2n) which we simplify to O(n), illustrating the principle of dropping constants in big O notation. 
        /// This is because constants don't significantly affect the rate of growth of the function as the input grows.
        /// Space Complexity: O(1), as we use a constant amount of extra space, not depending on the input size.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The sum of ASCII codes of characters in the string, added twice.</returns>
        public int SumCharCodesTwice(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }
            return sum;
        }

        /// <summary>
        /// Calculates the sum of the ASCII codes of characters in the given string until it encounters a capital 'E'.
        /// Time Complexity: In the worst case, the function will iterate over the entire string (if there is no capital 'E'), 
        /// making it O(n), where n is the length of the string. This illustrates the principle of considering the worst-case scenario when analyzing time complexity.
        /// Space Complexity: O(1), as we use a constant amount of extra space, not depending on the input size.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The sum of ASCII codes of characters in the string until a capital 'E' is encountered or the end of the string if 'E' is not found.</returns>
        public int SumCharCodesUntilSpecificCharacter(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'E')
                {
                    return sum;
                }
                sum += s[i];
            }
            return sum;
        }

        /// <summary>
        /// Finds the maximum element in the given array.
        /// Time Complexity: O(n) where n is the length of the array. This is because we iterate through each element of the array once.
        /// Space Complexity: O(1), meaning the amount of memory used by the algorithm does not increase with the size of the input array. 
        /// We only use a single integer variable to keep track of the maximum element.
        /// </summary>
        /// <param name="arr">The input array.</param>
        /// <returns>The maximum element in the array.</returns>
        public int FindMaxElement(int[] arr)
        {
            int maxElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            return maxElement;
        }

        /// <summary>
        /// Counts the occurrences of a specific element in the given array.
        /// Time Complexity: O(n) where n is the length of the array. We need to iterate through each element once to count the occurrences.
        /// Space Complexity: O(1) as we are using a single integer variable to keep track of the count, irrespective of the size of the input array.
        /// </summary>
        /// <param name="arr">The input array.</param>
        /// <param name="element">The element to count.</param>
        /// <returns>The number of occurrences of the element in the array.</returns>
        public int CountOccurences(int[] arr, int element)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element) {
                count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Reverses the given string.
        /// Time Complexity: O(n) where n is the length of the string. The function iterates through half of the string, swapping elements.
        /// Space Complexity: O(1) as the amount of additional memory used by the algorithm does not depend on the size of the input string. 
        /// We only use a few extra variables for swapping elements, which does not depend on the length of the string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>The reversed string.</returns>
        public string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int len = charArray.Length;
            for (int i =0; i < len/2; i++) 
            {
                char temp = charArray[i];
                charArray[i] = charArray[len - i - 1];
                charArray[len - i - 1] = temp;
            }
            return new string(charArray);
        }
    }
}
