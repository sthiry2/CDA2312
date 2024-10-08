using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfAppControleDeSaisieSurface.MyConverters
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(string))
            {
                DateTime result = (DateTime)value;
                return result.ToString("dd/MM/yyyy");
            }
            return null!;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime result;
            if (targetType == typeof(DateTime))
            {
                DateTime.TryParseExact((string)value, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out result);
                return result;
            }
            return null!;
        }
    }
}
