using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueBracketChecker
{

    class EnumClass
    {
        Test test = (Test)(-1);
        public enum Test
        {
            FIRST = 10,
            LAST
        }
        public Test getTest() { return test; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EnumClass enumClass = new EnumClass();
            EnumClass.Test test = enumClass.getTest();

            Console.WriteLine($"Test is {test}");
            bool status = CheckIfStringIsCorrect("aaaaa{}bbbbbb{fff}  ({[]}ddd)");
            Console.WriteLine($"status is {status} - expected result TRUE");
            status = CheckIfStringIsCorrect("aaaaa(bbbbbb{fff}  ({[]}ddd))");
            Console.WriteLine($"status is {status} - expected result TRUE");
            status = CheckIfStringIsCorrect("aaaaa}bbbbbb{fff}  ({[]}ddd)");
            Console.WriteLine($"status is {status} - expected result FALSE");
            status = CheckIfStringIsCorrect("aaaaa{bbbbbb{fff}  ({[]}ddd)");
            Console.WriteLine($"status is {status} - expected result FALSE");
            status = CheckIfStringIsCorrect("aaaaa{}bbbbbbfff}  ({[]}ddd)");
            Console.WriteLine($"status is {status} - expected result FALSE");
            status = CheckIfStringIsCorrect("aaaaa{}bbbbbb{fff}}  ({[]}ddd)");
            Console.WriteLine($"status is {status} - expected result FALSE");

        }
        public static bool CheckIfStringIsCorrect(string str)
        {
            Stack<char> checking = new Stack<char>(); // create new stack for checking 
            for (int i = 0; i < str.Length; i++) // run all over the string we got 
            {
                if (CheckIfOpen(str.ElementAt(i))) // if it is one of open parentheses put it in stack
                    checking.Push(str.ElementAt(i));
                else if (CheckIfClose(str.ElementAt(i))) // if it is one of close parentheses check stack
                {
                    if (checking.Count == 0) return false; // if stack is empty nothing to match close parentheses to, so its false
                    char check = checking.Pop(); // pop and save last open parentheses for checking
                    if (CheckMatching(check, str.ElementAt(i)) == false) //if poped open parentheses not equal to current close parentheses return false
                        return false;
                }
            }
            return checking.Count == 0; // return if stack empty


            bool CheckIfOpen(char chr)
            {
                switch (chr)
                {
                    case '(':
                    case '[':
                    case '{':
                    case '<':
                        return true;
                    default:
                        return false;
                }
            }
            bool CheckIfClose(char chr)
            {
                switch (chr)
                {
                    case ')':
                    case ']':
                    case '}':
                    case '>':
                        return true;
                    default:
                        return false;
                }
            }
            bool CheckMatching(char open, char close)
            {
                switch (open)
                {
                    case '(':
                        return close == ')';
                    case '[':
                        return close == ']';
                    case '{':
                        return close == '}';
                }
                return close == '>';
            }
        }
    }
}
