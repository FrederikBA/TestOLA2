namespace Core.Bowling
{
    public class Roll
    {
        public int Pins1 { get; set; }
        public int Pins2 { get; set; }
        public int Pins3 { get; set; } // For the third roll in the final frame

        public int Score => Pins1 + Pins2 + Pins3;
    }
    
    // ... rest of the class remains the same
}