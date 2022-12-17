using System.Collections.Generic;
using System.ComponentModel;

namespace IntToDateTime
{
	public class Date : INotifyPropertyChanged
	{
		private int _year;
		private int _month;
		private int _day;

		public int Year 
		{ 
			get { return _year; }
			set { SetProperty(ref _year, value, nameof(Year)); } 
		}
		public int Month 
		{
			get { return _month; }
			set { SetProperty(ref _month, value, nameof(Month)); }
		}
		public int Day 
		{
			get { return _day; }
			set { SetProperty(ref _day, value, nameof(Day)); }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void SetProperty<T>(ref T field, T value, string name)
		{
			if (!EqualityComparer<T>.Default.Equals(field, value))
			{
				field = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
			}
		}
	}


	public static class Dummy
	{
		public static int Year { get; set; }
		public static int Month { get; set; }
	}
}
