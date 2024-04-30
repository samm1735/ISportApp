using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.Converters
{
    public class PlayerImagesAvailableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Models.Player player)
            {
                return !string.IsNullOrEmpty((string?)player.strFanart1)
                    || !string.IsNullOrEmpty((string?)player.strFanart2)
                    || !string.IsNullOrEmpty((string?)player.strFanart3)
                    || !string.IsNullOrEmpty((string?)player.strFanart4);
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
