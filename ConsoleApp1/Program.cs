using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
      
            GradeBook book = new GradeBook();
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.Name = "Scott's Grade Book";
            book.Name = null;
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            Console.WriteLine("Highest,", stats.HighestGrade);
            Console.WriteLine("Lowest,", stats.LowestGrade);
            Console.WriteLine("Average,", stats.AverageGrade);
        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook name changed from {args.ExistingName} to {args.NewName}");
        }
        
    }
}
