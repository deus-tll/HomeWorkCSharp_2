using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
	public partial class Form1 : Form
	{
		Label label = new Label();
		Random random = new Random();
		public Form1()
		{
			InitializeComponent();

			label.AutoSize = false;
			label.Location = new Point(200, 200);

			label.Size = new Size(100, 100);


			label.MouseMove += Label_MouseMove;

			label.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
			this.Controls.Add(label);
		}

		private void Label_MouseMove(object sender, MouseEventArgs e)
		{
			label.Left = random.Next(0, this.ClientSize.Width - label.Width);
			label.Top = random.Next(0, this.ClientSize.Height - label.Height);
		}
	}
}
