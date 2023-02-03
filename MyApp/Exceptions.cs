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

    [Serializable]
    public class NameException : Exception {
        public override string Message {
            get {
                return "All Vessels must have a non-empty name, and it cannot be NULL";
            }
        }
    }
}