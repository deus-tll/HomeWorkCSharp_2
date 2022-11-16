using System.ComponentModel;

namespace BestOil
{
	public class Goods : INotifyPropertyChanged
	{
		protected string _product;
		protected string _price;

		public string ProductName
		{
			get { return _price; }
			set
			{
				if (_price == value) return;

				_price = value;
				OnPropertyChanged(nameof(Price));
			}
		}

		public string Price
		{
			get { return _price; }
			set
			{
				if (_price == value) return;

				_price = value;
				OnPropertyChanged(nameof(Price));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
