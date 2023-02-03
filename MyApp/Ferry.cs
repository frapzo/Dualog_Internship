namespace VesselsNS
{
    // Vessel type Ferry
    public class Ferry : Vessel {
        public int passengers;

        public Ferry(string Name, int Year, double MaxSpeed, int Passengers = 0, string Format = "KN") 
        : base(Name, Year, MaxSpeed, Format = "KN") {
            passengers = Passengers;

            // passengers cannot be negative number
            if (passengers < 0) throw new Exception("Passenger number cannot be negative");
        }

        // return string decribing the vessel
        public string GetVesselInfo() {
            return $"Type: Ferry, Name: {GetName()}, Year: {GetYearBuilt()}, Passengers: {passengers}";
        }

    }
}