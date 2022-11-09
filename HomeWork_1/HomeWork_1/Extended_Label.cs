using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
	public enum Relation
	{
		RightBottom,
		LeftBottom,
		LeftTop,
		RightTop
	}
	internal class ExtendedLabel : Label
	{
		public int IndexInControlCollection { get; set; }
		public int LeftBound { get; set; }
		public int RightBound { get; set; }
		public int TopBound { get; set; }
		public int BottomBound { get; set; }

		public Relation relation;

		public bool IsPlacedByCoords(int x, int y)
		{
			if (x > LeftBound && x < RightBound && y < BottomBound && y > TopBound)
				return true;

			return false;
		}
	}
}
