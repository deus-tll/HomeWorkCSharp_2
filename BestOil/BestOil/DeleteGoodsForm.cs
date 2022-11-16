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
			if(comboBox1.SelectedIndex != -1)
			{
				int ind = comboBox1.SelectedIndex;
				if (MessageBox.Show($"Точно хочете видалити {_list[ind]}", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Index = ind;
					this.DialogResult = DialogResult.OK;
					Close();
				}
			}
			else
			{
				MessageBox.Show("Треба вибрати елемент!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
