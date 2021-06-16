using System;

namespace Loop_counting_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int p = 1; p <=5; p++)
            {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            }



        }
    }
}
