using System;

namespace Algorithms
{
    /*
     * The task is simple: Print integers 1 to N, but print “Fizz” if an integer is divisible by 3,
     * “Buzz” if an integer is divisible by 5, and “FizzBuzz” if an integer is divisible by both 3 and 5
     * */

    public class FizzBuzz : IAlgorithm
    {
        public void Run()
        {
            // FizzBuzz in c#
            // Eric Rydberg (djericj@hotmail.com)

            int n = 0;
            do
            {
                if ((n % 3) == 0 && (n % 5) == 0) Console.WriteLine("FizzBuzz");
                else if ((n % 3) == 0) Console.WriteLine("Fizz");
                else if ((n % 5) == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(n);
                n++;
            } while (n < 100);
        }
    }
}