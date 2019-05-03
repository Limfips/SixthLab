using System;

namespace ThirdTaskOfTheThirdOption
{
    public class Students
    {
        private Undergrad[] _students;

        public Students() : this(new Undergrad[0]){}
        public Students(Undergrad[] students)
        {
            _students = students;
        }

        public void Add(Undergrad undergrad)
        {
            Array.Resize(ref _students, _students.Length+1);
            _students[_students.Length-1] = undergrad;
        }
        
        public Undergrad GetByIndex(int studentIndex)
        {
            return _students[studentIndex];
        }
        
        public int GetQuantity()
        {
            return _students.Length;
        }

        private void Swap(int firstIndex, int secondIndex)
        {
            var tmp = _students[firstIndex];
            _students[firstIndex] = _students[secondIndex];
            _students[secondIndex] = tmp;
        }
        
        public static void SortByAverageScore(Students students)
        {
            var quantity = students.GetQuantity();
            for (int elementIndex = 0; elementIndex < quantity; elementIndex++)
            {
                for (int index = 0; index < quantity-1; index++)
                {
                    if (students.GetByIndex(index).GetAverageScore()<students.GetByIndex(index+1).GetAverageScore())
                    {
                        students.Swap(index,index+1);
                    }
                }
            }
        }
    }
}
