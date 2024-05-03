using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //  throw new NotImplementedException();
            var answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            var sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            var smol = ((number1 < number2) ? number1 : number2);
            return smol;
        }

        public long Multiply(long factor1, long factor2)
        {
            //throw new NotImplementedException();
            var multi = factor1 * factor2;
            return multi;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();
            if(string.IsNullOrWhiteSpace(nameOfPerson))
            {
                return "Hello!";
            }
            return ($"Hello, {nameOfPerson}!");

        }

        public string GetHey()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Please enter Hey");
            string hey = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hey))
            {
                return "HEY!";
            }
            return $"{hey.ToUpper()}!";
        }
    }
}
