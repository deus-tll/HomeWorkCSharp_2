using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BestOil
{
	public partial class AdminForm : Form
	{
		private BindingList<Goods> _fuel;
		private BindingList<Goods> _products;
		private readonly string PATH_TO_FUEL = $"{Environment.CurrentDirectory}\\FuelPrice.Json";
		private readonly string PATH_TO_PRODUCTS = $"{Environment.CurrentDirectory}\\ProductsPrice.Json";
		private FileIOService _fileIOService;

		public AdminForm()
		{
			InitializeComponent();
		}

		private void AdminForm_Load(object sender, EventArgs e)
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
