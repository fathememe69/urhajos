using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo67
{
    internal abstract class Astronaut
    {
        public string Name { get; set; }
        public int Health;
        public int Energy
        {
            get;
            private set;
        }
        public int Oxygen;
        public SpaceSuit Suit;

        public Astronaut(string name, int health, int energy, int oxygen, SpaceSuit suit)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Oxygen = oxygen;
            Suit = suit;
        }
        public Astronaut(string name, int health, int energy, int oxygen)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Oxygen = oxygen;            
        }

        public void Showstatus()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Energy: {Energy}");
            Console.WriteLine($"Oxygen: {Oxygen}");
            Console.WriteLine($"Suit model: {Suit.Model}");
            Console.WriteLine($"OxygenLevel: {Suit.OxygenLevel}");
            Console.WriteLine($"Integrity: {Suit.Integrity}");
        }

        public void Rest()
        {
            if (Energy < 20)
            {
                Console.WriteLine("Sürgős pihenés szükséges!");
                Energy += 40;
                Console.WriteLine($"energia: {Energy}");
            }
            else if (Energy < 60)
            {
                Console.WriteLine();
                Energy += 30;
                Console.WriteLine("Az űrhajós pihen");
                Console.WriteLine($"energia: {Energy}");
            }
            else
            {
                Console.WriteLine("Nincs szükség pihenésre.");
            }
        }

        public void Work()
        {
            if (Energy >= 20 && Oxygen >= 20)
            {
                Energy -= 20;
                Oxygen -= 10;
                Console.WriteLine("Az űrhajós dolgozik");
                Console.WriteLine($"energia: {Energy}");
                Console.WriteLine($"Oxigén: {Oxygen}");
            }
            else
            {
                Console.WriteLine("Az űrhajós nem tud dolgozni!");
            }
        }

        public void Diagnostics()
        {
            if (Health < 30 && Energy < 20)
            {
                Console.WriteLine("Orvosi vészhelyzet.");
                Rest();
            }
            else if (Health < 30 && Oxygen < 50)
            {
                Console.WriteLine("Orvosi ellátás szükséges!");
            }
            else if ((Health < 30 && Energy < 30) || (Oxygen < 20 && Energy < 30))
            {
                Console.WriteLine("Vészhelyzeti regenerálódás szükséges");
                Rest();
            }
            else if (Energy < 30)
            {
                Console.WriteLine("Az űrhajós kimerült.");
                Rest();
            }
            else if (Oxygen < 30)
            {
                Console.WriteLine("Figyelem: alacsony oxigénszint!");
            }
            else
            {
                Console.WriteLine("Az űrhajós készenáll");
            }
        }

    }
}
