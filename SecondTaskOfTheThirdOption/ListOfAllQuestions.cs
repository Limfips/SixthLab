using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption
{
    public class List
    {
        public readonly List<Question> Questions = new List<Question>()
        {
            new Question(Question.Themes.FirstTheme, "01",
                new[] {"1", "2", "3", "4"}, "1"),
            new Question(Question.Themes.FirstTheme, "02",
                new[] {"1", "2", "3", "4"}, "2"),
            new Question(Question.Themes.FirstTheme, "03",
                new[] {"1", "2", "3", "4"}, "3"),
            new Question(Question.Themes.SecondTheme, "04",
                new[] {"1", "2", "3", "4"}, "4"),
            new Question(Question.Themes.SecondTheme, "05",
                new[] {"1", "2", "3", "4"}, "1"),
            new Question(Question.Themes.SecondTheme, "06",
                new[] {"1", "2", "3", "4"}, "2"),
            new Question(Question.Themes.SecondTheme, "07",
                new[] {"1", "2", "3", "4"}, "3"),
            new Question(Question.Themes.SecondTheme, "08",
                new[] {"1", "2", "3", "4"}, "4"),
            new Question(Question.Themes.ThirdTheme, "09",
                new[] {"1", "2", "3", "4"}, "1"),
            new Question(Question.Themes.ThirdTheme, "10",
                new[] {"1", "2", "3", "4"}, "2"),
            new Question(Question.Themes.ThirdTheme, "11",
                new[] {"1", "2", "3", "4"}, "3"),
            new Question(Question.Themes.ThirdTheme, "12",
                new[] {"1", "2", "3", "4"}, "4"),
            new Question(Question.Themes.ThirdTheme, "13",
                new[] {"1", "2", "3", "4"}, "1")
        };
    }
}