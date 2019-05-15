using System;
using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption
{
    public class TestManager
    {
        private readonly List<Question> _questions;
        private List<Test> _tests;
        public TestManager(List<Question> questions)
        {
            _questions = questions;
        }

        public List<Test> CreateTests(int quantity)
        {
            for (var i = 0; i < quantity; i++)
            {
                var test = new Test();
                for (var j = i; j < _questions.Count; j += quantity) test.Add(_questions[j]);
                _tests.Add(test);
            }
            return _tests;
        }

        public void Add(Test test)
        {
            _tests.Add(test);
        }
        public void Remove(Test test)
        {
            _tests.Remove(test);
        }

        public List<Test> Tests
        {
            get { return _tests; }
            set { _tests = value; }
        }

        public Test GetTest(int index)
        {
            return _tests[index];
        }


//Чисто для проверки, работает ли оно.
        public void PrintTests(List<Test> testList)
        {
            foreach (var test in testList)
            {
                Console.WriteLine("Тест----------------");
                foreach (var question in test.Questions)
                {
                    Console.WriteLine(question.ToString());
                } 
                Console.WriteLine("------------------");
            }
        }
    }
}