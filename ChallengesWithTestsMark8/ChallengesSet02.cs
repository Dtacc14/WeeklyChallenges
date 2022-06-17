using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            foreach (var letter in c.ToString())
            {
                var ch = letter;
                var isLetter = char.IsLetter(ch);
                return isLetter;
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 != 0) return false;
            else return true;
        }

        public bool IsNumberEven(int number)
        {
            foreach (char num in number.ToString())
            {
                var isNumberEven = (number % 2 == 0);
                return isNumberEven;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            var isNumberOdd = num % 2 != 0;
            return isNumberOdd;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            foreach (var number in numbers)
            {
                var num1 = numbers.Min();
                var num2 = numbers.Max();
                var sum = num1 + num2;
                return sum;
            }
            return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var word1 = str1.Count();
            var word2 = str2.Count();
            var shortestString = (word1 > word2) ? word2 : word1;
            return shortestString;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            if (sum % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) { return 0; }
            return number / 2; 
        }
    }
}
