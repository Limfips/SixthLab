using System;

namespace SecondTaskOfTheThirdOption
{
    public class Question
    {
        private readonly ThemeEnum _theme;
        private readonly string _question;
        private readonly string[] _optionalAnswers;
        private readonly string _correctAnswer;

        public Question(ThemeEnum theme, string question, string[] optionalAnswers, string correctAnswer)
        {
            _theme = theme;
            _question = question;
            _optionalAnswers = optionalAnswers;
            _correctAnswer = correctAnswer;
        }

        public enum ThemeEnum
        {
            FirstTheme,
            SecondTheme,
            ThirdTheme
        }

        public ThemeEnum Theme => _theme;

        public string Question1 => _question;

        public string[] OptionalAnswers => _optionalAnswers;

        public string CorrectAnswer => _correctAnswer;

        public override string ToString()
        {
            return _theme+" "+_question;
        }
    }
}