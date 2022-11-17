using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
	public class ProductControl
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public CheckBox CheckBox_Enable { get; set; }
		public TextBox TextBox_Price { get; set; }
		public NumericUpDown Quantity { get; set; }
	}
}
