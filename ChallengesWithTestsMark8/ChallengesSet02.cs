﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            return (CharacterIsALetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
           if (str1.Length > str2.Length)
            {
                return str2.Length;
            } else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
