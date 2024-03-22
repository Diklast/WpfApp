using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfAppppp 
{
    public class BoolToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Проверяем, является ли value булевым значением и не равен ли parameter null
            if (value is bool boolValue && parameter != null)
            {
                // Возвращаем строку с да/нет в зависимости от значения boolValue
                return boolValue ? $"{parameter}: Yes" : $"{parameter}: No";
            }

            return "N/A"; // В случае несоответствия типов возвращаем "N/A"
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Обратное преобразование не поддерживается");
        }
    }
}
