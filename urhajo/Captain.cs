using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo67
{
    internal class Captain : Astronaut, IWork
    {
        public Captain(string name, int health, int energy, int oxygen) : base(name, health, energy, oxygen)
        {
        }

        public void GiveOrder(string order, Astronaut astronaut)
        {
            Console.WriteLine($"A {order} feladattal a kapitány {astronaut}-t megbízta");
        }

        

        public void CheckStuff()
        {
            Console.WriteLine("A kapitány ellenőrzi a hajó működését");
        }
        
    }
}
