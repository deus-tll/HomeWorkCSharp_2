using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ContactList
{
	public class Contact : INotifyPropertyChanged
	{
		private string _name;
		private string _number;
		private string _telegramNick;
		public DateTime DateOfAdding { get; set; } = DateTime.Now;


		public string Name
		{
			get { return _name; }
			set
			{
				SetProperty(ref _name, value, nameof(Name));
			}
		}

		public string Number
		{
			get { return _number; }
			set
			{
				SetProperty(ref _number, value, nameof(Number));
			}
		}

		public string TelegramNick
		{
			get { return _telegramNick; }
			set
			{
				SetProperty(ref _telegramNick, value, nameof(TelegramNick));
			}
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
}