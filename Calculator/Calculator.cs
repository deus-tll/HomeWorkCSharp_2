using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Calculator
	{
		private StringBuilder _number1 = new StringBuilder();
		private StringBuilder _number2 = new StringBuilder();


		public bool IsPressedOperator { get; set; }
		public bool IsPressedDot { get; set; }


		public string Operation(string _operator)
		{
			switch (_operator)
			{
				case "+": return (Convert.ToDouble(_number1.ToString()) + Convert.ToDouble(_number2.ToString())).ToString();
				case "-": return (Convert.ToDouble(_number1.ToString()) - Convert.ToDouble(_number2.ToString())).ToString();
				case "/": return (Convert.ToDouble(_number1.ToString()) / Convert.ToDouble(_number2.ToString())).ToString();
				case "x": return (Convert.ToDouble(_number1.ToString()) * Convert.ToDouble(_number2.ToString())).ToString();
				case "±":
					string negateNum;
					if (!IsPressedOperator)
					{
						negateNum = Negate(_number1.ToString());
						_number1.Clear();
						_number1.Append(negateNum);
						return _number1.ToString();
					}
					else
					{
						negateNum = Negate(_number2.ToString());
						_number2.Clear();
						_number2.Append(negateNum);
						return _number2.ToString();
					}
				case "√":
					string SqrtNum;
					if (!IsPressedOperator)
					{
						SqrtNum = Sqrt(_number1.ToString());
						_number1.Clear();
						_number1.Append(SqrtNum);
						return _number1.ToString();
					}
					else
					{
						SqrtNum = Sqrt(_number2.ToString());
						_number2.Clear();
						_number2.Append(SqrtNum);
						return _number2.ToString();
					}
				case "x%":
					return (Convert.ToDouble(_number2.ToString()) / 100).ToString();
				case "-%":
					return ((Convert.ToDouble(_number1.ToString()) / 100) * Convert.ToDouble(_number2.ToString())).ToString();
			}

			return null;
		}


		private string Negate(string num)
		{
			if (num != "")
				return (-Convert.ToDouble(num)).ToString();
			return "";
		}
		private string Sqrt(string num)
		{
			if (num != "")
				return Math.Sqrt(Convert.ToDouble(num)).ToString();
			return "";
		}


		public void UpdateNumber(string digit)
		{
			if (!IsPressedOperator) _number1.Append(digit);
			else					_number2.Append(digit);
		}

		public void MakeFloat()
		{
			if (!IsPressedOperator)
			{
				if (!_number1.ToString().Contains(".") && !(_number1.Length == 0))
					_number1.Append(".");
			}
			else 
			{
				if (!_number2.ToString().Contains(".") && !(_number2.Length == 0))
					_number2.Append(".");
			}
		}


		public void ClearAll()
		{
			_number1.Clear(); _number2.Clear();
			IsPressedDot = false;
			IsPressedOperator = false;
		}


		public string GetNumber1() => _number1.ToString();
		public string GetNumber2() => _number2.ToString();
	}
}
