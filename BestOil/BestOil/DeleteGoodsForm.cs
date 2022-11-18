using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
	public partial class DeleteGoodsForm : Form
	{
		private readonly List<string> _list = new List<string>();
		public int Index { get; private set; }
		public DeleteGoodsForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(BindingList<Goods> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				_list.Add(list[i].ProductName + $" ({list[i].Price} грн.)");
			}
			comboBox1.DataSource= _list;
			return ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != -1)
			{
				int ind = comboBox1.SelectedIndex;
				string tmp = "";

				if (Program.Language == "")
					tmp = $"Точно хочете видалити {_list[ind]}";

				else if (Program.Language == "en")
					tmp = $"Do you really want to delete {_list[ind]}";

				if (MessageBox.Show(tmp, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Index = ind;
					this.DialogResult = DialogResult.OK;
					Close();
				}
			}
			else
			{
				if (Program.Language == "")
					SelectingMessageBox("Треба вибрати елемент!", "Попередження");

				else if (Program.Language == "en")
					SelectingMessageBox("You need to select an element!", "Warning");

				return;
			}
		}

		private void SelectingMessageBox(string text, string warning) =>
			MessageBox.Show(text, warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
