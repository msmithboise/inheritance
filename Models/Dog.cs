using System;

namespace inheritance.Models
{
    // abstract means a class that cannot be instaniated.  tho it can be inherited from. 
    public abstract class Dog

    // public class Dog
    {


        public bool Tail { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // virtual means it will allow it to be changed
        public virtual void Speak() // i don't want this to return something so I use void, because i have to put some kind of type down.
        {
            Console.WriteLine("Bark");

        }
        public void Eat(string food)
        {
            Console.WriteLine("Nom nom nom");
            if (food != "dog")
            {
                Console.WriteLine("gross");

            }

        }
        public void Eat(string food, int quantity)
        {
            System.Console.WriteLine("nom nom nom");
            if (quantity > 3)
            {
                Console.WriteLine("Ate too much");
            }
        }

        public Dog(bool tail, string name, int age)
        {
            Tail = tail;
            Name = name;
            Age = age;
        }





    }

}