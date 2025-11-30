using System.Globalization;

namespace Common.Library.MAUI.Converters;

public class InvertedBoolConverter: IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool b)
        {
            var v = !b;
            Console.WriteLine(v);
            return !b;
        }

        return value;
    }

    public object? ConvertBack(object? value, Type targetType, 
        object? parameter, CultureInfo culture)
    {
        return null;
       // return value is bool && !(bool)value;
    }
}
