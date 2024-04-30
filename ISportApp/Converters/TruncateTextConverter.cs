using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.Converters
{
    internal class TruncateTextConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;
            if (text == null)
                return "";
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length <= 500)
                return text;
            return string.Join(" ", words.Take(500)) + "...";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo
        culture)
        {
            throw new NotImplementedException();
        }


    }
}
