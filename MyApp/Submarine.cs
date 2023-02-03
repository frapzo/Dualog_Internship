namespace VesselsNS
{
    // Vessel type Submarine
    public class Submarine : Vessel {
        private int maxDepth;

        public Submarine(string Name, int Year, double MaxSpeed, int MaxDepth, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            maxDepth = MaxDepth;

            // Check that maxDepth is not negative
            if (maxDepth < 0) throw new Exception("Max depth cannot be negative");
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Submarine, Name: {GetName()}, Year: {GetYearBuilt()}, Max Depth: {maxDepth}";
        }
    }
}