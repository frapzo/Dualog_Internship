namespace VesselsNS
{
    // Vessel type Tugboat
    public class Tugboat : Vessel {
        private int max_force;

        public Tugboat(string Name, int Year, double MaxSpeed, int Max_force, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            max_force = Max_force;
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Tugboat, Name: {GetName()}, Year: {GetYearBuilt()}, Max Force: {max_force}";
        }
    }
}