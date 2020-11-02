using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //state or data it holds
        //behavior or how to use my book
        // hold grades
        // act on grades: add new, ...

        public Book(string name) //explicit constructor
        {
            grades = new List<double>();
            Name = name; //Name the field, name the parameter
        }
        public void AddGrade(double myGrade)
        {
            if (myGrade > 0)
            {
                if (myGrade <= 100)
                {
                    grades.Add(myGrade);
                }
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.HighValue = double.MinValue;
            result.LowValue = double.MaxValue;

            foreach (var grade in grades)
            {
                result.LowValue = Math.Min(grade, result.LowValue);
                result.HighValue = Math.Max(grade, result.HighValue);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades; //this is a field
        public string Name;
    }
}
