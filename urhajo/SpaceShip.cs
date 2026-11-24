using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo67
{
    internal class SpaceShip
    {
        private string name = "Unnamed";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != "")
                {
                    name = value;
                }
            }

        }
        public int Hull;
        public int Shield;
        public int Fuel;
        public string EngineType
        {
            get;

        }
        public int fuelNeeded;



        public List<Astronaut> Astronauts;

        public int CrewCount
        {
            get
            {
                return Astronauts.Count;
            }
        }



        public SpaceShip(string name, int hull, int shield, int fuel, string engine, int fuelneed, List<Astronaut> astronauts)
        {
            Name = name;
            Hull = hull;
            Shield = shield;
            Fuel = fuel;
            EngineType = engine;
            fuelNeeded = fuelneed;
            Astronauts = astronauts;



        }
        public void ShowStatus()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Hull}");
            Console.WriteLine($"{Shield}");
            Console.WriteLine($"{Fuel}");
            Console.WriteLine($"{CrewCount}\n");
        }

        public void TakeDamage()
        {
            Shield -= 30;
            Hull -= 20;
            Console.WriteLine("Találat érte a hajót!");
            Console.WriteLine($"shield: {Shield}, hull: {Hull}");
        }
        public void Travel(int distance)
        {
            CanTravel(distance);

            if (CanTravel(distance) is true)
            {
                if (EngineType == "efficient")
                {
                    Fuel -= fuelNeeded * (distance / 5) / 2;
                }
                else
                {
                    Fuel -= fuelNeeded * (distance / 5);
                }
                Console.WriteLine("A hajó elindult\n");
            }
            else
            {
                Console.WriteLine("Better fuel Huel\n");
            }
        }


        public void Repair()
        {
            if (Hull < 30)
            {
                Hull += 40;
                Console.WriteLine("Kritikus javítás folyamatban");
                Console.WriteLine($"Hull:{Hull}\n");
            }
            else if (Hull < 70)
            {
                Hull += 25;
                Console.WriteLine("Normál javítás folyamatban\n");
            }
            else
            {
                Console.WriteLine("Nincs szükség javításra\n");
            }

        }

        public void Diagnostics()
        {
            if ((Hull < 20 && Shield < 20) || (Fuel < 10 && Hull < 20))
            {
                Console.WriteLine("Extrém vészhelyzet");
                Repair();
                ShowStatus();
            }

            else if (Hull < 30 && Shield < 30 && Fuel < 20)
            {
                Console.WriteLine("Kritikus vészhelyzet");
                Repair();
                ShowStatus();
            }
            else if (Hull < 50 && Shield < 50)
            {
                Console.WriteLine("Súlyos sérülés");
                Repair();
            }
            else if (Fuel < 20 || Shield < 30)
            {
                Console.WriteLine("Erőforrás figyelmeztetés!");
            }
            else
            {
                Console.WriteLine("Minden hajórendszer megfelelően működik.");
            }
        }

        public bool CanTravel(int distance)
        {
            int fakeFuel2 = fuelNeeded * (distance / 5);

            if (EngineType == "efficient")
            {
                fakeFuel2 = fakeFuel2 / 2;
            }

            if (fakeFuel2 <= Fuel)
            {
                return true;
            }
            else
            {
                return false;
            }

            /*
            int fakeFuel = Fuel;
            for (int i = 0; i < distance; i++) 
            {
                int x = 0; x++;
                if (x == 5) 
                {
                    if (EngineType == "efficient")
                    {
                        fuelNeeded = fuelNeeded / 2;
                        fakeFuel -= fuelNeeded;
                    }
                    else 
                    {
                        fakeFuel -= fuelNeeded;
                    }
                    x = 0;
                }
            }
            if (fakeFuel >= 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
            */
        }





    }
}

    
