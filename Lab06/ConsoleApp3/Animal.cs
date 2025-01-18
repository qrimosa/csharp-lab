using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Animal
    {
        public Animal(string name, string species)
        {
            this.Name = name;
            this.Species = species;
        }
        public string Name { get; set; }
        public string Species { get; set; }
    }
}
