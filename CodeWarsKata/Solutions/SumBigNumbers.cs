using System;
using System.Collections.Generic;
using System.Text;


namespace CodeWarsKata.Solutions
{
   public class SumBigNumbers
    {
        public static string Add(string a, string b)
        {
            Stack<int> firstNum = new Stack<int>();
            Stack<int> secondNum = new Stack<int>();
          


            foreach (var item in a)
            {
                firstNum.Push(Convert.ToInt32(item.ToString()));
            }
            foreach (var item in b)
            {
            
                secondNum.Push(Convert.ToInt32(item.ToString()));
            }
            if (firstNum.Count > secondNum.Count)
            {
                return Sum(firstNum, secondNum).ToString();
            }
            else
            {
                return Sum(secondNum, firstNum).ToString();
            }
           
       


          
        }

        private static StringBuilder Sum(Stack<int> firstNum, Stack<int> secondNum)
        {
            Stack<int> result = new Stack<int>();
            int remain = 0, res = 0;
            foreach (var item in firstNum)
            {

                if (secondNum.Count > 0)
                {
                    res = remain + item + secondNum.Pop();



                }
                else
                {
                    res = remain + item;
                }
                result.Push(res % 10);
                remain = res > 9 ? 1 : 0;
            }
            if (res > 0)
                result.Push(remain);

            StringBuilder builder = new StringBuilder();
            while (result.Count > 0)
            {
                builder.Append(result.Pop());
            }

            return builder;
        }
    }
}
