
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        enum monthsOfyear { Jan, Feb, March, April, May, Jun, July, August, Sept, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            var book = new Book("Sanika's grade book");
            Console.WriteLine("Enter How many number You want to enter");
            
            var input = Console.ReadLine();
            var count = double.Parse(input);
            Console.WriteLine("Enter the numbers");
            for (int i = 0;i<count;i++)
            {
                try
                {
                    var a = Console.ReadLine();
                    book.AddGrade(double.Parse(a));
                }
                 catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
         

            //book.AddGrade(89.6);
            //book.AddGrade(90.6);
            //book.AddGrade(92.6);


            var stats= book.GetStatistics();
            Console.WriteLine("The highest value is "+stats.High);
            Console.WriteLine("The Lowest value is  "+stats.Low);
            Console.WriteLine("The average of the numbers is " + Math.Round(stats.Average,1));


            if("Jan"==monthsOfyear.Jan.ToString())
            {
                Console.WriteLine("Its right");
            }
            
                
        }
    }
}