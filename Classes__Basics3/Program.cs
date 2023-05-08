using System;

namespace Classes__Basics3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create instance of human object of my Human Class.
            Human patrick = new Human("Patrick", "Burny", "Brown", 35);

            patrick.IntroduceMyself();

            Human Nikola = new Human("Nikola", "Tesla", 12);

            Nikola.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human It = new Human("It", "Jr", "Green");
            It.IntroduceMyself();

            Human Troll = new Human("Troll", "Johnson");
            Troll.IntroduceMyself();
    
        }
    }
}
