using ArcadeGames.Core.Interfaces;

namespace ArcadeGames.Engine.Core
{
    public sealed class Scene
    {
        // Attributes
        private readonly IRenderer _renderer;
        private readonly IInputHandler _input;

        // Constructor
        public Scene(IRenderer renderer, IInputHandler input)
        {
            _renderer = renderer;
            _input = input;
        }

        // Method - Start the game
        public void Run(IGame game)
        {
            Console.CursorVisible = false;  // Hide the cursor
            game.Initialize();

            while (game.IsRunning)
            {
                // Get the input from user
                var key = _input.GetInput();

                // Update the game state
                game.Update(key);

                // Render on screen
                _renderer.Clear();
                game.Render();

                // FPS
                Thread.Sleep(100);
            }

            Console.CursorVisible = true;   // Show the cursor again
        }
    }
}
