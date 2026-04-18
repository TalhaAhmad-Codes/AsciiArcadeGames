namespace ArcadeGames.Engine.Utils
{
    public sealed class Color
    {
        // Attributes
        public ConsoleColor Foreground { get; }
        public ConsoleColor? Background { get; }

        // Constructor
        public Color(ConsoleColor? foreground = null, ConsoleColor? background = null)
        {
            Foreground = foreground ?? ConsoleColor.White;
            Background = background;
        }

        // Methods - Color Config
        public void Set()
        {
            Console.ForegroundColor = Foreground;
            Console.BackgroundColor = Background!.Value;
        }

        public void Reset()
        {
            Console.ResetColor();
        }
    }
}
