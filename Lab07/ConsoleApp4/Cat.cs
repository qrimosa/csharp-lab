using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cat : Mammal, IWalkable, ISwimmable
    {
        public override string Sound => "Meow";

        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
        public void Walk()
        {
            Console.WriteLine("I like walking on furniture and tables");
        }
        public void Swim()
        {
            Console.WriteLine("I swim poorly");
        }
        public override void ProductMilk()
        {
            Console.WriteLine("Cat is producing milk");
        }
        public void ThrowOfTheTable()
        {
            Console.WriteLine("If you put something on the table I'll throw it on the floor!");
        }
        public override string ToString()
        {
            return "I'm a Cat, I do Meow";
        }
    }
}
