﻿using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;
        public Book(string name)
        {
            grades = new List<double>();
            this.Name =name;
        }
         public void AddGrade(double grade)
        {
            if(grade >= 0&&grade <=100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average = result.Average / (grades.Count);
            return result; 
        }
        
    }
}