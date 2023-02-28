using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeProblem
{
    public class Anagram
    {
        public void DispayAnagram()
        {
            string str1 = "heart";
            string str2 = "earth";
            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string val1 = new string(char1);
            string val2 = new string(char2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if (val1 == val2)
            {
                Console.WriteLine("Both string are anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not anagram");
            }
        }
    }
}
