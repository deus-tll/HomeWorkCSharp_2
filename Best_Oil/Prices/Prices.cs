using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prices
{
	public class Goods : INotifyPropertyChanged
	{
		protected string _goods;
		protected string _price;

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

	public class Fuel : Goods, INotifyPropertyChanged
	{
		public string FuelName
		{
			get { return _goods; }
			set
			{
				if (_goods == value) return;

				_goods = value;
				OnPropertyChanged(nameof(FuelName));
			}
		}
	}


	public class Product : Goods, INotifyPropertyChanged
	{
		public string ProductName
		{
			get { return _goods; }
			set
			{
				if (_goods == value) return;

				_goods = value;
				OnPropertyChanged(nameof(ProductName));
			}
		}
	}
}
