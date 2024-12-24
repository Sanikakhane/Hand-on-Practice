
using System;
using System.Collections.Generic;

namespace GradeBook

{
    //public abstract class animal
    //{
    //    public abstract void eat();
    //    public abstract void speak();
    //    public void walk()
    //    {
    //        Console.WriteLine("Walking on 4 legs");
    //    }
    //}
    //class Dog : animal
    //{
    //    public override void eat()
    //    {
    //        Console.WriteLine("Eating meat");
    //    }
    //    public override void speak()
    //    {
    //        Console.WriteLine("Barking ..");
    //    }
    //    public void walk()
    //    {
    //        Console.WriteLine("Walking on 3 legs");
    //    }
    //}

    public interface animal
    {
        void eat();
        void walk();
        void speak();
    }
    class Dog:animal
    {
        public void eat()
        {
            Console.WriteLine("Eating meat");
        }
        public void speak()
        {
            Console.WriteLine("Barking ..");
        }
        //public void walk()
        //{
        //    Console.WriteLine("Walking on 4 legs");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.walk();
            d.eat();
            d.speak();

        }

    }
}