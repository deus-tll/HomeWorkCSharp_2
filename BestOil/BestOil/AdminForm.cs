using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BestOil
{
	public partial class AdminForm : Form
	{
		private BindingList<Goods> _fuels;
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
				_fileIOService.LoadData(ref _fuels, ref _products);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}

			GridFuel.DataSource = _fuels;
			GridProduct.DataSource = _products;

			_fuels.ListChanged += _fuel_ListChanged;
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


		private void btn_AddGoods_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			AddingGoodsForm addingGoodsForm = new AddingGoodsForm();
			addingGoodsForm.ShowDialog();

			if (addingGoodsForm.DialogResult == DialogResult.OK)
			{
				Goods goods = new Goods
				{
					ProductName = addingGoodsForm.GoodsName,
					Price = addingGoodsForm.GoodsPrice
				};

				if (button.Name == btn_AddFuel.Name)
					_fuels.Add(goods);
				else if (button.Name == btn_AddProduct.Name)
					_products.Add(goods);
			}
		}

		private void btn_DelGoods_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			DeleteGoodsForm deleteGoodsForm = new DeleteGoodsForm();
			BindingList <Goods> goods = null;

			if (button.Name == btn_DelFuel.Name)
				goods = _fuels;
			else if (button.Name == btn_DelProduct.Name)
				goods = _products;

			deleteGoodsForm.ShowDialog(goods);

			if (deleteGoodsForm.DialogResult == DialogResult.OK)
				goods.RemoveAt(deleteGoodsForm.Index);

			if (button.Name == btn_DelFuel.Name)
				_fuels = goods;
			else if (button.Name == btn_DelProduct.Name)
				_products = goods;
		}

		private void btn_EditGoods_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			EditingGoodsForm editingGoodsForm = new EditingGoodsForm();

			BindingList<Goods> goods = null;

			if (button.Name == btn_EditFuel.Name)
				goods = _fuels;
			else if (button.Name == btn_EditProduct.Name)
				goods = _products;

			editingGoodsForm.ShowDialog(goods);

			if (editingGoodsForm.DialogResult == DialogResult.OK)
			{
				if (button.Name == btn_EditFuel.Name)
				{
					_fuels[editingGoodsForm.Index].ProductName = editingGoodsForm.GoodsName;
					_fuels[editingGoodsForm.Index].Price = editingGoodsForm.GoodsPrice;
				}
				else if (button.Name == btn_EditProduct.Name)
				{
					_products[editingGoodsForm.Index].ProductName = editingGoodsForm.GoodsName;
					_products[editingGoodsForm.Index].Price = editingGoodsForm.GoodsPrice;
				}
			}
		}

		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Program.Language != "en")
			{
				var changeLanguage = new ChangeLanguage();
				changeLanguage.UpdateConfig("language", "en");
				Application.Restart();
			}
		}

		private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Program.Language != "")
			{
				var changeLanguage = new ChangeLanguage();
				changeLanguage.UpdateConfig("language", "");
				Application.Restart();
			}
		}
	}
}
