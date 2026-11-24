using System.Diagnostics.Metrics;

namespace apollo67
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Astronaut> astronauts = new List<Astronaut>
{
    new Captain("Pirx", 95, 88, 92),
    new Captain("Ijon Tichy", 90, 95, 85),
    new Captain("Horpach", 88, 75, 90),
    new Captain("Rohan", 94, 82, 96),
    new Captain("Bregg", 96, 88, 95),
    new Captain("Tempe", 89, 84, 90),
    new Captain("Kelvin", 82, 78, 85),
    new Captain("Gibarian", 70, 65, 80),
    new Captain("Snaut", 78, 72, 85),

    new Captain("Hari Seldon", 92, 86, 94),
    new Captain("Salvor Hardin", 87, 90, 88),
    new Captain("Hober Mallow", 90, 85, 92),
    new Captain("Bel Riose", 85, 80, 89),
    new Captain("Golan Trevize", 91, 92, 87),
    new Captain("Elijah Baley", 88, 78, 90),
    new Captain("Gladia Delmarre", 93, 85, 95),
    new Captain("Biron Farrill", 79, 88, 82),

    new Engineer("Trurl", 92, 90, 85),
    new Engineer("Klapaucius", 88, 95, 90),
    new Engineer("Elektrybałt", 100, 100, 100),
    new Engineer("Corcoran", 90, 85, 88),
    new Engineer("Dobb", 75, 70, 80),
    new Engineer("Tarantoga", 95, 85, 90),
    new Engineer("Murdas", 86, 75, 90),
    new Engineer("Hylas", 83, 88, 85),

    new Engineer("R. Daneel Olivaw", 100, 95, 100),
    new Engineer("R. Giskard Reventlov", 100, 90, 100),
    new Engineer("Andrew Martin", 95, 88, 100),
    new Engineer("Herbie", 90, 85, 95),
    new Engineer("QT-1 Cutie", 100, 100, 100),
    new Engineer("R. Sammy", 85, 75, 90),
    new Engineer("R. Jander Panell", 92, 88, 100),
    new Engineer("R. Amadiro", 80, 85, 90),
    new Engineer("R. Fastolfe", 88, 92, 95),

    new Scientist("Sartorius", 82, 80, 88),
    new Scientist("Golem XIV", 100, 100, 100),
    new Scientist("Decantor", 88, 90, 92),
    new Scientist("Azzie", 78, 85, 88),
    new Scientist("Mimow", 86, 90, 80),
    new Scientist("Panta", 78, 92, 82),
    new Scientist("Professor Corcoran", 90, 85, 88),
    new Scientist("The Constructor", 87, 95, 89),

    new Scientist("Susan Calvin", 90, 80, 95),
    new Scientist("Peter G. Vassilyev", 85, 75, 90),
    new Scientist("Arkady Darell", 88, 92, 85),
    new Scientist("Bayta Darell", 94, 88, 92),
    new Scientist("Ebling Mis", 75, 65, 80),
    new Scientist("Janov Pelorat", 82, 70, 88),
    new Scientist("Dors Venabili", 98, 95, 100),
    new Scientist("Yugo Amaryl", 87, 90, 85)
};

            
            foreach (Astronaut astronaut in astronauts)
            {
                Console.WriteLine(astronaut.Name);
            }

            Console.WriteLine("\n");

            int counter = astronauts.Count;

            Console.WriteLine(counter);
            Console.WriteLine("\n");

            foreach (Astronaut astronaut in astronauts)

            {
                if (astronaut.Name == "Pirx")
                {
                    Console.WriteLine($"{astronaut.Name}, {astronaut.Health}, {astronaut.Oxygen}, {astronaut.Energy}");
                }
            }

            Console.WriteLine("\n");

            foreach(Astronaut astronaut in astronauts)
            {
                if (astronaut.Health == 100)
                {
                    Console.WriteLine($"{astronaut.Name}");
                }
            }

            Console.WriteLine("\n");

            int count = 0;

            foreach (Astronaut astronaut in astronauts)
            {
                if (astronaut.Health > 85)
                {
                    count ++;
                    
                }
            }

            Console.WriteLine(count);

            Console.WriteLine("\n");


            foreach (Astronaut astronaut in astronauts)
            {
                if (astronaut.Oxygen < 42)
                {
                    Console.WriteLine($"{astronaut.Name}, {astronaut.Oxygen}, {astronaut.Energy}, {astronaut.Health}");
                }
            }

            Console.WriteLine("\n");

            foreach (Astronaut astronaut in astronauts)
            {
                if (astronaut is Captain)
                {
                    Console.WriteLine($"{astronaut.Name}, {astronaut.Oxygen}, {astronaut.Energy}, {astronaut.Health}");
                }
            }

            Console.WriteLine("\n");

         Scientist borat = new Scientist("borat", 82, 70, 88);


            foreach (Astronaut astronaut in astronauts)

            {
                if (astronaut.Name == "borat")
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false); 
                }
            }

            bool containsBorat = astronauts.Contains(borat);
            Console.WriteLine(containsBorat);




        }  
    }
}
