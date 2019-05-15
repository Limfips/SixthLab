using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption
{
    public class Question
    {
        public enum Themes
        {
            FirstTheme,
            SecondTheme,
            ThirdTheme
        }

        public Question(Themes theme, string question, List<string> optionalAnswers, string correctAnswer)
        {
            Theme = theme;
            _question = question;
            OptionalAnswers = optionalAnswers;
            CorrectAnswer = correctAnswer;
        }

        private Themes Theme { get; set; }

        private string _question { get; set; }

        private List<string> OptionalAnswers { get; set; }

        private string CorrectAnswer { get; set; }

        public override string ToString()
        {
            return Theme + " " + _question;
        }
    }
}