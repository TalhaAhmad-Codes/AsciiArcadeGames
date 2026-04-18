using ArcadeGames.Core.Interfaces;
using ArcadeGames.Engine.Utils;

namespace ArcadeGames.Games.SampleGame
{
    public sealed class SampleGame : IGame
    {
        // Attributes
        public bool IsRunning { get; private set; } = true;
        private Position _position = new(10, 5);

        public void Initialize()
        {
            
        }

        public void Update(ConsoleKey? input)
        {
            if (input == ConsoleKey.Escape)
                IsRunning = false;

            if (input == ConsoleKey.UpArrow) _position.Column--;
            if (input == ConsoleKey.DownArrow) _position.Column++;
            if (input == ConsoleKey.LeftArrow) _position.Row--;
            if (input == ConsoleKey.RightArrow) _position.Row++;
        }

        public void Render()
        {
            // For testing
            Console.SetCursorPosition(_position.Row, _position.Column);
            Console.Write('@');
        }
    }
}
