using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace BestOil
{
	public partial class CashierForm : Form
	{
		private decimal _totalIncome;
		private BindingList<Goods> _fuels;
		private BindingList<Goods> _products;
		private List<ProductControl> _productControls = new List<ProductControl>();
		private BindingList<string> _fuelNames = new BindingList<string>();
		private readonly string PATH_TO_FUEL = $"{Environment.CurrentDirectory}\\FuelPrice.Json";
		private readonly string PATH_TO_PRODUCTS = $"{Environment.CurrentDirectory}\\ProductsPrice.Json";

		public CashierForm()
		{
			InitializeComponent();
			#region Fuel
			FileIOService _fileIOService = new FileIOService(PATH_TO_FUEL, PATH_TO_PRODUCTS);
			_fileIOService.LoadData(ref _fuels, ref _products);

			for (int i = 0; i < _fuels.Count; i++)
				_fuelNames.Add(_fuels[i].ProductName);

			comBx_ListOfGasolineTypes.DataSource = _fuelNames;
			#endregion
			#region Cafe
			for (int i = 0; i < _products.Count; i++)
			{
				CheckBox checkBox = new CheckBox();
				checkBox.Location = new Point(20, 15 + i * 45);
				checkBox.Font = new Font("Verdana", 10, FontStyle.Italic);
				checkBox.AutoSize= true;
				checkBox.Text = _products[i].ProductName;
				checkBox.CheckedChanged += CheckBox_CheckedChanged;

				TextBox textBoxPrice = new TextBox();
				textBoxPrice.Location = new Point(200, 15 + i * 45);
				textBoxPrice.Size = new Size(65, 22);
				textBoxPrice.Text = _products[i].Price;
				textBoxPrice.ReadOnly = true;

				NumericUpDown numericUpDownAmount = new NumericUpDown();
				numericUpDownAmount.Location = new Point(310, 15 + i * 45);
				numericUpDownAmount.Size = new Size(65, 22);
				numericUpDownAmount.Minimum = 0;
				numericUpDownAmount.Maximum = 1000;
				numericUpDownAmount.Enabled = false;
				numericUpDownAmount.ValueChanged += NumericUpDownAmount_ValueChanged;

				_productControls.Add(new ProductControl
				{
					Name = _products[i].ProductName,
					Price = Convert.ToDecimal(_products[i].Price),
					CheckBox_Enable = checkBox,
					TextBox_Price = textBoxPrice,
					Quantity = numericUpDownAmount
				});

				panel_MiniCafe.Controls.Add(numericUpDownAmount);
				panel_MiniCafe.Controls.Add(checkBox);
				panel_MiniCafe.Controls.Add(textBoxPrice);

			}
			#endregion
		}

		private void NumericUpDownAmount_ValueChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible= false;

			decimal SumAll = 0;
			for (int i = 0; i < _productControls.Count; i++)
			{
				if (_productControls[i].CheckBox_Enable.Checked == true)
				{
					SumAll += _productControls[i].Price * _productControls[i].Quantity.Value;
				}
			}
			lbl_MiniCafeAmount.Text = String.Format("{0:0.00}", SumAll);
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible = false;

			CheckBox check = sender as CheckBox;
			for (int i = 0; i < _productControls.Count; i++)
			{
				if (_productControls[i].CheckBox_Enable == check)
				{
					_productControls[i].Quantity.Enabled = check.Checked;
					NumericUpDownAmount_ValueChanged(sender, e);
					break;
				}
			}
		}

		private void comBx_ListOfGasolineTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible = false;

			ComboBox comboBox = sender as ComboBox;
			tb_PriceForFuel.Text = _fuels[comboBox.SelectedIndex].Price;

			if (rb_Quantity.Checked)
			{
				tb_Quantity.Enabled = true;
				tb_Sum.Enabled = false;

				if (tb_Quantity.Text != "")
					lbl_GasStationAmount.Text = String.Format("{0:0.00}", Convert.ToDecimal(tb_PriceForFuel.Text) * Convert.ToDecimal(tb_Quantity.Text));


				gb_GasStationPay.Text = gb_MiniCafePay.Text;
				lbl3_grn.Text = lbl1_grn.Text;
			}
			else if (rb_Sum.Checked)
			{
				tb_Quantity.Enabled = false;
				tb_Sum.Enabled = true;

				if (tb_Sum.Text != "")
				{
					tb_Quantity.Text = String.Format("{0:0.00}", (Convert.ToDecimal(tb_Sum.Text) / Convert.ToDecimal(tb_PriceForFuel.Text)));
					lbl_GasStationAmount.Text = tb_Quantity.Text;
				}

				if (Program.Language == "")
				{
					gb_GasStationPay.Text = "До видачі";
					lbl3_grn.Text = "л.";
				}
				else if(Program.Language == "en")
				{
					gb_GasStationPay.Text = "Should be issued";
					lbl3_grn.Text = "liters";
				}
			}
		}

		private void rb_Quantity_CheckedChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible = false;

			RadioButton radioButton = sender as RadioButton;
			if (radioButton.Checked)
			{
				tb_Quantity.Enabled = true;
				tb_Sum.Enabled = false;

				gb_GasStationPay.Text = gb_MiniCafePay.Text;
				lbl3_grn.Text = lbl1_grn.Text;

				tb_Sum.Text = "0.00";
			}
		}

		private void rb_Sum_CheckedChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible = false;

			tb_Quantity.Enabled = false;
			tb_Sum.Enabled = true;

			if (Program.Language == "")
			{
				gb_GasStationPay.Text = "До видачі";
				lbl3_grn.Text = "л.";
			}
			else if (Program.Language == "en")
			{
				gb_GasStationPay.Text = "Should be issued";
				lbl3_grn.Text = "liters";
			}

			tb_Quantity.Text = "0.00";
		}

		private void tb_Quantity_TextChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible = false;

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

			lbl_GasStationAmount.Text = String.Format("{0:0.00}", Convert.ToDecimal(tb_PriceForFuel.Text) * Convert.ToDecimal(tb_Quantity.Text));
		}

		private void tb_Sum_TextChanged(object sender, EventArgs e)
		{
			btn_PrintCheck.Visible = false;

			TextBox textBox = sender as TextBox;
			if (textBox.Text == "")
			{
				tb_Quantity.Text = "0.00";
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

			tb_Quantity.Text = String.Format("{0:0.00}",(Convert.ToDecimal(tb_Sum.Text) / Convert.ToDecimal(tb_PriceForFuel.Text)));
			lbl_GasStationAmount.Text = tb_Quantity.Text;
		}

		private void btn_PrintCheck_Click(object sender, EventArgs e)
		{
			comBx_ListOfGasolineTypes.SelectedIndex = 0;
			rb_Quantity.Checked = true;
			rb_Sum.Checked = false;
			tb_Quantity.Text = "0.00";
			tb_Sum.Text = "0.00";
			lbl_GasStationAmount.Text = "0.00";
			foreach (var item in _productControls)
			{
				item.Quantity.Value = 0;
				item.Quantity.Enabled = false;
				item.CheckBox_Enable.Checked = false;
			}
			lbl_TotalIncome.Text = String.Format("{0:0.00}", _totalIncome);

			lbl_TotalAmount.Text = "0.00";
		}

		private void btn_Count_Click(object sender, EventArgs e)
		{
			decimal tmp = 0.0M;

			if (rb_Quantity.Checked)
				tmp = Convert.ToDecimal(lbl_GasStationAmount.Text);
			else if(rb_Sum.Checked)
				tmp = Convert.ToDecimal(tb_Sum);

			decimal totalSum = tmp + Convert.ToDecimal(lbl_MiniCafeAmount.Text);
			_totalIncome += totalSum;

			lbl_TotalAmount.Text = String.Format("{0:0.00}", totalSum);

			btn_PrintCheck.Visible = true;
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
