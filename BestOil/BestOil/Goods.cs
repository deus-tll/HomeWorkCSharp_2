using System.ComponentModel;

namespace BestOil
{
	public class Goods : INotifyPropertyChanged
	{
		protected string _product;
		protected string _price;

		public string ProductName
		{
			get { return _product; }
			set
			{
				if (_product == value) return;

				_product = value;
				OnPropertyChanged(nameof(ProductName));
			}
		}

		public string Price
		{
			get { return _price; }
			set
			{
				if (_price == value) return;

				_price = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			
		}
	}
}
