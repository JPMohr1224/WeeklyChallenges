using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
          
           return vals.Contains(false) ? true : false; 

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                
                if (num % 2 == 1 || num % 2 == -1)
                {
                    sum += num;
                }

            }

            return sum % 2 != 0;




        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) &
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
            
               
        }

        public char GetFirstLetterOfString(string val)
        {
            return (val[0]);
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0)
            {
                return 0;
            } else if ( divisor == 0)
            {
                return 0;
            } else
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
