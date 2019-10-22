using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var bstTest = new Bst<int>();
            bstTest.Insert(28);
            bstTest.Insert(37);
            bstTest.Insert(46);
            bstTest.Insert(15);
            bstTest.Insert(12);
            bstTest.Insert(20);

            foreach (var i in bstTest.TraverseInOrder())
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine(bstTest.Min());
            Console.WriteLine(bstTest.Max());
            Console.WriteLine(bstTest.Get(20).Value);
            Console.Read();
        }
    }
}
