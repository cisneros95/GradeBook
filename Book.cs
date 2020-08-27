using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {   public Book(string name)   // Public is an access modifier
        {
            //Explicit Constructor
            grades = new List<double>();
            this.name = name;
        }
        
        public void AddGrade(double grade)  // Public is an access modifier
        {   
            //local variable
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(var grade in grades)
            {               
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;                
            }
            result.Average /= grades.Count;

            return result;                
        }

        //Field typing
        private List<double> grades;
        private string name;
    }
}