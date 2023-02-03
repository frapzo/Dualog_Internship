namespace VesselsNS
{
    // Speed class that stores speed and can return in knots or meters per second
    public class Speed : IFormattable{
        private double value;
        private const double knots_factor = 0.514444;

        // constructor
        public Speed(double Speed, string Format){
            // check if speed is valid
            if (Speed < 0){
                throw new Exception("Max Speed of a vessel cannot be negative.");
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
}