using System;

namespace VideoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem= new AudioSystem();

            RenderingEngine renderingEngine= new RenderingEngine();

            Player player1 = new Player("tBagYoMama");
            Player player2 = new Player("HitlerFan88");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running... Press any key to end the game.");
            Console.Read();

            GameEventManager.TriggerGameOver();


            
        }
    }
}
