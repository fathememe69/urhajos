using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo67
{
    internal class Engineer : Astronaut
    {
        public Engineer(string name, int health, int energy, int oxygen) : base(name, health, energy, oxygen)
        {
        }

        public Engineer(string name, int health, int energy, int oxygen, SpaceSuit suit) : base(name, health, energy, oxygen, suit)
        {
        }

        public void FixStuff()
        {
            Console.WriteLine($"{Name} asztronauta valamit javít");
        }

    }
}
