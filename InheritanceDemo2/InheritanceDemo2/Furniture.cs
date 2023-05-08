using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Furniture
    {
        public string Material { get; set; }
        public string Color { get; set; }


        public Furniture()
        {
            Material = "Wood";
            Color = "White";
        }

        public Furniture(string material, string color)
        {
            Material = material;
            Color = color;
        }
    }

}
