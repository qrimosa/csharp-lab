using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Dog : Mammal, IWalkable
    {
        public override string Sound => "Woof";
        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
        public void Walk()
        {
            Console.WriteLine("I walk on the leash");
        }
        public override void ProductMilk()
        {
            Console.WriteLine("Dog is producing milk");
        }
        public void FetchBall()
        {
            Console.WriteLine("Just throw the ball and i'll fetch it!");
        }
        public override string ToString()
        {
            return "I'm a Dog, I do Woof";
        }
    }
}
