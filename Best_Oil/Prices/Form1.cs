using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prices
{
	public partial class Form1 : Form
	{
		private BindingList<Fuel> _fuel;
		private BindingList<Product> _products;
		private readonly string PATH_TO_FUEL;
		private readonly string PATH_TO_PRODUCTS;
		private FileIOService _fileIOService;
		public Form1()
		{
			InitializeComponent();

			var dir = Environment.CurrentDirectory;
			for (int i = 0; i < 3; ++i)
				dir = Path.GetDirectoryName(dir);

			dir += $"\\BestOil\\bin\\Debug\\";

			PATH_TO_FUEL = $"{dir}FuelPrice.Json";
			PATH_TO_PRODUCTS = $"{dir}ProductsPrice.Json";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_fileIOService = new FileIOService(PATH_TO_FUEL, PATH_TO_PRODUCTS);

			try
			{
				_fileIOService.LoadData(ref _fuel, ref _products);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}

			GridFuel.DataSource = _fuel;
			GridProduct.DataSource = _products;

			_fuel.ListChanged += _fuel_ListChanged;
			_products.ListChanged += _products_ListChanged;
		}

		private void _products_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
			{
				try
				{
					_fileIOService.SaveData(sender, PATH_TO_PRODUCTS);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Close();
				}
			}
		}

		private void _fuel_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
			{
				try
				{
					_fileIOService.SaveData(sender, PATH_TO_FUEL);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Close();
				}
			}
		}
	}
}
