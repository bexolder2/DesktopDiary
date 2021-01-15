using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace DesctopDiary.View
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(parameter.ToString() == "Date")
            {
                if (value != null)
                {
                    DateTime date = (DateTime)value;
                    string buffer = $"{date.Day}.{date.Month}.{date.Year}";
                    return buffer;
                }
                else
                {
                    return "";
                }
            }
            else if(parameter.ToString() == "Color")
            {
                if (value != null)
                {
                    switch (value)
                    {
                        case ViewModel.StatusColor.Blue:
                            return Brushes.Blue;
                        case ViewModel.StatusColor.Green:
                            return Brushes.Green;
                        case ViewModel.StatusColor.Orange:
                            return Brushes.Orange;
                        default:
                            return Brushes.White;
                    }
                }
                else
                {
                    return Brushes.White;
                }
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
