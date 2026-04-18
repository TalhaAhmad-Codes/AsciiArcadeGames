using ArcadeGames.Engine.Utils;

namespace ArcadeGames.Core.Interfaces
{
    public interface IRenderer
    {
        void Clear();
        void Draw(Position position, Symbol symbol);
        void Draw(Position position, Text text);
    }
}
