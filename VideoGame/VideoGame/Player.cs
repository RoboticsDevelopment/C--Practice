using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawing Player with ID : {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PlayerName}");
        }
    }
}
