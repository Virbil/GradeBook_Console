using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) //method
        {
            var book = new Book("Bryce's Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.LowValue}");
            Console.WriteLine($"The highest grade is {stats.HighValue}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
