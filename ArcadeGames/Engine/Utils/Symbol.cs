namespace ArcadeGames.Engine.Utils
{
    public sealed class Symbol
    {
        // Attributes
        public Color Color { get; }
        public char Character { get; }

        // Constructor
        public Symbol(char character, Color color)
        {
            Character = character;
            Color = color;
        }

        // Method - Display the symbol
        public void Display()
        {
            Color.Set();                // Set console's color for the symbol
            Console.Write(Character);   // Prints the symbol
            Color.Reset();              // Set the console's color to default
        }
    }
}
