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
