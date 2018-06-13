using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int innerSpaceCounter = n - 2;
            int outSpaceCount = 0;

            for (int i = 0; i < n/2; i++)
            {
                string innerSpace = new string(' ', innerSpaceCounter);
                string outterSpace = new string(' ', outSpaceCount);
                Console.WriteLine("{0}x{1}x",outterSpace,innerSpace);
                outSpaceCount += 1;
                innerSpaceCounter -= 2;
            }

            Console.WriteLine("{0}x",new string(' ',outSpaceCount));

            outSpaceCount -= 1;
            innerSpaceCounter = 1;
            for (int i = 0; i < n / 2; i++)
            {
                string innerSpace = new string(' ', innerSpaceCounter);
                string outterSpace = new string(' ', outSpaceCount);
                Console.WriteLine("{0}x{1}x", outterSpace, innerSpace);
                outSpaceCount -= 1;
                innerSpaceCounter += 2;
            }
        }
    }
}
