using System;
using System.Collections.Generic;
using System.IO;

namespace ThirdTaskOfTheThirdOption
{
    internal class Program
    {
        private const string SourceFilePath = "e:\\in.txt";
        private const string OutputFilePath = "e:\\out.txt";

        public static void Main(string[] args)
        {
            var pupilManager = new PupilManager(Parse());
            Console.WriteLine("Список создан!");

            PupilManager.SortByAverageScore();
            WriteFile(pupilManager);
            Console.WriteLine("Файл записан!");
        }

        private static List<Pupil> Parse() //GetListPupils
        {
            List<Pupil> pupils = new List<Pupil>();
            StreamReader file = StreamReader.Null;
            try
            {
                file = new StreamReader(SourceFilePath);
                string fileLine;
                while ((fileLine = file.ReadLine()) != null)
                    pupils.Add(parsePupil(fileLine));
                file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не удалось открыть, проверте путь");
            }
            finally
            {
                file.Close();
            }

            return pupils;
        }

        private static Pupil parsePupil(string fileLine)
        {
            var simSent = fileLine.Split(' ');
            var pupil = new Pupil(simSent[1], simSent[0],
                Convert.ToInt32(simSent[2]), Convert.ToInt32(simSent[3]),
                Convert.ToInt32(simSent[4]));
            return pupil;
        }

        private static void WriteFile(PupilManager pupilManager)
        {
            StreamWriter file = StreamWriter.Null;
            try
            {
                file = new StreamWriter(OutputFilePath);
                foreach (var pupil in pupilManager.Pupils)
                {
                    file.WriteLine(pupil.GetName());
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Не удалось записать данные в файл, проверте путь");
            }
            finally
            {
                file.Close();
            }
        }
    }
}