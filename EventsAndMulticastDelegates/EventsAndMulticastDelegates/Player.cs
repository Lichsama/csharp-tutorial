using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class Player
    {
        

        public string PlayerName { get; set; }
        public Player(string name)
        {
            PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        public void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID :  {PlayerName}");
        }

        public void GameOver()
        {
            Console.WriteLine($"Removing Player with ID :  {PlayerName}");
        }

    }
}
