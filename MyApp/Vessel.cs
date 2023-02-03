namespace VesselsNS
{
    // base class for all vessels
    public class Vessel {
        private string name;
        private int yearBuilt;
        private Speed maxSpeed;

        public Vessel(string Name, int Year, double MaxSpeed, string Format = "KN"){
            // Check if name is valid
            if (string.IsNullOrEmpty(Name) || Name == "NULL") {
                throw new NameException();
            }
            else{
                name = Name;
            }

            // Check if year is valid
            if (Year < 2003 || Year > 2023) {
                throw new OldShipException();
            }
            else{
                yearBuilt = Year;
            }

            maxSpeed = new Speed(MaxSpeed, Format);
        }

        // public method to access name
        public string GetName(){
            return name;
        }

        // public method to access yearBuilt
        public int GetYearBuilt(){
            return yearBuilt;
        }

        public double GetMaxSpeed(string format = "KN"){
            return maxSpeed.ConvertUnit(format);
        }

        // returns Vessel info
        public override string ToString() {
            return $"Vessel: {name}, Year: {yearBuilt}, Max Speed: {GetMaxSpeed("KN")}KN";
        }
    }
}