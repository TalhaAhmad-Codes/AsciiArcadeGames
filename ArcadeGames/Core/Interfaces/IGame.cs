namespace ArcadeGames.Core.Interfaces
{
    public interface IGame
    {
        // Attributes
        bool IsRunning { get; }

        // Methods
        void Initialize();
        void Update(ConsoleKey? input);
        void Render();
    }
}
