
using System;
using System.Collections.Generic;

namespace GradeBook

{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            /*int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Array.Find(arr,x=> x==1));
            Console.WriteLine(Array.Exists(arr, x => x == 1));*/

            //List
            /* List<int> l1 = new List<int>();
             l1.Add(5);
             l1.Add(8);
             l1.Add(9);
             foreach(int item in l1)
             {
                 Console.WriteLine(item);
             }
             l1.Remove(8);
             foreach (int item in l1)
             {
                 Console.WriteLine(item);
             }*/

            /*//Dictionary
            Dictionary<string, int> dis = new Dictionary<string, int>();
            dis.Add("a", 1);
            dis.Add("b", 2);
            dis.Add("c", 3);
            dis.Add("d", 4);
            dis.Add("e", 5);
            dis.Add("f", 6);
            dis.Add("g", 7);
            dis.Add("h", 8);
            dis.Add("i", 9);

            //If key is not present it will throw a error
            //Console.WriteLine(dis["j"]);

            //If key is not present it will give value as a zero
           dis.TryGetValue("e",out int number);
            Console.WriteLine(number);

            //If the element is present it will show other wise false
            //Console.WriteLine(dis.ContainsKey("g"));*/

            //Set
            HashSet<int> s = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
            s.Add(6);
            s.Add(7);

            Console.WriteLine(s.Contains(6));

            foreach (int i in s)
            {
                Console.WriteLine(i);
            }






        }

    }
}