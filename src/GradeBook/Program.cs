using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Andy's Study Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStats();
            Console.WriteLine($"Average grade is {stats.Average:N1}");
            Console.WriteLine($"Highest grade is {stats.High:N1}");
            Console.WriteLine($"Lowest grade is {stats.Low:N1}");
        }
    }
}
