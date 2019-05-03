using System;

namespace SecondTaskOfTheThirdOption
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many tests do you need?");
            var quantity = Convert.ToInt32(Console.ReadLine());
            TestManager testManager = new TestManager();
            Test[] tests = testManager.CreateTests(quantity);
            Console.WriteLine("Tests generated!");
            testManager.PrintTests(tests);
        }
    }
}