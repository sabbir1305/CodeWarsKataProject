using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKata.Solutions
{
  public  class CheckMagazine
    {

        /*
         * Complete the 'checkMagazine' function below.
         *
         * The function accepts following parameters:
         *  1. STRING_ARRAY magazine
         *  2. STRING_ARRAY note
         */

        public static string checkMagazineInput(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (words.ContainsKey(word))
                {
                    words[word] = words[word] + 1;
                }
                else
                {
                    words[word] = 1;
                }
            }
            foreach (var word in note)
            {
                if (words.ContainsKey(word))
                {
                    words[word] = words[word] - 1;
                    if (words[word] == 0)
                    {
                        words.Remove(word);
                    }

                }
                else
                {
                 return   "No";
           
                }
            }
            return  "Yes";
        }

    }


}
