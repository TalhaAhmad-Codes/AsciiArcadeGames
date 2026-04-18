namespace ArcadeGames.Engine.Utils
{
    public sealed class Position
    {
        // Attributes
        public int Row { get; set; }
        public int Column { get; set; }

        // Constructor
        public Position(int row = 0, int column = 0)
        {
            Column = column;
            Row = row;
        }

        // Methods - Operator Overloading
        public static Position operator +(Position left, Position right)
            => new(left.Row + right.Row, left.Column + right.Column);

        public static Position operator -(Position left, Position right)
            => new(left.Row - right.Row, left.Column - right.Column);

        public static bool operator ==(Position left, Position right)
            => left.Row == right.Row && left.Column == right.Column;

        public static bool operator !=(Position left, Position right)
            => left.Row != right.Row || left.Column != right.Column;

        // Method - String representation
        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}
