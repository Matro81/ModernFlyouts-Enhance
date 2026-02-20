using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ModernFlyouts.Converters
{
    public class DoubleToObjectConverter : IValueConverter
    {
        public double GreaterThan { get; set; } = double.NaN;
        public double LessThan { get; set; } = double.NaN;

        public object TrueValue { get; set; }
        public object FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d)
            {
                bool result = false;

                if (!double.IsNaN(GreaterThan))
                {
                    result = d > GreaterThan;
                }
                else if (!double.IsNaN(LessThan))
                {
                    result = d < LessThan;
                }
                
                return result ? TrueValue : FalseValue;
            }
            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
