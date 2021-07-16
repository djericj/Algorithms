using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /*
    In mathematics, the Fibonacci numbers, commonly denoted Fn form a sequence, called the Fibonacci sequence,
    such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,

    F0 = 0, F1 = 1

    and

    Fn = Fn-1 + Fn-2 for n > 1.

    One has F2 = 1. In some books, and particularly in old ones, F0, the "0" is omitted,
    and the Fibonacci sequence starts with F1 = F2 = 1.[2][3] The beginning of the sequence is thus:

    (0,) 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
    */

    public class FibonacciSequence : IAlgorithm
    {
        public void Run()
        {
            // Fibonacci Sequence in C#
            // Eric Rydberg (djericj@hotmail.com)

            int[] a = new int[3] { 1, 0, 0 }; // 0 = current, 1 = previous, 2 = 2 previous
            do
            {
                a[1] = a[0];
                a[0] = a[1] + a[2];
                a[2] = a[1];
                Console.WriteLine(a[0]);
            } while (a[0] < 10000); // max length
        }
    }
}