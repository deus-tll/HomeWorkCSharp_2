using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_1
{
	public partial class Form1 : Form
	{
		private int x, y;
		List<ExtendedLabel> labels = new List<ExtendedLabel>();
		Random random = new Random();
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				int width = 0, height = 0;

				if (e.Location.X > x && e.Location.Y > y)
				{
					width = e.Location.X - x;
					height = e.Location.Y - y;
				}
				else if (e.Location.X < x && e.Location.Y > y)
				{
					width = x - e.Location.X;
					height = e.Location.Y - y;
				}
				else if(e.Location.X > x && e.Location.Y < y)
				{
					width = e.Location.X - x;
					height = y - e.Location.Y;
				}
				else if(e.Location.X < x && e.Location.Y < y)
				{
					width = x - e.Location.X;
					height = y - e.Location.Y;
				}

				if (width < 10 || height < 10)
				{
					MessageBox.Show("Лейбл не був створений! Мінімальний розмір 10х10.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}


				ExtendedLabel label = new ExtendedLabel();


				label.AutoSize = false;

				if (e.Location.X > x && e.Location.Y > y)
				{
					label.Location = new Point(x, y);
					label.relation = Relation.RightBottom;
				}
				else if (e.Location.X < x && e.Location.Y > y)
				{
					label.Location = new Point(e.Location.X, y);
					label.relation = Relation.LeftBottom;
				}
				else if (e.Location.X > x && e.Location.Y < y)
				{
					label.Location = new Point(x, e.Location.Y);
					label.relation = Relation.RightTop;
				}
				else if(e.Location.X < x && e.Location.Y < y)
				{
					label.Location = new Point(e.Location.X, e.Location.Y);
					label.relation = Relation.LeftTop;
				}



				label.Name = $"label_{labels.Count + 1}";
				label.Text = $"{labels.Count + 1}";


				label.Size = new Size(width, height);
				label.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));


				switch (label.relation)
				{
					case Relation.RightBottom:
						label.LeftBound = x;
						label.TopBound = y;
						label.RightBound = e.Location.X;
						label.BottomBound = e.Location.Y;
						break;
					case Relation.LeftBottom:
						label.LeftBound = e.Location.X;
						label.TopBound = y;
						label.RightBound = x;
						label.BottomBound = e.Location.Y;
						break;
					case Relation.LeftTop:
						label.LeftBound = e.Location.X;
						label.TopBound = e.Location.Y;
						label.RightBound = x;
						label.BottomBound = y;
						break;
					case Relation.RightTop:
						label.LeftBound = x;
						label.TopBound = e.Location.Y;
						label.RightBound = e.Location.X;
						label.BottomBound = y;
						break;
					default:
						break;
				}

				label.IndexInControlCollection = this.Controls.Count;


				label.MouseClick += Label_MouseClick;
				label.MouseDoubleClick += Label_MouseDoubleClick;
				

				labels.Add(label);
				this.Controls.Add(label);
			}
		}

		private void Label_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ExtendedLabel tmp = (sender as ExtendedLabel);
				int coord_x_form = tmp.Location.X + e.X;
				int coord_y_form = tmp.Location.Y + e.Y;


				int i = labels.Count - 1;
				int? min = null;
				for (; i >= 0; --i)
				{
					if (labels[i].IsPlacedByCoords(coord_x_form, coord_y_form))
						min = i;
				}

				if (min is null)
					return;
				else
				{
					this.Controls.RemoveAt(labels[(int)min].IndexInControlCollection);


					labels.RemoveAt((int)min);


					for (int j = 0; j < labels.Count; j++)
					{
						labels[j].IndexInControlCollection = j;
					}
				}
			}
		}

		private void Label_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ExtendedLabel tmp = (sender as ExtendedLabel);
				int coord_x_form = tmp.Location.X + e.X;
				int coord_y_form = tmp.Location.Y + e.Y;

				int i = 0;
				int? max = null;
				for (; i < labels.Count; ++i)
				{
					if (labels[i].IsPlacedByCoords(coord_x_form, coord_y_form))
						max = i;
				}
				

				if (max is null)
					return;
				else
					this.Text = $"{labels[(int)max].Name}; S = {labels[(int)max].Width * labels[(int)max].Width}; X = {labels[(int)max].Location.X}, Y = {labels[(int)max].Location.Y}";
			}
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				x = e.Location.X;
				y = e.Location.Y;
			}
		}
	}
}
