using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Mammal : Animal
    {
        public abstract void ProductMilk();

        public override void Move()
        {
            Console.WriteLine("Mammal moving...");
        }
    }
}
