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

        public Question(Themes theme, string question, string[] optionalAnswers, string correctAnswer)
        {
            Theme = theme;
            _question = question;
            OptionalAnswers = optionalAnswers;
            CorrectAnswer = correctAnswer;
        }

        private Themes Theme { get; }

        private string _question { get; }

        private string[] OptionalAnswers { get; }

        private string CorrectAnswer { get; }

        public override string ToString()
        {
            return Theme + " " + _question;
        }
    }
}