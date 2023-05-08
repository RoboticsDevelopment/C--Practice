using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void ListenElectricalDevice()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the ElectricalDevice!");
            }
            else
            {
                Console.WriteLine("ElectricalDevice is switched off, switch it on first");
            }
        }


    }
}

