using System;
using System.Globalization;
using System.Windows.Controls;

namespace IntToDateTime
{
	public class YearRules : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			int year;
			if (!int.TryParse(value.ToString(), out year))
			{
				return new ValidationResult(false, "Cannot parse value!");
			}

			if (year > 9999 || year < 1)
			{
				return new ValidationResult(false, "Year is incorrect!");
			}

			return new ValidationResult(true, null);
		}
	}

	public class MonthRules : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			int month;
			if (!int.TryParse(value.ToString(), out month))
			{
				return new ValidationResult(false, "Cannot parse value!");
			}

			if (month > 12 || month < 1)
			{
				return new ValidationResult(false, "Month is incorrect!");
			}

			return new ValidationResult(true, null);
		}
	}

	public class DayRules : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			int day;
			if (!int.TryParse(value.ToString(), out day))
			{
				return new ValidationResult(false, "Cannot parse value!");
			}

			try
			{
				DateTime dateTime = new DateTime(Dummy.Year, Dummy.Month, day);
			}
			catch (Exception ex)
			{
				return new ValidationResult(false, ex.Message);
			}

			return new ValidationResult(true, null);
		}
	}
}
