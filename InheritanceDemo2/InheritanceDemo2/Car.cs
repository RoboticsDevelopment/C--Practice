using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Car : Vehicle, IDestroyable
    {
        //implementation the interface's property
        public string DestructionSound { get; set; }

         public List<IDestroyable> DestroyablesNearby { get; set; }

        public Car(string color, float speed) : base()
        {
            Color= color;
            Speed= speed;
            // Initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        //public string DestructionSound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Creates Fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
