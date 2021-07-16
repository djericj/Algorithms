using System;

namespace Algorithms
{
    /*
    The  Collatz Conjecture:
    Pick a number, any number. If it's odd, multiply it by 3 and add 1. If it's even, divide it by 2. Now you have a new number.
    Apply the same rules to the new number.
    The conjecture is about what happens as you keep repeating the process. Intuition might suggest that the number you start
    with affects the number you end up with. Maybe some numbers eventually spiral all the way down to 1. Maybe others go marching
    off to infinity.  But Collatz predicted that's not the case. He conjectured that if you start with a positive whole number and
    run this process long enough, all starting values will lead to 1. And once you hit 1, the rules of the Collatz conjecture confine
    you to a loop: 1, 4, 2, 1, 4, 2, 1, on and on forever.
    */

    public class CollatzConjecture : IAlgorithm
    {
        public void Run()
        {
            Random r = new Random();
            CollatzConjectureAlgorithm(r.Next());
        }

        public void CollatzConjectureAlgorithm(decimal num)
        {
            decimal r = 0;
            if (num % 2 == 0)
            {
                r = num / 2m;
            }
            else
            {
                r = (num * 3m) + 1m;
            }
            Console.WriteLine(r);
            CollatzConjectureAlgorithm(r);
        }
    }
}