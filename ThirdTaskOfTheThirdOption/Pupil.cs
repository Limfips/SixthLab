using System;

namespace ThirdTaskOfTheThirdOption
{
    public class Pupil //Ученик
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly double _averageScore;

        public Pupil(string firstName, string lastName,
            int mathScore, int physicsScore, int informaticsScore)
        {
            _firstName = firstName;
            _lastName = lastName;
            _averageScore = Math.Round((mathScore + physicsScore + informaticsScore) / 3.0, 2);
        }

        public override string ToString()
        {
            return _lastName + _firstName + "\nОценки: " + _averageScore;
        }

        public double GetAverageScore()
        {
            return _averageScore;
        }

        public string GetName()
        {
            return _lastName + " " + _firstName;
        }
    }
}