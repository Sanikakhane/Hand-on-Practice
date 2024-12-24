
using System;
using System.Collections.Generic;

namespace GradeBook

{
    class Person
    {
        private string? name;
        protected int Id;
        public string? Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be null");
                }
            }
        }
        
    }
    class Employee : Person
    {
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if(salary>=0)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary must be grater than 0");
                }
            }
        }
        public void setid(int id)
        {
            Id = id;
        }
        public int getid()
        {
            return Id;
        }

    }
    class Program
    {
        enum monthsOfyear { Jan, Feb, March, April, May, Jun, July, August, Sept, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            //var book = new Book("Sanika's grade book");


            //Taking inputs from command prompt
            //Console.WriteLine("Enter How many number You want to enter");


            /*var input = Console.ReadLine();
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
            Console.WriteLine("The average of the numbers is " + Math.Round(stats.Average,1*/

            //Learning about enum
            /*if("Jan"==monthsOfyear.Jan.ToString())
            {
                Console.WriteLine("Its right");
            }
            

            //Date Time Datatype
            DateTime dateTime = DateTime.Today;
            Console.WriteLine(dateTime);

            DateTime birthday = new DateTime(2003, 5, 1);
            DateTime endDay = DateTime.Today;

            //Console.WriteLine(endDay.Year - birthday.Year+" "+endDay.Month-birthday.Month+" "+endDay.Day-birthday.Day
            //


            //Escape characters
            string path = "C:\\Users\\Khan_San\\source\\repos\\Hand-on-Practice";
            string str = "\"Hii!!!!!\"";
            Console.WriteLine(path);
            Console.WriteLine(str);

            //parse and Tryparse functions
            string s = "1236";
            int n=int.Parse(s);
            Console.WriteLine(n);

            string a = "89";
            int result;
            if(int.TryParse(a,out result))
            {
                Console.WriteLine($"Success {result}");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }*/


            //pass by Reference 

            // Console.WriteLine(add(a, b));
            /*  var a = 5;
             var b = 6;
             Console.WriteLine(a+" "+b);


             Console.WriteLine(add(a,ref b));
             Console.WriteLine(a + " " + b);*/




            //Params
            /* int c = 10, d = 20;
             double e = 10.6;
             Console.WriteLine(add(a,b,c,d,10,20));*/


            //Protected access modifier
            Person p = new Person();
            p.Name = "Sanika";
            Console.WriteLine(p.Name);

            Employee e = new Employee();
            e.Name = "Sanika";
            e.setid(1);
            Console.WriteLine(e.getid());



        }

        public static int add(int a,int b)
        {
            b += 10;
            return a + b;
        }

        public static int add(int a,ref int b)
        {
            b += 10;
            return a + b;
        }

        public static int add(params int[] values)
        {
            int result = 0;
            foreach(int i in values)
            {
                result += i;
            }
            return result;
        }
    }
}