namespace VesselsNS
{
    // Vessel type Submarine
    public class Submarine : Vessel {
        private int max_depth;

        public Submarine(string Name, int Year, double MaxSpeed, int Max_depth, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            max_depth = Max_depth;
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Submarine, Name: {GetName()}, Year: {GetYearBuilt()}, Max Depth: {max_depth}";
        }
    }
}