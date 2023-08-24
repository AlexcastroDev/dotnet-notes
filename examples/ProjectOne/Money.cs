using System.Globalization;

namespace Money {
    public class Monetize {
        decimal Amount = 0;

        public Monetize(decimal amount) {
            Amount = amount;
        }
        
        public override string ToString() {
            return Amount.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")
            );
        }
    }
}