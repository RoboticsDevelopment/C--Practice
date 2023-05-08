using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Radio : ElectricalDevice
    {


        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            IsOn = isOn;
            Brand = brand;
        }



        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}

