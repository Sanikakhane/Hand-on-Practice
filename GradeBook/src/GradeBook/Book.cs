using System.Collections.Generic;
namespace GradeBook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }
         public string Name 
        { 
            get; 
            set;
        }    
    }

    public class Book: NamedObject
    {
        private List<double> marks;
        private List<char> grades;
        public Book(string name):base (name) 
        {
            grades = new List<char>();
            marks = new List<double>();
            this.Name =name;
        }
         public void AddGrade(double grade)
        {
            if(grade >= 0&&grade <=100)
            {
                marks.Add(grade);
                switch(grade)
                {
                    case double n when n >= 90:
                        grades.Add('A');
                        break;
                    case double n when n >= 80:
                        grades.Add('B');
                        break;
                    case double n when n >= 70:
                        grades.Add('C');
                        break;
                    case double n when n >= 60:
                        grades.Add('D');
                        break;
                    case double n when n >= 50:
                        grades.Add('E');
                        break;
                    default:
                        Console.WriteLine("Invlaid marks");
                        break;

                }
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
            foreach (var grade in marks)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average = result.Average / (marks.Count);
            return result; 
        }
        
    }
}