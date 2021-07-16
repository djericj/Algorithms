using System;

namespace Algorithms
{
    public class DivideAndConquer : IAlgorithm
    {
        public void Run()
        {
            var r = new Random();
            var foundIt = false;
            var target = r.Next(1, 100);
            var low = 1;
            var high = 100;
            var index = 0;
            var check = 0;
            Console.WriteLine("Target = " + target);
            do
            {
                index++;
                check = ((high - low) / 2) + low;
                Console.WriteLine("Is it " + check + "?");
                if (target == check)
                {
                    Console.WriteLine("Yes");
                    foundIt = true;
                    break;
                }
                else if (check < target)
                {
                    Console.WriteLine("Higher");
                    low = check;
                }
                else if (check > target)
                {
                    Console.WriteLine("Lower");
                    high = check;
                }

                if (index == high) break;
                Console.WriteLine("Range " + low + " - " + high);
            } while (!foundIt);
            Console.WriteLine("Found it in " + index + " turns");
        }
    }
}