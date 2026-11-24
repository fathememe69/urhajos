using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo67
{
    internal class Scientist : Astronaut
    {
        public Scientist(string name, int health, int energy, int oxygen) : base(name, health, energy, oxygen)
        {
        }

        public Scientist(string name, int health, int energy, int oxygen, SpaceSuit suit) : base(name, health, energy, oxygen, suit)
        {
        }

        public void Research()
        {
            Console.WriteLine($"{Name} tudós éppen kutat");
        }

    }
}
