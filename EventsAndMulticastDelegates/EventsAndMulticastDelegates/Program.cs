﻿namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Runnig.... Press any key to end the game.");
            Console.Read();
            GameEventManager.TriggerGameOver();

            
        }
    }
}