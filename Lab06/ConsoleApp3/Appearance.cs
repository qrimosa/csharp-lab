using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Appearance
    {
        public Appearance(string eyescolor, string haircolor, bool hasfreckles) 
        {
            this.EyesColor = eyescolor;
            this.HairColor = haircolor;
            this.HasFreckles = hasfreckles;
        }
        public string EyesColor { get; set; }
        public string HairColor { get; set; }
        public bool HasFreckles { get; set; }
    }
}
