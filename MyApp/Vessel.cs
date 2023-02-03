namespace VesselsNS
{
    // custom exception to signal that a vessel is too old
    [Serializable]
    public class OldShipException : Exception {
        public override string Message {
            get {
                return "Invalid build year of Vessel was given. Valid years are from 2003 to 2023.";
            }
        }
    }

    // custom exception to signal that unit is wrong
    [Serializable]
    public class FormatException : Exception {
        public override string Message {
            get {
                return "The speed unit/format specified is Invalid, Please choose KN or MS";
            }
        }
    }

    // Speed class that stores speed and can return in knots or meters per second
    public class Speed : IFormattable{
        private double value;
        private const double knots_factor = 0.514444;

        // constructor
        public Speed(double Speed, string Format){
            // check if speed is valid
            if (Speed < 0){
                throw new Exception("Speed cannot be negative");
            }

            // Check if unit is valid and convert as appropriate
            if (Format == "KN" || string.IsNullOrEmpty(Format)){
                value = Speed / knots_factor;
            }
            else if (Format == "MS"){
                value = Speed;
            }
            else{
                throw new Exception("Invalid format");
            }
        }
        public double to_knots(){
            return value * knots_factor;
        }

        public double to_ms(){
            return value;
        }

        public override string ToString(){
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public string ToString(string? Format){
            return value.ToString(Format);
        }

        public string ToString(string? Format, IFormatProvider? provider){
            return value.ToString(Format, provider);
        } 

        public double ConvertUnit(string Format = "KN"){
            switch(Format)
            {
                case "MS":
                    return value;
                case "KN":
                    return to_knots();
                default:
                    throw new FormatException();
            }
        }

    }

    // base class for all vessels
    public class Vessel {
        private string name;
        private int yearBuilt;
        private Speed maxSpeed;

        public Vessel(string Name, int Year, double MaxSpeed, string Format = "KN"){
            // Check if name is valid
            if (string.IsNullOrEmpty(Name) || Name == "NULL") {
                throw new Exception("Name cannot be empty or null or NULL");
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