using System;
using System.Globalization;
using System.Windows.Data;

namespace IntToDateTime
{
	[ValueConversion(typeof(int[]), typeof(DateTime))]
	public class IntToDateTimeConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			DateTime date;

			try
			{
				date = new DateTime(System.Convert.ToInt32((values[0].ToString())), System.Convert.ToInt32((values[1].ToString())), System.Convert.ToInt32((values[2].ToString())));
			}
			catch (Exception)
			{
				return DateTime.MinValue;
			}

			return date;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			var date = (DateTime)value;
			object[] ints = new object[3];

			ints[0] = date.Year;
			ints[1] = date.Month;
			ints[2] = date.Day;

			return ints;
		}
	}
}
