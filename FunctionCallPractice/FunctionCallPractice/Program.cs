using System;

namespace FunctionCallPractice
{
    class Program
    {
        public static void PrintSomething()
        {
            Console.WriteLine("3");
        }

        public static void PrintSomething(int arg1)
        {
            Console.WriteLine("7");
        }

        public static void PrintSomething(int arg1, int arg2)
        {
            Console.WriteLine("4");
        }

        public static void PrintSomething(String arg1)
        {
            Console.WriteLine("1");
        }

        public static void PrintSomething(String arg1, String arg2)
        {
            Console.WriteLine("5");
        }

        public static void PrintSomething(String arg1, int arg2)
        {
            Console.WriteLine("6");
        }

        public static void PrintSomething(int arg1, String arg2)
        {
            Console.WriteLine("2");
        }

        /* The goal of this activity is to practice your function calls.
         * 
         * Above are 4 functions that are each functionally very similar.  They each print a different number
         * to the screen.  But what makes them different is the number of and types of arguments.  You are not allowed to 
         * change how they work at all.
         * 
         * Your objective is to call the functions listed above in a way that causes the program to output the numbers in order
         * as follows:
         * 
         * TARGET OUTPUT:
         * 1
         * 2
         * 3
         * 4
         * 5
         * 6
         * 7
         * 
         * To do this, pay attention to the differences in the signature (or definition) of the function.  By change what arguments
         * you give the function, you get different behaviors.
         * 
         * As a hint, the arguments you're giving it are not being used for anything; so you can give it any argument so long as the
         * argument you give the function matches the *TYPE* of the argument of the function you'd like to use.
         */
        static void Main(string[] args)
        {
            // All new code written must be in here; no changes to the functions above are allowed
        }
    }
}

