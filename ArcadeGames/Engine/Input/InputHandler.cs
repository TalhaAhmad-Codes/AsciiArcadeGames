using ArcadeGames.Core.Interfaces;

namespace ArcadeGames.Engine.Input
{
    public class InputHandler : IInputHandler
    {
        public ConsoleKey? GetInput()
        {
            if (Console.KeyAvailable)
            {
                return Console.ReadKey(true).Key;
            }

            return null;
        }
    }
}
