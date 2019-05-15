using System;
using System.Collections.Generic;

namespace ThirdTaskOfTheThirdOption
{
    public class PupilManager
    {
        private static List<Pupil> _pupils;

        public PupilManager() : this(new List<Pupil>()){}

        public PupilManager(List<Pupil> pupils)
        {
            _pupils = pupils;
        }

        public List<Pupil> Pupils
        {
            get { return _pupils; }
            set { _pupils = value; }
        }

        public void Add(Pupil pupil)
        {
            _pupils.Add(pupil);
        }
        public void Remove(Pupil pupil)
        {
            _pupils.Remove(pupil);
        }
        
        public static Pupil GetByIndex(int studentIndex)
        {
            return _pupils[studentIndex];
        }

        private static void Swap(int firstIndex, int secondIndex)
        {
            var tmp = _pupils[firstIndex];
            _pupils[firstIndex] = _pupils[secondIndex];
            _pupils[secondIndex] = tmp;
        }

        public static void SortByAverageScore()
        {
            foreach (var pupil in _pupils)
            {
                for (var index = 0; index < _pupils.Count - 1; index++)
                    if (GetByIndex(index).GetAverageScore() < GetByIndex(index + 1).GetAverageScore())
                        Swap(index, index + 1); 
            }
        }
    }
}