using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace UWAppUsingConverterHandsOn
{
    public class MyBooleanToColorChanger : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value ? Colors.Green : Colors.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return new NotImplementedException();

            //if (String.Equals(value, "Green"))
            //{
            //    return true;
            //}
            //else if(String.Equals(value, "Red"))
            //{
            //    return false;
            //}
            //else
            //{
            //    return new InvalidCastException("Only Green and Red are converted to boolan types in this function");
            //}

        }
    }
}
