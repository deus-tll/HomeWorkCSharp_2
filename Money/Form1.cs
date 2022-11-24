using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
	public partial class Form1 : Form
	{
		Calculate calculate;

		public Form1()
		{
			InitializeComponent();

			calculate = new Calculate();

			lbl_Amount.Text = calculate.ToString();
		}

		private void listView1_MouseDown(object sender, MouseEventArgs e)
		{
			ListView listView = sender as ListView;

			listView.DoDragDrop((ListViewItem)listView.FocusedItem.Clone(), DragDropEffects.Copy);
		}

		private void listView2_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(ListViewItem)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect= DragDropEffects.None;
		}

		private void listView2_DragDrop(object sender, DragEventArgs e)
		{
			ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

			int number = Convert.ToInt32(item.Text.Remove(item.Text.Length - 2, 2));
			char label = Convert.ToChar(item.Text.Remove(0, item.Text.Length - 1)); 

			calculate.Update(number, label);
			lbl_Amount.Text = calculate.ToString();

			listView2.Items.Add(item);
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			listView2.Items.Clear();
			listView2.Refresh();
			calculate.Reset();
			lbl_Amount.Text = calculate.ToString();
		}
	}
}
