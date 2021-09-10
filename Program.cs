using System;
using System.Collections;

namespace yield1
{
    class Program
    {
        static IEnumerable FindEven(int[] arr)
        {
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 == 0)
                        yield return arr[i];
            }
            else
            {
                yield break;
            }
            // то же самое  - создается лист, удовлетворяющий условию.
            /*var even = new List<object>();
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 == 0)
                        even.Add(arr[i]);
            }
            return even;*/
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            IEnumerable res = FindEven(array);
            foreach (int elem in res)
                Console.Write("{0}  ", elem);
            Console.Write("\n");


        }
    }
}
