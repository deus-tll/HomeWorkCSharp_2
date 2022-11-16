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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "admin")
			{
				AdminForm adminForm = new AdminForm();
				adminForm.ShowDialog();
			}
			else
			{
				CashierForm cashierForm = new CashierForm();
				cashierForm.ShowDialog();
			}
		}
	}
}
