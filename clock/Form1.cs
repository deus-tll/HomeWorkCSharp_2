using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace clock
{
	public partial class Form1 : Form
    {
		int center_x, center_y;
		double lenSecArr, lenMinArr, lenHrArr;
		double widSecArr, widMinArr, widHrArr;

		int hour;
		int minute;
		int second;

		Timer t = new Timer();

		public Form1()
        {
            InitializeComponent();
			resizeArrows();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			t.Interval = 1000;
			t.Tick += new EventHandler(t_Tick);
			t.Start();
		}


		private int[] CoordsOfSecMin(int value, double arrowlength)
		{
			return Coords(value *= 6, arrowlength);
		}

		private int[] CoordsOfHours(int hours, int minutes, double arrowLength)
		{
			return Coords((int)((hours * 30) + (minutes * 0.5)), arrowLength);
		}


		private int[] Coords(int value, double arrowlength)
		{
			int[] result = new int[2];

			if (value >= 0 && value <= 180)
			{
				result[0] = center_x + (int)(arrowlength * Math.Sin(Math.PI * value / 180));
				result[1] = center_y - (int)(arrowlength * Math.Cos(Math.PI * value / 180));
			}
			else
			{
				result[0] = center_x - (int)(arrowlength * -Math.Sin(Math.PI * value / 180));
				result[1] = center_y - (int)(arrowlength * Math.Cos(Math.PI * value / 180));
			}

			return result;
		}


		private void t_Tick(object sender, EventArgs e)
		{
			hour = DateTime.Now.Hour;
			minute = DateTime.Now.Minute;
			second = DateTime.Now.Second;

			int[] arrowCoords;

			Graphics g = pictureBox1.CreateGraphics();
			g.SmoothingMode = SmoothingMode.HighQuality;

			this.Refresh();

			arrowCoords = CoordsOfHours(hour % 12, minute, lenHrArr);
			g.DrawLine(MakePen(Color.DarkMagenta, widHrArr), new Point(center_x, center_y), new Point(arrowCoords[0], arrowCoords[1]));


			arrowCoords = CoordsOfSecMin(minute, lenMinArr);
			g.DrawLine(MakePen(Color.Black, widMinArr), new Point(center_x, center_y), new Point(arrowCoords[0], arrowCoords[1]));


			arrowCoords = CoordsOfSecMin(second, lenSecArr);
			g.DrawLine(MakePen(Color.Gold, widSecArr), new Point(center_x, center_y), new Point(arrowCoords[0], arrowCoords[1]));
		}

		private Pen MakePen(Color color, double width)
		{
			Pen p = new Pen(color, (float)width);
			p.StartCap = LineCap.RoundAnchor;
			p.EndCap = LineCap.ArrowAnchor;

			return p;
		}

		private void resizeArrows()
		{
			center_x = pictureBox1.Width / 2;
			center_y = pictureBox1.Height / 2;

			if (center_x > center_y)
				Calculate(center_y);
			else
				Calculate(center_x);
		}


		private void Calculate(int value)
		{
			lenSecArr = (57.1428571428571 / 100) * (double)value;
			lenMinArr = (51.4285714285714 / 100) * (double)value;
			lenHrArr = (42.8571428571429 / 100) * (double)value;

			widSecArr = (2.28571428571429 / 100) * (double)value;
			widMinArr = (3.42857142857143 / 100) * (double)value;
			widHrArr = (4.57142857142857 / 100) * (double)value;
		}


		private void Form1_Resize(object sender, System.EventArgs e)
		{
			resizeArrows();
		}

		
	}
}
