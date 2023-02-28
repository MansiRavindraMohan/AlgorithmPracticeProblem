using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeProblem
{
    public class BubbleSort
    {
        public void DisplayNumbers()
        {
            int[] arr = { 48, 75, 69, 28, 10 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
            {
                Console.WriteLine(p);
            }
        }
    }
}
