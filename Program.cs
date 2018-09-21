using System;
using System.Collections.Generic;
using inheritance.Models;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog bingo = new Dog(true, "Bingo", 5);
            // bingo.Speak();
            Chihuahua hero = new Chihuahua(true, "Hero", 7, false);
            hero.Speak();
            GreatDane scooby = new GreatDane(true, "Scooby-Doo", 30, false);
            scooby.Speak();


            List<Dog> dogs = new List<Dog>();
            dogs.Add(hero);
            dogs.Add(scooby);

            dogs.ForEach(d =>
            {
                d.Speak();
                d.Eat("chewToy");
            });





        }
    }
}
