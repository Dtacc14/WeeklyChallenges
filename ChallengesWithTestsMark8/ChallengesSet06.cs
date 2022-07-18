using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    // MADE CHANGES DURING WEEKLY CHALLENGES REVIEW
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (string.Equals(words, null) || words.Contains(null)) // ADDED DURING REVIEW
            {
                return false;
            }
            bool containsWord = false;
            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if (num >= 0)     // MADE CHANGES DURING REVIEW
            {                
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if (num == 2 || num == 3)
            {
                isPrime = true;
            }
            if (num == 1)
            {
                isPrime = false;
            }
            return isPrime;
            //var sum = 0;
            //int m;
            //if (num / 2 == 1)
            //{
            //    return true;
            //}
            //else if (num == 1 || num == 0)
            //{
            //    return false;
            //}
            //else if(num % 5 == 0)
            //{
            //    return true;
            //}
            //for (int i = 0; i < num.ToString().Length ; i++)
            //{
            //    while (i > 0)
            //    {
            //        m = i % 10;
            //        sum += m;
            //        i /= 10;
            //    }
            //    if (sum % 3 == 0)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse()
                .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                .FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)  // MADE CHANGES DURING REVIEW
            {
                int currentCount = 1;
                for (var j = i +1; j < numbers.Length; j++)
                {
                    if (numbers[i] !=  numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;

            //int max = numbers[0];
            //int result = 0;
            
            //for (int i = 1; i < numbers.Length ; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //        result = i;
            //    }
            //}
            //return result;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();
            if (elements == null || n <= 0 || n> elements.Count())   // MADE CHANGES DURING REVIEW
            {
                return nthElement.ToArray();
            }
            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();

            //for (var i = 0; i < elements.Count; i += n)
            //{
            //    return elements.ToString().ToList().IndexOf(elements[i]);
            //}
            //return elements.ToArray();
        }
    }
}
