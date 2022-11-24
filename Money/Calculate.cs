using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
	public class Calculate
	{
		private int _p = 0;
		private int _f = 0;


		private void AddP(int p) =>	_p += p;
		

		private void AddF(int f)
		{
			int tmp = _f + f;
			if (tmp == 100)
			{
				++_p;
				_f = 0;
			}
			else if(tmp > 100)
			{
				_p += 1;
				_f = tmp - 100;
			}
			else
			{
				_f = tmp;
			}
		}


		public void Update(int number, char label)
		{
			switch (label)
			{
				case 'p':
					AddP(number);
					break;
				case 'f':
					AddF(number);
					break;
			}
		}


		public void Reset()
		{
			_p = 0;
			_f = 0;
		}


		public override string ToString()
		{
			return $"{_f}f {_p}p";
		}
	}
}
