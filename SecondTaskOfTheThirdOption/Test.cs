using System;
using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption
{
    public class Test
    {
        private List<Question> _questions;

        public Test() : this(new List<Question>())
        {
        }

        public Test(List<Question> questions)
        {
            _questions = questions;
        }

        public void Add(Question question)
        {
            _questions.Add(question);
        }
        public void Remove(Question question)
        {
            _questions.Remove(question);
        }

        public List<Question> Questions
        {
            get { return _questions; }
        }
    }
}