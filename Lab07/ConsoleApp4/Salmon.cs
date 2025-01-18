using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Salmon : Animal, ISwimmable
    {
        public override string Sound => "Bloop";
        public void Swim()
        {
            Console.WriteLine("I swim really fast!");
        }
        public override void Move()
        {
            Console.WriteLine("Swimming like a salmon...");
        }
        public override string ToString()
        {
            return "I'm a Salmon, I do Bloop";
        }
    }
}
