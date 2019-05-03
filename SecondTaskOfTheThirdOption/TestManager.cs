using System;

namespace SecondTaskOfTheThirdOption
{
    public class TestManager
    {
        private readonly Question[] _questions = new List().Questions;

        public Test[] CreateTests(int quantity)
        {
            Test[] tests = new Test[quantity];
            
            for (int i = 0; i < quantity; i++)
            {
                Test test = new Test();
                var j = i;
                for (; j < _questions.Length; j+=quantity)
                {
                    test.AddQuestion(_questions[j]);
                }
                tests[i] = test;
            }
            
            return tests;
        }

        public void PrintTests(Test[] tests)
        {
            foreach (var test in tests)
            {
                Console.WriteLine("Тест----------------");
                for (int j = 0; j < test.GetQuantity(); j++)
                {
                    Console.WriteLine(test.GetQuestionByIndex(j).ToString());
                }
                Console.WriteLine("------------------");
            }
        }
    }
}