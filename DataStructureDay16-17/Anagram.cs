using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay16_17
{
    public class Anagram
    {
        public static void CheckAnagram()
        {
            string firstword = "heater";
            string secondword = "reheat";
            char[] charfirst = firstword.ToLower().ToCharArray();
            char[] charsecond = secondword.ToLower().ToCharArray();
            Array.Sort(charfirst);
            Array.Sort(charsecond);
            string objfirstword = new string(charfirst);
            string objsecondword = new string(charsecond);
            if (objfirstword == secondword)
            {
                Console.WriteLine("Both Strings Are Anagram ");
            }
            else
            {
                Console.WriteLine("Both Words are not anagram");
            }
        }
    }
}
