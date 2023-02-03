namespace VesselsNS
{
    // Vessel type Submarine
    public class Submarine : Vessel {
        private string max_depth;

        public Submarine(string Name, string Year, double MaxSpeed, string Max_depth, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            max_depth = Max_depth;
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Submarine, Name: {GetName()}, Year: {GetYearBuilt()}, Max Depth: {max_depth}";
        }
    }
}