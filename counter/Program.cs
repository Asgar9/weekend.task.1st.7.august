using System;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit:");
            Console.WriteLine(NumLength(int.Parse(Console.ReadLine( ))));
        }
        static int NumLength(int number)
        {
           int test = number;
            int count = 0;
            while (test>0)
            {
                test = test / 10;
                count++;
            }
            return count;
        }
    }
}
