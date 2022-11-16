using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestOil
{
	public partial class AddingGoodsForm : Form
	{
		public AddingGoodsForm()
		{
			InitializeComponent();
		}

		public string GoodsName { get; private set; } = null;

		public string GoodsPrice { get; private set; } = null;

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtB_Name.Text == "" || txtB_Price.Text == "")
			{
				MessageBox.Show("Будь-яке поле не може бути пустим!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			GoodsName = txtB_Name.Text;
			GoodsPrice = txtB_Price.Text;

			DialogResult = DialogResult.OK;

			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult= DialogResult.Cancel;
			Close();
		}
	}
}
