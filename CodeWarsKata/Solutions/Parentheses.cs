using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKata.Solutions
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            Stack<char> brackets = new Stack<char>();

            foreach (var bracket in input)
            {
                if ('(' == bracket)
                    brackets.Push(bracket);
                else if(')' == bracket)
                {
                    if (brackets.Count == 0)
                        return false;
                    else 
                        brackets.Pop();
                }
            }

            if (brackets.Count == 0)
                return true;

            // Your code here
            return false;
        }
    }
}
