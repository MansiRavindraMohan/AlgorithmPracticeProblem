namespace AlgorithmPracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data structure algorithm practice problem");

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.DisplayNumbers();

            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.Display();

            //BinarySearch binarySearch= new BinarySearch();
            //binarySearch.WordList();

            //Anagram anagram = new Anagram();
            //anagram.DispayAnagram();

            Console.WriteLine("Enter the list of words, separated by commas:");
            string[] words = Console.ReadLine().Split(',');

            MergeSortStringArray(words, 0, words.Length - 1);

            Console.WriteLine("Sorted list:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }

        static void MergeSortStringArray(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSortStringArray(arr, left, mid);
                MergeSortStringArray(arr, mid + 1, right);

                MergeStringArrays(arr, left, mid, right);
            }
        }

        static void MergeStringArrays(string[] arr, int left, int mid, int right)
        {
            int leftLength = mid - left + 1;
            int rightLength = right - mid;

            string[] leftArr = new string[leftLength];
            string[] rightArr = new string[rightLength];

            for (int i = 0; i < leftLength; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (int j = 0; j < rightLength; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            int k = left;
            int iLeft = 0;
            int iRight = 0;

            while (iLeft < leftLength && iRight < rightLength)
            {
                if (leftArr[iLeft].CompareTo(rightArr[iRight]) < 0)
                {
                    arr[k] = leftArr[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArr[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < leftLength)
            {
                arr[k] = leftArr[iLeft];
                iLeft++;
                k++;
            }

            while (iRight < rightLength)
            {
                arr[k] = rightArr[iRight];
                iRight++;
                k++;
            }
        }
    }
}
