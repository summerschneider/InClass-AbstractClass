using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    public class Cow : Animal
    {
        public Cow(string name)
        {
            Name = name;
        }

        public Cow()
        {
            Name = "Spot";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says moo");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleeps. Zzzzzzzzz");
        }
    }
}
