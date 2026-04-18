namespace ArcadeGames.Engine.Utils
{
    public sealed class Text
    {
        // Attributes
        public Color Color { get; }
        public string Statement { get; }

        // Constructor
        public Text(string text, Color color)
        {
            Statement = text;
            Color = color;
        }

        // Method - Display the symbol
        public void Display()
        {
            Color.Set();                // Set console's color for the symbol
            Console.Write(Statement);   // Prints the text (statement)
            Color.Reset();              // Set the console's color to default
        }
    }
}
