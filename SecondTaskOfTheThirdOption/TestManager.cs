using System;
using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption
{
    public class TestManager
    {
        private readonly List<Question> _questions = new List().Questions;

        public Test[] CreateTests(int quantity)
        {
            var testList = new Test[quantity];
            
            for (var i = 0; i < quantity; i++)
            {
                var test = new Test();
                for (var j = i; j < _questions.Count; j += quantity) test.AddQuestion(_questions[j]);
                testList[i] = test;
            }

            return testList;
        }

        public void PrintTests(Test[] testList)
        {
            foreach (var test in testList)
            {
                Console.WriteLine("Тест----------------");
                for (var j = 0; j < test.GetQuantity(); j++) Console.WriteLine(test.GetQuestionByIndex(j).ToString());
                Console.WriteLine("------------------");
            }
        }
    }
}