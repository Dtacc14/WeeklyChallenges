using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenNumbers = numbers.Where(x => x % 2 == 0);
            var oddNumbers = numbers.Where(x => x % 2 == 1);   // Knocked this one out of the park :)
            return evenNumbers.Sum() - oddNumbers.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //if (str1.Length < str2.Length && str1.Length < str3.Length && str1.Length < str4.Length)
            //{
            //    return str1.Length;
            //}
            //else if (str2.Length < str1.Length && str2.Length < str3.Length && str2.Length < str4.Length)
            //{
            //    return str2.Length;
            //}
            //else if (str3.Length < str4.Length && str3.Length < str1.Length && str3.Length < str2.Length)
            //{
            //    return str3.Length;
            //}
            //else if (str4.Length < str1.Length && str4.Length < str2.Length && str4.Length < str3.Length)
            //{
            //    return str4.Length;
            //}
            //else return str1.Length;

            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length};  
            return list.Min();                                   // Made change during review
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //if (number1 < number2 && number1 < number3 && number1 < number4)
            //{
            //    return number1;
            //}

            //else if (number2 < number1 && number2 < number3 && number2 < number4)
            //{
            //    return number2;
            //}

            //else if (number3 < number1 && number3 < number2 && number3 < number4)
            //{
            //    return number3;
            //}
            //else if (number4 < number1 && number4 < number2 && number4 < number3)
            //{
            //    return number4;
            //}
            //else return number1;

            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();                   // Made changes during review
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //var replacement = biz.Name.Replace(" ", "TrueCoders");
            //Console.WriteLine(replacement);
            //COULD NOT FIGURE OUT

            biz.Name = "TrueCoders";                // Made changes during review
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if 
                (
                sideLength1 + sideLength2 <= sideLength3 ||
                sideLength2 + sideLength3 <= sideLength1 ||   
                sideLength1 + sideLength3 <= sideLength2
                )
            {
                return false;
            }
            else                             // Fixed readability during review
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            double number;
            var result = double.TryParse(input, out number);
            //if (result == true)
            //{
            //    return true;
            //}
            //else 
            //{ 
            //    return false; 
            //}

            return result;      // Simplified during review
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //var sumNulls = 0;
            //var sumTest = 0;
            //foreach (var obj in objs)
            //{
            //    var isNull = objs.ToList().Contains(null);
            //    var isTest = objs.ToList().Contains("test");
            //    if (isNull)
            //    {
            //        sumNulls++;
            //    }
            //    else if (isTest)
            //    {
            //        sumTest++;
            //    }
            //    if (sumNulls > sumTest)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            // COULD NOT FIGURE OUT

            var majority = (objs.Length / 2) + 1;
            var count = 0;

            foreach (var item in objs)
            {
                if (item == null)
                {
                    count++;
                }
            }
                                           // Made changes during review
            if (count >= majority)
            {
                return true;               // CAN BE SIMLIFIED: return (count >= majority);
            }
            
            else
            {
                return false;
            }
            
        }

        public double AverageEvens(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}

            //return numbers.Where(x => x % 2 == 0).Average();            
            // COULD NOT FIGURE OUT

            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var number in numbers)
            {
                if (number % 2 == 0)         // Made changes during review
                {
                    sum += number;
                    count++;
                }
            }
            if (count > 0)        
            {
                return sum / count;          // CAN BE SIMPLIFIED: return (count > 0) ? sum / count : 0;
            }
            else
            {
                return 0;
            }
        }
        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }
            var factorial = 1;
            while (number != 1)
            {
                factorial = factorial * number;
                number = number - 1;
            }
            return factorial;
        }
    }
}
