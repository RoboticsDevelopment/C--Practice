using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Chair : Furniture, IDestroyable
    {

        public string DestructionSound { get; set; }

        //Simple Constructor
        public Chair( string material, string color)
        {
            Material= material;
            Color= color;
            DestructionSound = "ChairDestructionSound.mp3";
            
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }


    }
}
