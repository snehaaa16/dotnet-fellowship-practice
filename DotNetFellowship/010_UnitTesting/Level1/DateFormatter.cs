using System;
using System.Globalization;
namespace _010_UnitTesting;
public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
        {
            return parsedDate.ToString("dd-MM-yyyy");
        }
        throw new FormatException("Invalid date format");
    }
}
