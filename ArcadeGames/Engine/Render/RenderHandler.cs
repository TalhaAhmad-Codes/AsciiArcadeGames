using ArcadeGames.Core.Interfaces;
using ArcadeGames.Engine.Utils;

namespace ArcadeGames.Engine.Render
{
    public sealed class RenderHandler : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Draw(Position position, Symbol symbol)
        {
            Console.SetCursorPosition(position.Row, position.Column);
            symbol.Display();
        }

        public void Draw(Position position, Text text)
        {
            Console.SetCursorPosition(position.Row, position.Column);
            text.Display();
        }
    }
}
