using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            var sum = 0;
            int m;
            if (num / 2 == 1)
            {
                return true;
            }
            else if (num == 1 || num == 0)
            {
                return false;
            }
            else if(num % 5 == 0)
            {
                return true;
            }
            for (int i = 0; i < num.ToString().Length ; i++)
            {
                while (i > 0)
                {
                    m = i % 10;
                    sum += m;
                    i /= 10;
                }
                if (sum % 3 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse()
                .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                .FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int max = numbers[0];
            int result = 0;
            
            for (int i = 1; i < numbers.Length ; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    result = i;
                }
            }
            return result;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            for (var i = 0; i < elements.Count; i += n)
            {
                return elements.ToString().ToList().IndexOf(elements[i]);
            }
            return elements.ToArray();
        }
    }
}
