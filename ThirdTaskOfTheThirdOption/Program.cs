using System;
using System.IO;

namespace ThirdTaskOfTheThirdOption
{
    internal class Program
    {
        private const string SourceFilePath = "e:\\in.txt";
        private const string OutputFilePath = "e:\\out.txt";

        public static void Main(string[] args)
        {
            var students = new Students(GetListStudents());
            Console.WriteLine("Список создан!");

            Students.SortByAverageScore(students);
            WriteFile(students);
            Console.WriteLine("Файл записан!");
        }

        private static Disciple[] GetListStudents()
        {
            Disciple[] students;
            try
            {
                var file = new StreamReader(SourceFilePath);
                var n = Convert.ToInt32(file.ReadLine());
                students = new Disciple[n];
                string fileLine;
                var position = 0;
                while ((fileLine = file.ReadLine()) != null) students[position++] = GetNewStudent(fileLine);
                file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не удалось открыть, проверте путь");
                throw;
            }

            return students;
        }

        private static Disciple GetNewStudent(string fileLine)
        {
            var simSent = fileLine.Split(' ');
            var undergrad = new Disciple(simSent[1], simSent[0],
                Convert.ToInt32(simSent[2]), Convert.ToInt32(simSent[3]),
                Convert.ToInt32(simSent[4]));
            return undergrad;
        }

        private static void WriteFile(Students students)
        {
            try
            {
                var file = new StreamWriter(OutputFilePath);

                var quantity = students.GetQuantity();
                for (var index = 0; index < quantity; index++) file.WriteLine(students.GetByIndex(index).GetName());
                file.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Не удалось записать данные в файл, проверте путь");
                throw;
            }
        }
    }
}