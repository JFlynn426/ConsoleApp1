using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();

            GetBookName(book);
            WriteResults(book);

            using (StreamWriter outputfile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputfile);
            }

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Highest,", stats.HighestGrade);
            WriteResult("Lowest,", stats.LowestGrade);
            WriteResult("Average,", stats.AverageGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void WriteResults(GradeBook book)
        {
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter A Name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook name changed from {args.ExistingName} to {args.NewName}");
        }
        static void WriteResult (string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
