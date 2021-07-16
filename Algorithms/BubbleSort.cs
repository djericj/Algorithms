using System;

namespace Algorithms
{
    /*
    Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly
    steps through the list, compares adjacent elements and swaps them if they are in the wrong order.
    The pass through the list is repeated until the list is sorted.
    */

    public class BubbleSort
    {
        public void Run()
        {
            var ar = new[] { 3, 7, 5, 9, 4, 8, 7, 9, 0, 5, 6, 8, 9, 3, 4, 5, 7, 1, 3, 5, 4 };
            for (var x = 0; x <= ar.GetUpperBound(0); x++)
            {
                if (x > 0)
                {
                    var a = ar[x - 1];
                    var b = ar[x];
                    if (b < a)
                    {
                        ar[x - 1] = b;
                        ar[x] = a;
                        x = 0;
                    }
                }
            }

            Array.ForEach<int>(ar, Console.WriteLine);
        }
    }
}