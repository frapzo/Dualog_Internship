namespace VesselsNS
{
    // Vessel type Ferry
    public class Ferry : Vessel {
        public string passengers;

        public Ferry(string Name, string Year, double MaxSpeed, string Passengers, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            passengers = Passengers;
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Ferry, Name: {GetName()}, Year: {GetYearBuilt()}, Passengers: {passengers}";
        }

    }
}