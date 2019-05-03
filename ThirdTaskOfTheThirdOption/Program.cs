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
            Students students = new Students(GetListStudents());
            Console.WriteLine("Список создан!");

            Students.SortByAverageScore(students);
            WriteToFileStudents(students);
            Console.WriteLine("Файл записан!");
        }
        private static Undergrad[] GetListStudents()
        {
            Undergrad[] undergrads;
            try
            {
                var file = new StreamReader(SourceFilePath);
                int n = Convert.ToInt32(file.ReadLine());
                undergrads = new Undergrad[n];
                string fileLine;
                int pos = 0;
                while ((fileLine = file.ReadLine()) != null)
                {
                    undergrads[pos++] = GetNewStudent(fileLine);
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не удалось открыть, проверте путь");
                throw;
            }
            return undergrads;
        }
        private static Undergrad GetNewStudent(string fileLine)
        {
            var simSent = fileLine.Split(' ');
            Undergrad undergrad = new Undergrad(simSent[1], simSent[0],
                Convert.ToInt32(simSent[2]), Convert.ToInt32(simSent[3]),
                Convert.ToInt32(simSent[4]));
            return undergrad;
        }
        private static void WriteToFileStudents(Students students)
        {
            try
            {
                StreamWriter file = new StreamWriter(OutputFilePath);

                var quantity = students.GetQuantity();
                for (int index = 0; index < quantity; index++)
                {
                    file.WriteLine(students.GetByIndex(index).GetName());
                }
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