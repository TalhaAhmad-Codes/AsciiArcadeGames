using ArcadeGames.Core.Interfaces;
using ArcadeGames.Engine.Core;
using ArcadeGames.Engine.Input;
using ArcadeGames.Engine.Render;
using ArcadeGames.Games.SampleGame;

namespace ArcadeGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new RenderHandler();
            IInputHandler input = new InputHandler();

            var scene = new Scene(renderer, input);

            IGame game = new SampleGame();
            scene.Run(game);
        }
    }
}
