using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
	public partial class EditingGoodsForm : Form
	{
		private readonly List<string> _listStrings = new List<string>();
		private BindingList<Goods> _listGoods;
		public int Index { get; private set; }
		public string GoodsName { get; private set; } = null;
		public string GoodsPrice { get; private set; } = null;

		public EditingGoodsForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(BindingList<Goods> list)
		{
			_listGoods = list;
			string tmp = "";

			if (Program.Language == "")
				tmp = "грн.";
			else if (Program.Language == "en")
				tmp = "UAH";

			for (int i = 0; i < list.Count; i++)
			{
				_listStrings.Add(list[i].ProductName + $" ({list[i].Price}" + tmp + ".)");
			}
			comboBox1.DataSource = _listStrings;
			return ShowDialog();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;

			txtB_Name.Text = _listGoods[comboBox.SelectedIndex].ProductName;
			txtB_Price.Text = _listGoods[comboBox.SelectedIndex].Price;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string tmp1 = "";
			string tmp2 = "";

			if (Program.Language == "")
			{
				tmp1 = "Будь-яке поле не може бути пустим!";
				tmp2 = "Попередження";
			}
			else if (Program.Language == "en")
			{
				tmp1 = "Any field cannot be empty!";
				tmp2 = "Warning";
			}


			if (txtB_Name.Text == "" || txtB_Price.Text == "")
			{
				MessageBox.Show(tmp1, tmp2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			GoodsName = txtB_Name.Text;
			GoodsPrice = txtB_Price.Text;
			Index = comboBox1.SelectedIndex;

			DialogResult = DialogResult.OK;

			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
