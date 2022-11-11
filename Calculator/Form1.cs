using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		//Fields
		private Calculator _calculator = new Calculator();

		//Constructor without parameters
		public Form1()
		{
			InitializeComponent();
		}

		private void btnNumber_Click(object sender, EventArgs e)
		{
			Button btnNum = sender as Button;
			_calculator.UpdateNumber(btnNum.Text);

			if (!_calculator.IsPressedOperator && _calculator.GetNumber1().Length <= 16)
				lblNumber1.Text = _calculator.GetNumber1();
			else if(_calculator.IsPressedOperator && _calculator.GetNumber2().Length <=16)
				lblNumber2.Text = _calculator.GetNumber2();
		}

		private void btnBinaryOperators_Click(object sender, EventArgs e)
		{
			if (lblNumber1.Text != "")
			{
				Button btnOperator = sender as Button;
				_calculator.IsPressedOperator = true;
				lblOperator.Text = btnOperator.Text;
			}
		}

		private void btnUnaryOperator_Click(object sender, EventArgs e)
		{
			Button btnOperator = sender as Button;
			_calculator.Operation(btnOperator.Text);
			lblNumber1.Text = _calculator.GetNumber1();
			lblNumber2.Text = _calculator.GetNumber2();
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			_calculator.MakeFloat();
			lblNumber1.Text = _calculator.GetNumber1();
			lblNumber2.Text = _calculator.GetNumber2();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_calculator.ClearAll();
			lblNumber1.Text = "";
			lblNumber2.Text = "";
			lblOperator.Text = "";
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			if (lblNumber1.Text != "")
			{
				string tmp;

				if (lblNumber2.Text == "")
					tmp = _calculator.GetNumber1();
				else
					tmp = _calculator.Operation(lblOperator.Text);

				btnClear_Click(sender, e);
				lblNumber1.Text = tmp;
			}
		}

		private void btnProcent_Click(object sender, EventArgs e)
		{
			if (lblNumber1.Text != "" && lblNumber2.Text != "")
			{
				string tmp = "";

				if (lblOperator.Text == "-")
					tmp = _calculator.Operation(lblOperator.Text + "%");
				else if(lblOperator.Text == "x")
					tmp = _calculator.Operation(lblOperator.Text + "%");

				btnClear_Click(sender, e);
				lblNumber1.Text = tmp;
			}
		}
	}
}
