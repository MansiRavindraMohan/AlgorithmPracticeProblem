using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeProblem
{
    public class InsertionSort
    {
       public void Display()
        {
            Console.WriteLine("Enter a list of words separated by spaces:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            for (int i = 1; i < words.Length; i++)
            {
                string key = words[i];
                int j = i - 1;
                while (j >= 0 && words[j].CompareTo(key) > 0)
                {
                    words[j + 1] = words[j];
                    j--;
                }
                words[j + 1] = key;
            }

            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
