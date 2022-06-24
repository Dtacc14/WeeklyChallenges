using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var value in vals)
            {
                if (value == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var answer = numbers.Sum();
            if (answer % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            for (int i = 0; (i < password.Length) ; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                else if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                else if (char.IsNumber(password[i])) 
                {
                    isNumber = true;
                }
            }

           return isLower && isNumber && isUpper;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }


        public int LastMinusFirst(int[] nums)
        {
            var last = nums.Last();
            var first = nums.First();
            var answer = last - first;
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            var count = 0;
            int[] nums = new int[50];
            for (var i = 1; i < 100; i += 2)
            {
                nums[count] = i;
                count++;
            }
            return nums;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)       
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
