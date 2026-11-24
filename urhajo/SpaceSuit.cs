using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo67
{
    internal class SpaceSuit
    {
        public string Model;
        public int OxygenLevel;
        public int Integrity;


        public SpaceSuit(string model, int oxygenlevel, int integrity)
        {
            Model = model;
            OxygenLevel = oxygenlevel;
            Integrity = integrity;
        }
        public void Showstatus()
        {
            Console.WriteLine($"{Model}");
            Console.WriteLine($"OxygenLevel: {OxygenLevel}");
            Console.WriteLine($"Integrity: {Integrity} \n");

        }
    }
}
