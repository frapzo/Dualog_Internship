namespace VesselsNS
{
    // Vessel type Tugboat
    public class Tugboat : Vessel {
        private int maxForce;

        public Tugboat(string Name, int Year, double MaxSpeed, int MaxForce, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            maxForce = MaxForce;

            // Check that maxForce is not negative
            if (maxForce < 0) throw new Exception("Max force cannot be negative");
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Tugboat, Name: {GetName()}, Year: {GetYearBuilt()}, Max Force: {maxForce}";
        }
    }
}