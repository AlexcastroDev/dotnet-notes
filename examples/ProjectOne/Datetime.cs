
using System.Globalization;

namespace DatetimeTest {
    public class DatetimeBolado {
        public static string UTC() {
            return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public static string GetDate() {
            CultureInfo pt = new("pt-BR");
            return DateTime.Now.ToString("D", pt);
        }
        public static string FormatDate(DateTime datetime) {
            // The string "D" is a standard date and time format string that represents a long date with a long time.
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings#DFormatString
            return String.Format("{0:D}", datetime);
            // return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}