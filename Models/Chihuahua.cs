using System;

namespace inheritance.Models
{

    //Hold control and hover over Dog
    public class Chihuahua : Dog  // this is saying Chihuahua inherits from Dog
    {

        public bool Brave { get; set; }

        public override void Speak()
        {
            Console.WriteLine("Yip");
        }

        public void Eat(int quantity)
        {

        }
        public Chihuahua(bool tail, string name, int age, bool brave) : base(tail, name, age)
        {
            Brave = false;
        }
    }
}