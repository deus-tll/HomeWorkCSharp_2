using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace BestOil
{
	public partial class CashierForm : Form
	{
		private int _totalIncome;
		private BindingList<Goods> _fuels;
		private BindingList<Goods> _products;
		private BindingList<string> _fuelNames = new BindingList<string>();
		private readonly string PATH_TO_FUEL = $"{Environment.CurrentDirectory}\\FuelPrice.Json";
		private readonly string PATH_TO_PRODUCTS = $"{Environment.CurrentDirectory}\\ProductsPrice.Json";

		public CashierForm()
		{
			InitializeComponent();

			FileIOService _fileIOService = new FileIOService(PATH_TO_FUEL, PATH_TO_PRODUCTS);
			_fileIOService.LoadData(ref _fuels, ref _products);

			for (int i = 0; i < _fuels.Count; i++)
				_fuelNames.Add(_fuels[i].ProductName);

			comBx_ListOfGasolineTypes.DataSource = _fuelNames;
		}

		private void comBx_ListOfGasolineTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			tb_PriceForFuel.Text = _fuels[comboBox.SelectedIndex].Price;

			if (rb_Quantity.Checked)
			{
				tb_Quantity.Enabled = true;
				tb_Sum.Enabled = false;

				if (tb_Quantity.Text != "")
					lbl_GasStationAmount.Text = String.Format("{0:0.00}", Convert.ToDouble(tb_PriceForFuel.Text) * Convert.ToDouble(tb_Quantity.Text));

				gb_GasStationPay.Text = "До оплати";
				lbl3_grn.Text = "грн.";
			}
			else if (rb_Sum.Checked)
			{
				tb_Quantity.Enabled = false;
				tb_Sum.Enabled = true;

				if (tb_Sum.Text != "")
				{
					tb_Quantity.Text = String.Format("{0:0.00}", (Convert.ToDouble(tb_Sum.Text) / Convert.ToDouble(tb_PriceForFuel.Text)));
					lbl_GasStationAmount.Text = tb_Quantity.Text;
				}

				gb_GasStationPay.Text = "До видачі";
				lbl3_grn.Text = "л.";
			}
		}

		private void rb_Quantity_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;
			if (radioButton.Checked)
			{
				tb_Quantity.Enabled = true;
				tb_Sum.Enabled = false;

				gb_GasStationPay.Text = "До оплати";
				lbl3_grn.Text = "грн.";
			}
		}

		private void rb_Sum_CheckedChanged(object sender, EventArgs e)
		{
			tb_Quantity.Enabled = false;
			tb_Sum.Enabled = true;

			gb_GasStationPay.Text = "До видачі";
			lbl3_grn.Text = "л.";
		}

		private void tb_Quantity_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox.Text == "")
			{
				lbl_GasStationAmount.Text = "0.00";
				return;
			}

			try
			{
				Convert.ToDouble(textBox.Text);
			}
			catch (Exception)
			{
				textBox.Text = "";
				return;
			}

			lbl_GasStationAmount.Text = String.Format("{0:0.00}", Convert.ToDouble(tb_PriceForFuel.Text) * Convert.ToDouble(tb_Quantity.Text));
		}

		private void tb_Sum_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox.Text == "")
			{
				tb_Quantity.Text = "";
				lbl_GasStationAmount.Text = "0.00";
				return;
			}

			try
			{
				Convert.ToDouble(textBox.Text);
			}
			catch (Exception)
			{
				textBox.Text = "";
				return;
			}

			tb_Quantity.Text = String.Format("{0:0.00}",(Convert.ToDouble(tb_Sum.Text) / Convert.ToDouble(tb_PriceForFuel.Text)));
			lbl_GasStationAmount.Text = tb_Quantity.Text;
		}
	}
}
