using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption
{
    public class List
    {
        public readonly List<Question> Questions = new List<Question>
        {
            new Question(Question.Themes.FirstTheme, "01",
                new List<string>  {"1", "2", "3", "4"}, "1"),
            new Question(Question.Themes.FirstTheme, "02",
                new List<string> {"1", "2", "3", "4"}, "2"),
            new Question(Question.Themes.FirstTheme, "03",
                new List<string> {"1", "2", "3", "4"}, "3"),
            new Question(Question.Themes.SecondTheme, "04",
                new List<string> {"1", "2", "3", "4"}, "4"),
            new Question(Question.Themes.SecondTheme, "05",
                new List<string> {"1", "2", "3", "4"}, "1"),
            new Question(Question.Themes.SecondTheme, "06",
                new List<string> {"1", "2", "3", "4"}, "2"),
            new Question(Question.Themes.SecondTheme, "07",
                new List<string> {"1", "2", "3", "4"}, "3"),
            new Question(Question.Themes.SecondTheme, "08",
                new List<string> {"1", "2", "3", "4"}, "4"),
            new Question(Question.Themes.ThirdTheme, "09",
                new List<string> {"1", "2", "3", "4"}, "1"),
            new Question(Question.Themes.ThirdTheme, "10",
                new List<string> {"1", "2", "3", "4"}, "2"),
            new Question(Question.Themes.ThirdTheme, "11",
                new List<string> {"1", "2", "3", "4"}, "3"),
            new Question(Question.Themes.ThirdTheme, "12",
                new List<string> {"1", "2", "3", "4"}, "4"),
            new Question(Question.Themes.ThirdTheme, "13",
                new List<string> {"1", "2", "3", "4"}, "1")
        };
    }
}