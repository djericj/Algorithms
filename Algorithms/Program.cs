using System;

namespace Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Choose an algorithm:");
            Console.WriteLine("1) Bubble Sort");
            Console.WriteLine("2) Collatz Conjecture");
            Console.WriteLine("3) Divide and Conquer");
            Console.WriteLine("4) Fibonacci Sequence");
            Console.WriteLine("5) Fizz Buzz");
            var choice = Console.ReadLine();
            Runner(choice);
        }

        private static void Runner(string choice)
        {
            if (choice == "1") new BubbleSort().Run();
            if (choice == "2") new CollatzConjecture().Run();
            if (choice == "3") new DivideAndConquer().Run();
            if (choice == "4") new FibonacciSequence().Run();
            if (choice == "5") new FizzBuzz().Run();
        }
    }
}