using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            IterateOver(new[] { 1, 2, 3 });

            Console.Read();
        }

        private static unsafe void IterateOver(int[] array)
        {
            fixed (int* b = array)
            {
                int* p = b;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
            }
        }
    }
}
