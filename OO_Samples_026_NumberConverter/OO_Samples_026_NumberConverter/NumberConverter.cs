
namespace NumberConverter {
    /// <summary>
    /// Zur Verfügung gestellt von Peter Gisler, GIBZ
    /// </summary>
    public class NumberConverter {

        StringConverter _stringConverter;

        public NumberConverter() {
            _stringConverter = new StringConverter();
        }

        public int RoundUp(float value) {
            // TODO: Implement rounding...
            // You must not use other methods to implement this method.
            double roundedValue = (double)Math.Ceiling(value);
            return (int)roundedValue;
        }

        public int RoundDown(float value) {
            // TODO: Implement rounding...
            // You must not use other methods to implement this method.
            double roundedValue = (double)Math.Floor(value);
            return (int)roundedValue;
        }


        public int RoundToPowerOfTen(float value, int precisionExponent = 1) {
            // TODO: Implement rounding...
            // Math.Round() may be used here
            double roundedValue = (double)Math.Round(value, precisionExponent);
            return (int)roundedValue;
        }

        public int RoundToPowerOfTen(string numericString, int precisionExponent = 1) {
            // TODO: Implement rounding...
            // Have a look at the StringConverter utility in this project!
            StringConverter s = new StringConverter();
            double value = (double)s.ConvertToInt(numericString);
            double roundedValue = (double)Math.Round(value, precisionExponent);
            return (int)roundedValue;
        }

    }
}
