using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            /*
             * Reversing String
             * convert input to char array
             * new array using input array length
             *  j = 0
             *  i = input array length
             *  while (j < input array length)
             *      new array (j) = input[i]
             *      j++
             *      i--
             *      
             *  return array joined to string
             */

            if (input.Length < 1 || input.Equals(null))
            {
                return "";
            }
            var inputCharArray = input.ToCharArray();
            var reversedArray = new char[input.Length];

            var i = input.Length - 1;
            var j = 0;


            while (j < input.Length)
            {
                reversedArray[j] = inputCharArray[i];
                i--;
                j++;
            }
            var reversedString = new string(reversedArray);
            return reversedString;
        }

        public bool IsPalindrome(string input)
        {
            var reversedString = ReverseString(input);
            return reversedString.Equals(input);
        }
    }
}
